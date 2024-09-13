using Enrollment_System.Database;
using Enrollment_System.Entity_Class;

namespace Enrollment_System.Screens
{
    public partial class Admin : Form
    {
        private static Admin adminInstance;

        private int currentUnit;

        public Admin()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            pnlUnits.Visible = true;
            pnlOption.Visible = false;
            pnlCtrl.Visible = false;

        }

        public static Admin GetAdminInstance()
        {
            if (adminInstance == null || adminInstance.IsDisposed)
            {
                adminInstance = new Admin();
            }
            return adminInstance;
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (currentUnit > 0)
            {
                updateUnitStatus($"unit_{currentUnit}", "Inactive", "None");
            }
            pnlUnits.Visible = true;
            pnlOption.Visible = false;
            pnlCtrl.Visible = false;

            Main.GetMainInstance().Show();
            this.Hide();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            lblOption.Text = "Enrollment";

            pnlOption.Visible = false;
            pnlCtrl.Visible = true;

            btnNxtEnroll.Enabled = true;
            btnNxtAdvise.Enabled = false;

            updateUnitStatus($"unit_{currentUnit}", "Active", "Enrollment");

        }
        private void btnAdvise_Click(object sender, EventArgs e)
        {
            lblOption.Text = "Advising";

            pnlOption.Visible = false;
            pnlCtrl.Visible = true;

            btnNxtEnroll.Enabled = true;
            btnNxtAdvise.Enabled = true;

            updateUnitStatus($"unit_{currentUnit}", "Active", "Advising");
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (lblOption.Text == "Enrollment")
            {
                lblOption.Text = "Advising";
                btnNxtEnroll.Enabled = true;
                btnNxtAdvise.Enabled = true;
                updateUnitStatus($"unit_{currentUnit}", "Active", "Advising");
            }
            else if (lblOption.Text == "Advising")
            {
                lblOption.Text = "Enrollment";
                btnNxtEnroll.Enabled = true;
                btnNxtAdvise.Enabled = false;
                updateUnitStatus($"unit_{currentUnit}", "Active", "Enrollment");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            updateUnitStatus($"unit_{currentUnit}", "Inactive", "None");
            pnlOption.Visible = false;
            pnlCtrl.Visible = false;
            pnlUnits.Visible = true;

            Main.GetMainInstance().Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tbEnrollment = DBHelper.Instance.getTicketNumber("Enrollment");
            dspEnroll.Text = tbEnrollment;

            string tbAdvising = DBHelper.Instance.getTicketNumber("Advising");
            dspAdvise.Text = tbAdvising;

            LoadUnitStatus();

            var currentNumber = DBHelper.Instance.getCurrentNumber($"unit_{currentUnit}");
            currentUnitNum.Text = currentNumber;

            var studentName = DBHelper.Instance.getStudentName(currentNumber);
            lblStudentID.Text = $"Name: {studentName}";

            if (lblOption.Text == "Advising" && currentUnitNum.Text.StartsWith("A"))
            {
                btnSwitch.Enabled = false;

            } else {
                btnSwitch.Enabled = true;
            }

        }

        public void updateUnitStatus(string unit, string status, string type)
        {
            var newUpdate = new Units();
            newUpdate.currentUnit = unit;
            newUpdate.currentStatus = status;
            newUpdate.currentType = type;
            int updateUnitStatus = DBHelper.Instance.updateUnit(newUpdate);

            if (updateUnitStatus < 0)
            {
                MessageBox.Show("Error choosing unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void transferUI()
        {
            pnlUnits.Visible = false;
            pnlOption.Visible = true;
        }
        private void btnUnit1_Click(object sender, EventArgs e)
        {
            currentUnit = 1;
            transferUI();
        }
        private void btnUnit2_Click(object sender, EventArgs e)
        {
            currentUnit = 2;
            transferUI();
        }
        private void btnUnit3_Click(object sender, EventArgs e)
        {
            currentUnit = 3;
            transferUI();
        }
        private void btnUnit4_Click(object sender, EventArgs e)
        {
            currentUnit = 4;
            transferUI();
        }
        private void btnUnit5_Click(object sender, EventArgs e)
        {
            currentUnit = 5;
            transferUI();
        }
        private void btnUnit6_Click(object sender, EventArgs e)
        {
            currentUnit = 6;
            transferUI();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            updateUnitStatus($"unit_{currentUnit}", "Inactive", "None");

            pnlOption.Visible = false;
            pnlUnits.Visible = true;
        }

        private void LoadUnitStatus()
        {
            var unitsStatus = DBHelper.Instance.getUnitStatus();

            btnUnit1.Enabled = unitsStatus["unit_1"] != "Active";
            btnUnit2.Enabled = unitsStatus["unit_2"] != "Active";
            btnUnit3.Enabled = unitsStatus["unit_3"] != "Active";
            btnUnit4.Enabled = unitsStatus["unit_4"] != "Active";
            btnUnit5.Enabled = unitsStatus["unit_5"] != "Active";
            btnUnit6.Enabled = unitsStatus["unit_6"] != "Active";
        }

        private void btnNxtEnroll_Click(object sender, EventArgs e)
        {
            string adviseText = dspAdvise.Text.Trim();

            if ((lblOption.Text == "Advising" && adviseText != "None") || currentUnitNum.Text.StartsWith("A"))
            {
                MessageBox.Show("Advising Queue still available. Prioritize Advising Queue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HandleNextButtonClick("Enrollment", dspEnroll.Text);
        }

        private void btnNxtAdvise_Click(object sender, EventArgs e)
        {
            if (currentUnitNum.Text.StartsWith("E"))
            {
                HandleNextButtonClick("Enrollment", dspAdvise.Text);
                return;
            }
            HandleNextButtonClick("Advising", dspAdvise.Text);
        }

        private void HandleNextButtonClick(string type, string displayText)
        {
            if (!string.IsNullOrEmpty(currentUnitNum.Text) && currentUnitNum.Text != "None")
            {
                DBHelper.Instance.deleteMinTicketNumber(type, currentUnitNum.Text);
            }

            var updateUnit = new Units
            {
                currentUnit = $"unit_{currentUnit}",
                currentNum = displayText
            };

            int updateUnitNum = DBHelper.Instance.updateUnitNum(updateUnit);

            if (updateUnitNum < 0)
            {
                MessageBox.Show("Error choosing unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            var currentNumber = DBHelper.Instance.getCurrentNumber($"unit_{currentUnit}");
            currentUnitNum.Text = currentNumber;

            var update = new Tickets
            {
                status = "Serving",
                unit = $"unit_{currentUnit}",
                ticketNum = displayText
            };

            var updatedTicket = DBHelper.Instance.updateTicket(update);

            if (updatedTicket < 0)
            {
                MessageBox.Show("Queue Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (updatedTicket == 0)
            {
                MessageBox.Show("Error updating ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
