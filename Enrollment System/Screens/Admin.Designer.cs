namespace Enrollment_System.Screens
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            MainText = new Label();
            btnEnroll = new Button();
            btnAdvise = new Button();
            pnlOption = new Panel();
            btnBack = new PictureBox();
            pnlCtrl = new Panel();
            currentUnitNum = new Label();
            label1 = new Label();
            dspAdvise = new TextBox();
            dspEnroll = new TextBox();
            btnSwitch = new Button();
            lblStudentID = new Label();
            lblCurrent = new Label();
            lblOption = new Label();
            btnQuit = new Button();
            btnNxtAdvise = new Button();
            btnNxtEnroll = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlUnits = new Panel();
            btnUnit6 = new Button();
            btnUnit5 = new Button();
            btnUnit4 = new Button();
            btnUnit3 = new Button();
            btnUnit2 = new Button();
            label2 = new Label();
            btnUnit1 = new Button();
            pnlOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            pnlCtrl.SuspendLayout();
            pnlUnits.SuspendLayout();
            SuspendLayout();
            // 
            // MainText
            // 
            MainText.AutoSize = true;
            MainText.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainText.Location = new Point(62, 9);
            MainText.Name = "MainText";
            MainText.Size = new Size(299, 37);
            MainText.TabIndex = 6;
            MainText.Text = "ADMIN CONTROL";
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.FromArgb(117, 161, 215);
            btnEnroll.Cursor = Cursors.Hand;
            btnEnroll.FlatStyle = FlatStyle.Flat;
            btnEnroll.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnroll.ForeColor = Color.FromArgb(11, 24, 40);
            btnEnroll.Location = new Point(68, 13);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(249, 221);
            btnEnroll.TabIndex = 7;
            btnEnroll.Text = "Enrollment";
            btnEnroll.UseVisualStyleBackColor = false;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // btnAdvise
            // 
            btnAdvise.BackColor = Color.FromArgb(117, 161, 215);
            btnAdvise.Cursor = Cursors.Hand;
            btnAdvise.FlatStyle = FlatStyle.Flat;
            btnAdvise.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdvise.ForeColor = Color.FromArgb(11, 24, 40);
            btnAdvise.Location = new Point(68, 263);
            btnAdvise.Name = "btnAdvise";
            btnAdvise.Size = new Size(249, 221);
            btnAdvise.TabIndex = 8;
            btnAdvise.Text = "Advising";
            btnAdvise.UseVisualStyleBackColor = false;
            btnAdvise.Click += btnAdvise_Click;
            // 
            // pnlOption
            // 
            pnlOption.Controls.Add(btnBack);
            pnlOption.Controls.Add(btnAdvise);
            pnlOption.Controls.Add(btnEnroll);
            pnlOption.Location = new Point(12, 61);
            pnlOption.Name = "pnlOption";
            pnlOption.Size = new Size(381, 543);
            pnlOption.TabIndex = 9;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(3, 503);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(60, 32);
            btnBack.SizeMode = PictureBoxSizeMode.CenterImage;
            btnBack.TabIndex = 16;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // pnlCtrl
            // 
            pnlCtrl.Controls.Add(currentUnitNum);
            pnlCtrl.Controls.Add(label1);
            pnlCtrl.Controls.Add(dspAdvise);
            pnlCtrl.Controls.Add(dspEnroll);
            pnlCtrl.Controls.Add(btnSwitch);
            pnlCtrl.Controls.Add(lblStudentID);
            pnlCtrl.Controls.Add(lblCurrent);
            pnlCtrl.Controls.Add(lblOption);
            pnlCtrl.Controls.Add(btnQuit);
            pnlCtrl.Controls.Add(btnNxtAdvise);
            pnlCtrl.Controls.Add(btnNxtEnroll);
            pnlCtrl.Location = new Point(10, 50);
            pnlCtrl.Name = "pnlCtrl";
            pnlCtrl.Size = new Size(397, 544);
            pnlCtrl.TabIndex = 10;
            // 
            // currentUnitNum
            // 
            currentUnitNum.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentUnitNum.ForeColor = Color.MidnightBlue;
            currentUnitNum.Location = new Point(1, 372);
            currentUnitNum.Name = "currentUnitNum";
            currentUnitNum.Size = new Size(395, 79);
            currentUnitNum.TabIndex = 19;
            currentUnitNum.Text = "None";
            currentUnitNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 129);
            label1.Name = "label1";
            label1.Size = new Size(90, 24);
            label1.TabIndex = 17;
            label1.Text = "Advising";
            // 
            // dspAdvise
            // 
            dspAdvise.BackColor = SystemColors.ScrollBar;
            dspAdvise.BorderStyle = BorderStyle.FixedSingle;
            dspAdvise.Enabled = false;
            dspAdvise.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            dspAdvise.Location = new Point(211, 155);
            dspAdvise.Name = "dspAdvise";
            dspAdvise.Size = new Size(160, 29);
            dspAdvise.TabIndex = 16;
            // 
            // dspEnroll
            // 
            dspEnroll.BackColor = SystemColors.ScrollBar;
            dspEnroll.BorderStyle = BorderStyle.FixedSingle;
            dspEnroll.Enabled = false;
            dspEnroll.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            dspEnroll.Location = new Point(25, 155);
            dspEnroll.Name = "dspEnroll";
            dspEnroll.Size = new Size(160, 29);
            dspEnroll.TabIndex = 15;
            // 
            // btnSwitch
            // 
            btnSwitch.BackColor = Color.FromArgb(117, 161, 215);
            btnSwitch.Cursor = Cursors.Hand;
            btnSwitch.FlatStyle = FlatStyle.Flat;
            btnSwitch.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSwitch.ForeColor = Color.FromArgb(11, 24, 40);
            btnSwitch.Location = new Point(25, 488);
            btnSwitch.Name = "btnSwitch";
            btnSwitch.Size = new Size(160, 50);
            btnSwitch.TabIndex = 14;
            btnSwitch.Text = "Switch";
            btnSwitch.UseVisualStyleBackColor = false;
            btnSwitch.Click += btnSwitch_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentID.Location = new Point(5, 80);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(333, 23);
            lblStudentID.TabIndex = 13;
            lblStudentID.Text = "Name:";
            // 
            // lblCurrent
            // 
            lblCurrent.AutoSize = true;
            lblCurrent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrent.Location = new Point(25, 129);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(111, 24);
            lblCurrent.TabIndex = 12;
            lblCurrent.Text = "Enrollment";
            // 
            // lblOption
            // 
            lblOption.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOption.Location = new Point(2, 19);
            lblOption.Name = "lblOption";
            lblOption.Size = new Size(395, 38);
            lblOption.TabIndex = 11;
            lblOption.Text = "Enrollment";
            lblOption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.FromArgb(117, 161, 215);
            btnQuit.Cursor = Cursors.Hand;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.FromArgb(11, 24, 40);
            btnQuit.Location = new Point(211, 488);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(160, 50);
            btnQuit.TabIndex = 11;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnNxtAdvise
            // 
            btnNxtAdvise.BackColor = Color.FromArgb(117, 161, 215);
            btnNxtAdvise.Cursor = Cursors.Hand;
            btnNxtAdvise.FlatStyle = FlatStyle.Flat;
            btnNxtAdvise.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNxtAdvise.ForeColor = Color.FromArgb(11, 24, 40);
            btnNxtAdvise.Location = new Point(211, 195);
            btnNxtAdvise.Name = "btnNxtAdvise";
            btnNxtAdvise.Size = new Size(160, 148);
            btnNxtAdvise.TabIndex = 9;
            btnNxtAdvise.Text = "Next\r\nAdvising";
            btnNxtAdvise.UseVisualStyleBackColor = false;
            btnNxtAdvise.Click += btnNxtAdvise_Click;
            // 
            // btnNxtEnroll
            // 
            btnNxtEnroll.BackColor = Color.FromArgb(117, 161, 215);
            btnNxtEnroll.Cursor = Cursors.Hand;
            btnNxtEnroll.FlatStyle = FlatStyle.Flat;
            btnNxtEnroll.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNxtEnroll.ForeColor = Color.FromArgb(11, 24, 40);
            btnNxtEnroll.Location = new Point(25, 195);
            btnNxtEnroll.Name = "btnNxtEnroll";
            btnNxtEnroll.Size = new Size(160, 148);
            btnNxtEnroll.TabIndex = 8;
            btnNxtEnroll.Text = "Next\r\nEnrollment";
            btnNxtEnroll.UseVisualStyleBackColor = false;
            btnNxtEnroll.Click += btnNxtEnroll_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pnlUnits
            // 
            pnlUnits.Controls.Add(btnUnit6);
            pnlUnits.Controls.Add(btnUnit5);
            pnlUnits.Controls.Add(btnUnit4);
            pnlUnits.Controls.Add(btnUnit3);
            pnlUnits.Controls.Add(btnUnit2);
            pnlUnits.Controls.Add(label2);
            pnlUnits.Controls.Add(btnUnit1);
            pnlUnits.Location = new Point(6, 59);
            pnlUnits.Name = "pnlUnits";
            pnlUnits.Size = new Size(398, 526);
            pnlUnits.TabIndex = 11;
            // 
            // btnUnit6
            // 
            btnUnit6.BackColor = Color.FromArgb(117, 161, 215);
            btnUnit6.Cursor = Cursors.Hand;
            btnUnit6.FlatStyle = FlatStyle.Flat;
            btnUnit6.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            btnUnit6.ForeColor = Color.FromArgb(11, 24, 40);
            btnUnit6.Location = new Point(215, 363);
            btnUnit6.Name = "btnUnit6";
            btnUnit6.Size = new Size(180, 136);
            btnUnit6.TabIndex = 14;
            btnUnit6.Text = "6";
            btnUnit6.UseVisualStyleBackColor = false;
            btnUnit6.Click += btnUnit6_Click;
            // 
            // btnUnit5
            // 
            btnUnit5.BackColor = Color.FromArgb(117, 161, 215);
            btnUnit5.Cursor = Cursors.Hand;
            btnUnit5.FlatStyle = FlatStyle.Flat;
            btnUnit5.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            btnUnit5.ForeColor = Color.FromArgb(11, 24, 40);
            btnUnit5.Location = new Point(13, 363);
            btnUnit5.Name = "btnUnit5";
            btnUnit5.Size = new Size(180, 136);
            btnUnit5.TabIndex = 13;
            btnUnit5.Text = "5";
            btnUnit5.UseVisualStyleBackColor = false;
            btnUnit5.Click += btnUnit5_Click;
            // 
            // btnUnit4
            // 
            btnUnit4.BackColor = Color.FromArgb(117, 161, 215);
            btnUnit4.Cursor = Cursors.Hand;
            btnUnit4.FlatStyle = FlatStyle.Flat;
            btnUnit4.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            btnUnit4.ForeColor = Color.FromArgb(11, 24, 40);
            btnUnit4.Location = new Point(215, 210);
            btnUnit4.Name = "btnUnit4";
            btnUnit4.Size = new Size(180, 136);
            btnUnit4.TabIndex = 12;
            btnUnit4.Text = "4";
            btnUnit4.UseVisualStyleBackColor = false;
            btnUnit4.Click += btnUnit4_Click;
            // 
            // btnUnit3
            // 
            btnUnit3.BackColor = Color.FromArgb(117, 161, 215);
            btnUnit3.Cursor = Cursors.Hand;
            btnUnit3.FlatStyle = FlatStyle.Flat;
            btnUnit3.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            btnUnit3.ForeColor = Color.FromArgb(11, 24, 40);
            btnUnit3.Location = new Point(13, 210);
            btnUnit3.Name = "btnUnit3";
            btnUnit3.Size = new Size(180, 136);
            btnUnit3.TabIndex = 11;
            btnUnit3.Text = "3";
            btnUnit3.UseVisualStyleBackColor = false;
            btnUnit3.Click += btnUnit3_Click;
            // 
            // btnUnit2
            // 
            btnUnit2.BackColor = Color.FromArgb(117, 161, 215);
            btnUnit2.Cursor = Cursors.Hand;
            btnUnit2.FlatStyle = FlatStyle.Flat;
            btnUnit2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            btnUnit2.ForeColor = Color.FromArgb(11, 24, 40);
            btnUnit2.Location = new Point(214, 57);
            btnUnit2.Name = "btnUnit2";
            btnUnit2.Size = new Size(180, 136);
            btnUnit2.TabIndex = 10;
            btnUnit2.Text = "2";
            btnUnit2.UseVisualStyleBackColor = false;
            btnUnit2.Click += btnUnit2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, -1);
            label2.Name = "label2";
            label2.Size = new Size(176, 37);
            label2.TabIndex = 9;
            label2.Text = "Select unit";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUnit1
            // 
            btnUnit1.BackColor = Color.FromArgb(117, 161, 215);
            btnUnit1.Cursor = Cursors.Hand;
            btnUnit1.FlatStyle = FlatStyle.Flat;
            btnUnit1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUnit1.ForeColor = Color.FromArgb(11, 24, 40);
            btnUnit1.Location = new Point(13, 57);
            btnUnit1.Name = "btnUnit1";
            btnUnit1.Size = new Size(180, 136);
            btnUnit1.TabIndex = 8;
            btnUnit1.Text = "1";
            btnUnit1.UseVisualStyleBackColor = false;
            btnUnit1.Click += btnUnit1_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 228, 244);
            ClientSize = new Size(419, 606);
            Controls.Add(MainText);
            Controls.Add(pnlCtrl);
            Controls.Add(pnlUnits);
            Controls.Add(pnlOption);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            FormClosed += Admin_FormClosed;
            Load += Admin_Load;
            pnlOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            pnlCtrl.ResumeLayout(false);
            pnlCtrl.PerformLayout();
            pnlUnits.ResumeLayout(false);
            pnlUnits.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainText;
        private Button btnEnroll;
        private Button btnAdvise;
        private Panel pnlOption;
        private Panel pnlCtrl;
        private Button btnNxtEnroll;
        private Label lblOption;
        private Button btnQuit;
        private Label lblCurrent;
        private Label lblStudentID;
        private Button btnNxtAdvise;
        private Button btnSwitch;
        private TextBox dspAdvise;
        private TextBox dspEnroll;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Panel pnlUnits;
        private Button btnUnit6;
        private Button btnUnit5;
        private Button btnUnit4;
        private Button btnUnit3;
        private Button btnUnit2;
        private Label label2;
        private Button btnUnit1;
        private PictureBox btnBack;
        private Label currentUnitNum;
    }
}