namespace Enrollment_System.Screens
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            MainText = new Label();
            label1 = new Label();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbProgram = new ComboBox();
            cbYear = new ComboBox();
            label4 = new Label();
            tbEmail = new TextBox();
            label5 = new Label();
            tbID = new TextBox();
            label6 = new Label();
            tbPhoneNum = new TextBox();
            label7 = new Label();
            tbRFID = new TextBox();
            label8 = new Label();
            btnStudentReg = new Button();
            btnClose = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // MainText
            // 
            MainText.AutoSize = true;
            MainText.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainText.Location = new Point(293, 9);
            MainText.Name = "MainText";
            MainText.Size = new Size(351, 39);
            MainText.TabIndex = 6;
            MainText.Text = "Student Registration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(157, 31);
            label1.TabIndex = 7;
            label1.Text = "First Name";
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFirstName.Location = new Point(12, 121);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(443, 31);
            tbFirstName.TabIndex = 8;
            tbFirstName.KeyDown += tbRFID_KeyDown;
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLastName.Location = new Point(12, 204);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(443, 31);
            tbLastName.TabIndex = 10;
            tbLastName.KeyDown += tbRFID_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 168);
            label2.Name = "label2";
            label2.Size = new Size(154, 31);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(486, 256);
            label3.Name = "label3";
            label3.Size = new Size(124, 31);
            label3.TabIndex = 11;
            label3.Text = "Program";
            // 
            // cbProgram
            // 
            cbProgram.DropDownHeight = 100;
            cbProgram.Font = new Font("Microsoft Sans Serif", 15.75F);
            cbProgram.FormattingEnabled = true;
            cbProgram.IntegralHeight = false;
            cbProgram.Location = new Point(486, 292);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(231, 33);
            cbProgram.TabIndex = 18;
            cbProgram.TextUpdate += cbProgram_TextUpdate;
            cbProgram.KeyDown += tbRFID_KeyDown;
            // 
            // cbYear
            // 
            cbYear.DropDownHeight = 100;
            cbYear.Font = new Font("Microsoft Sans Serif", 15.75F);
            cbYear.FormattingEnabled = true;
            cbYear.IntegralHeight = false;
            cbYear.Location = new Point(723, 292);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(206, 33);
            cbYear.TabIndex = 20;
            cbYear.KeyDown += tbRFID_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(723, 256);
            label4.Name = "label4";
            label4.Size = new Size(75, 31);
            label4.TabIndex = 13;
            label4.Text = "Year";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(486, 121);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(443, 31);
            tbEmail.TabIndex = 14;
            tbEmail.KeyDown += tbRFID_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(486, 85);
            label5.Name = "label5";
            label5.Size = new Size(183, 31);
            label5.TabIndex = 15;
            label5.Text = "School Email";
            // 
            // tbID
            // 
            tbID.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbID.Location = new Point(486, 204);
            tbID.Name = "tbID";
            tbID.Size = new Size(443, 31);
            tbID.TabIndex = 16;
            tbID.KeyDown += tbRFID_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(486, 168);
            label6.Name = "label6";
            label6.Size = new Size(141, 31);
            label6.TabIndex = 17;
            label6.Text = "School ID";
            // 
            // tbPhoneNum
            // 
            tbPhoneNum.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhoneNum.Location = new Point(12, 292);
            tbPhoneNum.Name = "tbPhoneNum";
            tbPhoneNum.Size = new Size(443, 31);
            tbPhoneNum.TabIndex = 12;
            tbPhoneNum.KeyDown += tbRFID_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 256);
            label7.Name = "label7";
            label7.Size = new Size(207, 31);
            label7.TabIndex = 19;
            label7.Text = "Phone Number";
            // 
            // tbRFID
            // 
            tbRFID.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbRFID.Location = new Point(12, 378);
            tbRFID.Name = "tbRFID";
            tbRFID.Size = new Size(443, 31);
            tbRFID.TabIndex = 22;
            tbRFID.KeyDown += tbRFID_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 342);
            label8.Name = "label8";
            label8.Size = new Size(83, 31);
            label8.TabIndex = 21;
            label8.Text = "RFID";
            // 
            // btnStudentReg
            // 
            btnStudentReg.BackColor = Color.FromArgb(117, 161, 215);
            btnStudentReg.Cursor = Cursors.Hand;
            btnStudentReg.FlatStyle = FlatStyle.Flat;
            btnStudentReg.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentReg.ForeColor = Color.FromArgb(11, 24, 40);
            btnStudentReg.Location = new Point(486, 378);
            btnStudentReg.Name = "btnStudentReg";
            btnStudentReg.Size = new Size(443, 196);
            btnStudentReg.TabIndex = 23;
            btnStudentReg.Text = "REGISTER";
            btnStudentReg.UseVisualStyleBackColor = false;
            btnStudentReg.Click += btnStudentReg_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(891, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 24;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 228, 244);
            ClientSize = new Size(941, 589);
            Controls.Add(btnClose);
            Controls.Add(btnStudentReg);
            Controls.Add(tbRFID);
            Controls.Add(label8);
            Controls.Add(tbPhoneNum);
            Controls.Add(label7);
            Controls.Add(tbID);
            Controls.Add(label6);
            Controls.Add(tbEmail);
            Controls.Add(label5);
            Controls.Add(cbYear);
            Controls.Add(label4);
            Controls.Add(cbProgram);
            Controls.Add(label3);
            Controls.Add(tbLastName);
            Controls.Add(label2);
            Controls.Add(tbFirstName);
            Controls.Add(label1);
            Controls.Add(MainText);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainText;
        private Label label1;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private Label label2;
        private Label label3;
        private ComboBox cbProgram;
        private ComboBox cbYear;
        private Label label4;
        private TextBox tbEmail;
        private Label label5;
        private TextBox tbID;
        private Label label6;
        private TextBox tbPhoneNum;
        private Label label7;
        private TextBox tbRFID;
        private Label label8;
        private Button btnStudentReg;
        private PictureBox btnClose;
        private System.Windows.Forms.Timer timer1;
    }
}