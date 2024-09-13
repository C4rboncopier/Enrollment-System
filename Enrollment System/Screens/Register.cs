using Enrollment_System.Database;
using Enrollment_System.Entity_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System.Screens
{
    public partial class Register : Form
    {
        private static Register registerInstance;

        private string[] programLists =
            {
                "BSA", "BSE", "BSMA", "BSREM", "BSTM",
                "BACOMM", "BMMA",
                "BSCS", "BSEMC", "BSIS",
                "BSAr", "BSChE", "BSCE", "BSCpE", "BSEE", "BSECE", "BSIE", "BSME",
                "BSBio", "BSPsy", "BSPh", "BSPT"
            };

        private string[] yearLists =
            {
                "1st Year", "2nd Year", "3rd Year", "4th Year", "5th Year"
            };

        public Register()
        {
            InitializeComponent();
            registerInstance = this;

            this.KeyDown += tbRFID_KeyDown;

            InitializeComboBox();
        }

        public static Register GetRegisterInstance()
        {
            if (registerInstance == null || registerInstance.IsDisposed)
            {
                registerInstance = new Register();
            }
            return registerInstance;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            cbProgram.Click += new EventHandler(ComboBox_ShowDropdown);
            cbProgram.Enter += new EventHandler(ComboBox_ShowDropdown);
            cbYear.Click += new EventHandler(ComboBox_ShowDropdown);
            cbYear.Enter += new EventHandler(ComboBox_ShowDropdown);

        }

        private void InitializeComboBox()
        {
            cbYear.Items.AddRange(yearLists);
            cbProgram.Items.AddRange(programLists);
            cbProgram.TextUpdate += cbProgram_TextUpdate;
        }

        public void clearInputs()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            tbEmail.Clear();
            tbID.Clear();
            tbPhoneNum.Clear();
            cbProgram.SelectedIndex = -1;
            cbYear.SelectedIndex = -1;
            tbRFID.Clear();
        }

        private void registration()
        {
            var _firstName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tbFirstName.Text.ToLower());
            var _lastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tbLastName.Text.ToLower());
            var _schoolEmail = tbEmail.Text;
            var _schoolID = tbID.Text;
            var _phoneNum = tbPhoneNum.Text;
            var _program = cbProgram.Text;
            var _year = cbYear.Text;
            var _RFID = tbRFID.Text;

            if (String.IsNullOrEmpty(_firstName) || String.IsNullOrEmpty(_lastName) || String.IsNullOrEmpty(_schoolEmail) ||
                String.IsNullOrEmpty(_schoolID) || String.IsNullOrEmpty(_phoneNum) || String.IsNullOrEmpty(_program) ||
                String.IsNullOrEmpty(_year) || String.IsNullOrEmpty(_RFID))
            {
                MessageBox.Show("Please input all requirements.");
                return;
            }

            if (!_schoolEmail.EndsWith("@mcm.edu.ph"))
            {
                MessageBox.Show("School Email must end with @mcm.edu.ph");
                return;
            }

            if ((!_phoneNum.StartsWith("09") && !_phoneNum.StartsWith("08")) || _phoneNum.Length != 11)
            {
                MessageBox.Show("Phone number must start with 09 or 08 and be 11 digits long.");
                return;
            }

            var newAccount = new Accounts
            {
                firstName = _firstName,
                lastName = _lastName,
                email = _schoolEmail,
                schoolID = _schoolID,
                phoneNumber = _phoneNum,
                program = _program,
                year = _year,
                RFID = _RFID
            };

            var isAccountFound = DBHelper.Instance.GetUserID(newAccount.RFID);
            if (isAccountFound > 0)
            {
                MessageBox.Show("Student already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearInputs();
                return;
            }

            var insertedAccount = DBHelper.Instance.CreateUser(newAccount);
            if (insertedAccount == null)
            {
                MessageBox.Show("Student failed to create account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearInputs();
                return;
            }

            MessageBox.Show("Registration Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearInputs();
            Main.GetMainInstance().Show();
            this.Hide();
        }

        private void btnStudentReg_Click(object sender, EventArgs e)
        {
            registration();
        }

        private void tbRFID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registration();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Main.GetMainInstance().Show();
            this.Hide();
        }

        private void cbProgram_TextUpdate(object sender, EventArgs e)
        {
            string userInput = cbProgram.Text;
            string[] filteredList = programLists
                .Where(program => program.IndexOf(userInput, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToArray();

            UpdateComboBox(filteredList, userInput);
        }

        private void UpdateComboBox(string[] filteredList, string userInput)
        {
            cbProgram.Items.Clear();
            cbProgram.Items.AddRange(filteredList);
            cbProgram.DroppedDown = true;
            cbProgram.Select(cbProgram.Text.Length, 0);
            Cursor.Current = Cursors.Default;
        }

        private void ComboBox_ShowDropdown(object sender, EventArgs e)
        {
            ComboBox? comboBox = sender as ComboBox;
            if (comboBox != null )
            {
                comboBox.DroppedDown = true;
            }
        }
    }
}
