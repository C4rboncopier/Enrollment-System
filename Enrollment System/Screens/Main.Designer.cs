namespace Enrollment_System.Screens
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btnClose = new PictureBox();
            txtTime = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnReg = new Button();
            btnQue = new Button();
            btnDisplay = new Button();
            btnAdmin = new Button();
            MainText = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1120, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 9;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTime.Location = new Point(235, 587);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(75, 33);
            txtTime.TabIndex = 8;
            txtTime.Text = "time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 587);
            label2.Name = "label2";
            label2.Size = new Size(207, 33);
            label2.TabIndex = 7;
            label2.Text = "Current Time:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnReg);
            flowLayoutPanel1.Controls.Add(btnQue);
            flowLayoutPanel1.Controls.Add(btnDisplay);
            flowLayoutPanel1.Controls.Add(btnAdmin);
            flowLayoutPanel1.Location = new Point(34, 108);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1102, 461);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.FromArgb(117, 161, 215);
            btnReg.Cursor = Cursors.Hand;
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReg.ForeColor = Color.FromArgb(11, 24, 40);
            btnReg.Location = new Point(3, 3);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(545, 221);
            btnReg.TabIndex = 0;
            btnReg.Text = "REGISTER";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnReg_Click;
            // 
            // btnQue
            // 
            btnQue.BackColor = Color.FromArgb(97, 147, 209);
            btnQue.Cursor = Cursors.Hand;
            btnQue.FlatStyle = FlatStyle.Flat;
            btnQue.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQue.ForeColor = Color.FromArgb(11, 24, 40);
            btnQue.Location = new Point(554, 3);
            btnQue.Name = "btnQue";
            btnQue.Size = new Size(545, 221);
            btnQue.TabIndex = 1;
            btnQue.Text = "QUEUE SYSTEM";
            btnQue.UseVisualStyleBackColor = false;
            btnQue.Click += btnQue_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.FromArgb(97, 147, 209);
            btnDisplay.Cursor = Cursors.Hand;
            btnDisplay.FlatStyle = FlatStyle.Flat;
            btnDisplay.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplay.ForeColor = Color.FromArgb(11, 24, 40);
            btnDisplay.Location = new Point(3, 230);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(545, 221);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "DISPLAY";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(117, 161, 215);
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.FromArgb(11, 24, 40);
            btnAdmin.Location = new Point(554, 230);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(545, 221);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "ADMIN CONTROL";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // MainText
            // 
            MainText.AutoSize = true;
            MainText.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainText.Location = new Point(364, 20);
            MainText.Name = "MainText";
            MainText.Size = new Size(443, 55);
            MainText.TabIndex = 5;
            MainText.Text = "Enrollment System";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 228, 244);
            ClientSize = new Size(1170, 641);
            Controls.Add(btnClose);
            Controls.Add(txtTime);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(MainText);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnClose;
        private Label txtTime;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnReg;
        private Button btnQue;
        private Button btnDisplay;
        private Button btnAdmin;
        private Label MainText;
        private System.Windows.Forms.Timer timer1;
    }
}