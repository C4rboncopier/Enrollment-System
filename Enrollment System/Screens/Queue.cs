using Enrollment_System.Database;
using Enrollment_System.Entity_Class;
using System.Drawing.Printing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System.Screens
{
    public partial class Queue : Form
    {
        private static Queue queueInstance;

        private string _studentType;
        private string _notifOptions = "None";

        private bool _EnrollmentNotif;
        private bool _AdvisingNotif;

        private int xpos = 500;
        private int ypos = 380;

        public Queue()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void startingPanel()
        {
            pnlOption.Visible = true;
            pnlNotif.Visible = false;
            pnlMail.Visible = false;
            pnlRFID.Visible = false;
        }

        private void Queue_Load(object sender, EventArgs e)
        {
            startingPanel();
        }

        public static Queue GetQueueInstance()
        {
            if (queueInstance == null || queueInstance.IsDisposed)
            {
                queueInstance = new Queue();
            }
            return queueInstance;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int enrollNum = DBHelper.Instance.QueueRowCount("Enrollment");
            int adviseNum = DBHelper.Instance.QueueRowCount("Advising");

            _EnrollmentNotif = enrollNum < 10 ? false : true;
            _AdvisingNotif = adviseNum < 10 ? false : true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Main.GetMainInstance().Show();
            this.Hide();

            startingPanel();
        }

        private void SetVisibility(Control controlToShow, params Control[] controlsToHide)
        {
            foreach (var control in controlsToHide)
            {
                control.Visible = false;
            }
            controlToShow.Visible = true;
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (_EnrollmentNotif)
            {
                SetVisibility(pnlNotif, pnlOption, pnlMail);
            }
            else
            {
                SetVisibility(pnlRFID, pnlOption);
                btnBack3.Visible = false;
                tbScan.Focus();
            }

            _studentType = "Enrollment";
        }
        private void btnAdvise_Click(object sender, EventArgs e)
        {
            if (_AdvisingNotif)
            {
                SetVisibility(pnlNotif, pnlOption, pnlMail);
            }
            else
            {
                SetVisibility(pnlRFID, pnlOption);
                btnBack3.Visible = false;
                tbScan.Focus();
            }
            _studentType = "Advising";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            SetVisibility(pnlMail, pnlNotif);
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            SetVisibility(pnlRFID, pnlNotif);
            _notifOptions = "None";
            tbScan.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SetVisibility(pnlOption, pnlMail, pnlNotif);
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {
            SetVisibility(pnlRFID, pnlMail);
            _notifOptions = "SMS";
            btnBack3.Visible = true;
            tbScan.Focus();
        }
        private void btnEmail_Click(object sender, EventArgs e)
        {
            SetVisibility(pnlRFID, pnlMail);
            _notifOptions = "Email";
            btnBack3.Visible = true;
            tbScan.Focus();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            SetVisibility(pnlNotif, pnlMail);
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            SetVisibility(pnlNotif, pnlRFID);
        }

        private void tbScan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var _RFID = tbScan.Text.Trim();

                if (String.IsNullOrEmpty(_RFID))
                {
                    MessageBox.Show("Please input all requirements");
                    return;
                }

                DateTime datetime = DateTime.Now;

                var isAccountFound = DBHelper.Instance.GetUserID(_RFID);
                if (isAccountFound < 0)
                {
                    MessageBox.Show("Student not found. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbScan.Clear();
                    return;
                }

                var GetStudentID = DBHelper.Instance.getStudentID(_RFID);

                //var isTicketFound = DBHelper.Instance.isTicketFound(GetStudentID);
                //if (isTicketFound > 0)
                //{
                //    MessageBox.Show("Student already generated a ticket.", "Ticket already found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    tbScan.Clear();
                //    return;
                //}

                var newTicket = new Tickets
                {
                    studentID = $"{GetStudentID}",
                    studentType = _studentType,
                    dateTime = datetime.ToString("MM/dd/yyyy hh:mm:ss tt"),
                    notifOptions = _notifOptions,
                };

                var insertTicket = DBHelper.Instance.CreateTicket(newTicket);
                if (insertTicket == null)
                {
                    MessageBox.Show("Ticket failed to create.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbScan.Clear();
                    return;
                }

                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("pprnm", xpos, ypos);
                using (PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog())
                {
                    printPreviewDialog1.ClientSize = new Size(250, 300);
                    printPreviewDialog1.StartPosition = FormStartPosition.CenterScreen;
                    printPreviewDialog1.Document = printDocument1;
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }

                tbScan.Clear();
                pnlOption.Visible = true;
                pnlNotif.Visible = false;
                pnlMail.Visible = false;
                pnlRFID.Visible = false;
                Main.GetMainInstance().Show();
                this.Hide();
            }

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(
                "Mapua Malayan Colleges Mindanao",
                new Font("Century Gothic", 14, FontStyle.Bold),
                Brushes.Black,
                new Point(xpos / 2 - 174, 12)
                );

            string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Media", "Logo.png");
            Image logo = Image.FromFile(logoPath);
            e.Graphics.DrawImage(logo, new Rectangle(xpos / 2 - 85, 45, 167, 140));

            e.Graphics.DrawString(
                "TICKET NUMBER",
                new Font("Century Gothic", 20, FontStyle.Bold),
                Brushes.Black,
                new Point(xpos / 2 - 108, 200)
                );

            var maxTicketNum = DBHelper.Instance.getMaxNumber(_studentType);
            Font fontTicket = new Font("Century Gothic", 48, FontStyle.Bold);
            SizeF textSize = e.Graphics.MeasureString(maxTicketNum, fontTicket);
            e.Graphics.DrawString(
                maxTicketNum,
                fontTicket,
                Brushes.Black,
                new PointF((e.PageBounds.Width / 2) - (textSize.Width / 2), 240)
            );

            Font fontType = new Font("Century Gothic", 24, FontStyle.Bold);
            SizeF typeSize = e.Graphics.MeasureString(_studentType, fontType);
            e.Graphics.DrawString(
                _studentType,
                fontType,
                Brushes.Black,
                new PointF((e.PageBounds.Width / 2) - (typeSize.Width / 2), 315)
                );
        }


    }
}
