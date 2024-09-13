using Enrollment_System.Database;
using Enrollment_System.Entity_Class;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Enrollment_System.Screens
{
    public partial class Display : Form
    {
        private static Display displayInstance;

        private float originalWidth;
        private float originalHeight;

        public Display()
        {
            InitializeComponent();
            displayInstance = this;

            timer1.Start();

            originalWidth = this.Width;
            originalHeight = this.Height;
        }

        public static Display GetDisplayInstance()
        {
            if (displayInstance == null || displayInstance.IsDisposed)
            {
                displayInstance = new Display();
            }
            return displayInstance;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var units = new string[] { "unit_1", "unit_2", "unit_3", "unit_4", "unit_5", "unit_6" };
            var labels = new Label[] { lblUnit1, lblUnit2, lblUnit3, lblUnit4, lblUnit5, lblUnit6 };

            for (int i = 0; i < units.Length; i++)
            {
                var unitStatus = DBHelper.Instance.getSpecificUnitStatus(units[i]);
                labels[i].Text = $"Unit {i + 1}: {unitStatus}";
            }

            var ticketLabels = new Label[] { lblNum1, lblNum2, lblNum3, lblNum4, lblNum5, lblNum6 };
            for (int i = 0; i < units.Length; i++)
            {
                var ticketNum = DBHelper.Instance.getCurrentNumber(units[i]);
                ticketLabels[i].Text = ticketNum;
            }
        }

        private void Display_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.GetMainInstance().Show();
            this.Hide();
        }

        private void Display_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                float scaleX = (float)this.Width / originalWidth;
                float scaleY = (float)this.Height / originalHeight;

                foreach (Control control in this.Controls)
                {
                    control.Scale(new SizeF(scaleX, scaleY));
                }

                originalWidth = this.Width;
                originalHeight = this.Height;
            }
        }

    }
}
