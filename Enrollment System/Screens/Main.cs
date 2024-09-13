using Enrollment_System.Database;
using Enrollment_System.Notifications;
using Enrollment_System.Entity_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Enrollment_System.Screens
{
    public partial class Main : Form
    {

        private static Main mainInstance;

        private string currentStudentEmail1 = "";
        private string currentStudentEmail2 = "";
        private string currentStudentNumber1 = "";
        private string currentStudentNumber2 = "";


        public Main()
        {
            InitializeComponent();
            mainInstance = this;

            timer1.Start();
        }

        public static Main GetMainInstance()
        {
            if (mainInstance == null || mainInstance.IsDisposed)
            {
                mainInstance = new Main();
            }
            return mainInstance;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            txtTime.Text = dateTime.ToString("hh:mm:ss tt");

            advisingtNotif();
            enrollmentNotif();
        }

        private void enrollmentNotif()
        {
            var CheckTicket = DBHelper.Instance.CheckEnrollmentTickets();
            string studentNotif = DBHelper.Instance.getStudentNotif(CheckTicket);
            var notifStatus = DBHelper.Instance.getNotifStatus(CheckTicket);

            if (CheckTicket != null && notifStatus == "None")
            {
                if (studentNotif == "Email")
                {
                    string studentEmail = DBHelper.Instance.getStudentEmail(CheckTicket);

                    if (studentEmail != currentStudentEmail1)
                    {
                        Accounts account = new Accounts
                        {
                            email = studentEmail
                        };
                        currentStudentEmail1 = studentEmail;

                        Tickets ticket = new Tickets
                        {
                            ticketNum = CheckTicket
                        };

                        EmailSender.SendEmailAsync(account, ticket);

                        int updateNotifStatus = DBHelper.Instance.updateNotifStatus(CheckTicket);
                        if (updateNotifStatus < 0)
                        {
                            MessageBox.Show("Error updating ticket notifications", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }
                }

                //if (studentNotif == "SMS")
                //{
                //    string studentNumber = DBHelper.Instance.getStudentNumber(CheckTicket);
                //    string modified = studentNumber.Substring(1);
                //    string finalNumber = "+63" + modified;

                //    if (finalNumber != currentStudentNumber1)
                //    {
                //        Accounts account = new Accounts
                //        {
                //            phoneNumber = finalNumber
                //        };
                //        currentStudentNumber1 = finalNumber;
                //        TextSender.SendTextAsync(account);
                //    }
                //}
            }
        }

        private void advisingtNotif()
        {
            var CheckTicket = DBHelper.Instance.CheckAdvisingTickets();
            string studentNotif = DBHelper.Instance.getStudentNotif(CheckTicket);
            var notifStatus = DBHelper.Instance.getNotifStatus(CheckTicket);

            if (CheckTicket != null && notifStatus == "None")
            {
                if (studentNotif == "Email")
                {
                    string studentEmail = DBHelper.Instance.getStudentEmail(CheckTicket);

                    if (studentEmail != currentStudentEmail2)
                    {
                        Accounts account = new Accounts
                        {
                            email = studentEmail
                        };
                        currentStudentEmail2 = studentEmail;

                        Tickets ticket = new Tickets
                        {
                            ticketNum = CheckTicket
                        };

                        EmailSender.SendEmailAsync(account, ticket);

                        int updateNotifStatus = DBHelper.Instance.updateNotifStatus(CheckTicket);
                        if (updateNotifStatus < 0)
                        {
                            MessageBox.Show("Error updating ticket notifications", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }
                }

                //if (studentNotif == "SMS")
                //{
                //    string studentNumber = DBHelper.Instance.getStudentNumber(CheckTicket);
                //    string modified = studentNumber.Substring(1);
                //    string finalNumber = "+63" + modified;

                //    if (finalNumber != currentStudentNumber2)
                //    {
                //        Accounts account = new Accounts
                //        {
                //            phoneNumber = finalNumber
                //        };
                //        currentStudentNumber2 = finalNumber;
                //        TextSender.SendTextAsync(account);
                //    }
                //}
            }
        }


        private void btnReg_Click(object sender, EventArgs e)
        {
            Register.GetRegisterInstance().Show();
            this.Hide();
        }

        private void btnQue_Click(object sender, EventArgs e)
        {
            Queue.GetQueueInstance().Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin.GetAdminInstance().Show();
            this.Hide();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Display displayForm = Display.GetDisplayInstance();
            displayForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
