namespace Enrollment_System.Screens
{
    partial class Queue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Queue));
            MainText = new Label();
            pnlOption = new FlowLayoutPanel();
            btnEnroll = new Button();
            btnAdvise = new Button();
            btnClose = new PictureBox();
            pnlNotif = new Panel();
            btnNo = new Button();
            btnYes = new Button();
            label1 = new Label();
            btnBack = new PictureBox();
            pnlMail = new Panel();
            btnEmail = new Button();
            btnSMS = new Button();
            label2 = new Label();
            btnBack2 = new PictureBox();
            pnlRFID = new Panel();
            btnBack3 = new PictureBox();
            tbScan = new TextBox();
            label3 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            pnlNotif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            pnlMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack2).BeginInit();
            pnlRFID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack3).BeginInit();
            SuspendLayout();
            // 
            // MainText
            // 
            MainText.AutoSize = true;
            MainText.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainText.Location = new Point(314, 14);
            MainText.Name = "MainText";
            MainText.Size = new Size(314, 58);
            MainText.TabIndex = 7;
            MainText.Text = "Queue Ticket";
            // 
            // pnlOption
            // 
            pnlOption.Controls.Add(btnEnroll);
            pnlOption.Controls.Add(btnAdvise);
            pnlOption.Location = new Point(29, 82);
            pnlOption.Name = "pnlOption";
            pnlOption.Size = new Size(884, 492);
            pnlOption.TabIndex = 8;
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.FromArgb(97, 147, 209);
            btnEnroll.FlatStyle = FlatStyle.Flat;
            btnEnroll.Font = new Font("Roboto", 21.75F, FontStyle.Bold);
            btnEnroll.ForeColor = Color.FromArgb(11, 24, 40);
            btnEnroll.Location = new Point(3, 3);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(435, 435);
            btnEnroll.TabIndex = 0;
            btnEnroll.Text = "ENROLLMENT";
            btnEnroll.UseVisualStyleBackColor = false;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // btnAdvise
            // 
            btnAdvise.BackColor = Color.FromArgb(117, 161, 215);
            btnAdvise.FlatStyle = FlatStyle.Flat;
            btnAdvise.Font = new Font("Roboto", 21.75F, FontStyle.Bold);
            btnAdvise.ForeColor = Color.FromArgb(11, 24, 40);
            btnAdvise.Location = new Point(444, 3);
            btnAdvise.Name = "btnAdvise";
            btnAdvise.Size = new Size(435, 435);
            btnAdvise.TabIndex = 1;
            btnAdvise.Text = "ADVISING";
            btnAdvise.UseVisualStyleBackColor = false;
            btnAdvise.Click += btnAdvise_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(891, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 25;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlNotif
            // 
            pnlNotif.Controls.Add(btnNo);
            pnlNotif.Controls.Add(btnYes);
            pnlNotif.Controls.Add(label1);
            pnlNotif.Controls.Add(btnBack);
            pnlNotif.Location = new Point(25, 75);
            pnlNotif.Name = "pnlNotif";
            pnlNotif.Size = new Size(894, 502);
            pnlNotif.TabIndex = 26;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(117, 161, 215);
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Roboto", 21.75F, FontStyle.Bold);
            btnNo.ForeColor = Color.FromArgb(11, 24, 40);
            btnNo.Location = new Point(448, 48);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(435, 397);
            btnNo.TabIndex = 10;
            btnNo.Text = "NO";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(97, 147, 209);
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Roboto", 21.75F, FontStyle.Bold);
            btnYes.ForeColor = Color.FromArgb(11, 24, 40);
            btnYes.Location = new Point(7, 48);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(435, 397);
            btnYes.TabIndex = 9;
            btnYes.Text = "YES";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 7);
            label1.Name = "label1";
            label1.Size = new Size(355, 38);
            label1.TabIndex = 8;
            label1.Text = "Receive Notifications?";
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(7, 460);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(60, 32);
            btnBack.SizeMode = PictureBoxSizeMode.CenterImage;
            btnBack.TabIndex = 0;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // pnlMail
            // 
            pnlMail.Controls.Add(btnEmail);
            pnlMail.Controls.Add(btnSMS);
            pnlMail.Controls.Add(label2);
            pnlMail.Controls.Add(btnBack2);
            pnlMail.Location = new Point(16, 82);
            pnlMail.Name = "pnlMail";
            pnlMail.Size = new Size(908, 492);
            pnlMail.TabIndex = 27;
            // 
            // btnEmail
            // 
            btnEmail.BackColor = Color.FromArgb(117, 161, 215);
            btnEmail.FlatStyle = FlatStyle.Flat;
            btnEmail.Font = new Font("Roboto", 21.75F, FontStyle.Bold);
            btnEmail.ForeColor = Color.FromArgb(11, 24, 40);
            btnEmail.Location = new Point(457, 41);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(435, 397);
            btnEmail.TabIndex = 14;
            btnEmail.Text = "EMAIL";
            btnEmail.UseVisualStyleBackColor = false;
            btnEmail.Click += btnEmail_Click;
            // 
            // btnSMS
            // 
            btnSMS.BackColor = Color.FromArgb(97, 147, 209);
            btnSMS.FlatStyle = FlatStyle.Flat;
            btnSMS.Font = new Font("Roboto", 21.75F, FontStyle.Bold);
            btnSMS.ForeColor = Color.FromArgb(11, 24, 40);
            btnSMS.Location = new Point(16, 41);
            btnSMS.Name = "btnSMS";
            btnSMS.Size = new Size(435, 397);
            btnSMS.TabIndex = 13;
            btnSMS.Text = "SMS";
            btnSMS.UseVisualStyleBackColor = false;
            btnSMS.Click += btnSMS_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(395, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 38);
            label2.TabIndex = 12;
            label2.Text = "Option";
            // 
            // btnBack2
            // 
            btnBack2.Cursor = Cursors.Hand;
            btnBack2.Image = (Image)resources.GetObject("btnBack2.Image");
            btnBack2.Location = new Point(16, 453);
            btnBack2.Name = "btnBack2";
            btnBack2.Size = new Size(60, 32);
            btnBack2.SizeMode = PictureBoxSizeMode.CenterImage;
            btnBack2.TabIndex = 11;
            btnBack2.TabStop = false;
            btnBack2.Click += btnBack2_Click;
            // 
            // pnlRFID
            // 
            pnlRFID.Controls.Add(btnBack3);
            pnlRFID.Controls.Add(tbScan);
            pnlRFID.Controls.Add(label3);
            pnlRFID.Location = new Point(12, 82);
            pnlRFID.Name = "pnlRFID";
            pnlRFID.Size = new Size(917, 492);
            pnlRFID.TabIndex = 28;
            // 
            // btnBack3
            // 
            btnBack3.Cursor = Cursors.Hand;
            btnBack3.Image = (Image)resources.GetObject("btnBack3.Image");
            btnBack3.Location = new Point(20, 453);
            btnBack3.Name = "btnBack3";
            btnBack3.Size = new Size(60, 32);
            btnBack3.SizeMode = PictureBoxSizeMode.CenterImage;
            btnBack3.TabIndex = 15;
            btnBack3.TabStop = false;
            btnBack3.Click += btnBack3_Click;
            // 
            // tbScan
            // 
            tbScan.Font = new Font("Roboto", 15.75F);
            tbScan.Location = new Point(268, 89);
            tbScan.Name = "tbScan";
            tbScan.Size = new Size(380, 33);
            tbScan.TabIndex = 14;
            tbScan.KeyDown += tbScan_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(353, 0);
            label3.Name = "label3";
            label3.Size = new Size(208, 38);
            label3.TabIndex = 13;
            label3.Text = "Scan your ID";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Queue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 228, 244);
            ClientSize = new Size(941, 589);
            Controls.Add(btnClose);
            Controls.Add(MainText);
            Controls.Add(pnlOption);
            Controls.Add(pnlRFID);
            Controls.Add(pnlMail);
            Controls.Add(pnlNotif);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Queue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Queue";
            Load += Queue_Load;
            pnlOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            pnlNotif.ResumeLayout(false);
            pnlNotif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            pnlMail.ResumeLayout(false);
            pnlMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack2).EndInit();
            pnlRFID.ResumeLayout(false);
            pnlRFID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainText;
        private FlowLayoutPanel pnlOption;
        private Button btnEnroll;
        private Button btnAdvise;
        private PictureBox btnClose;
        private Panel pnlNotif;
        private PictureBox btnBack;
        private Button btnYes;
        private Label label1;
        private Button btnNo;
        private Panel pnlMail;
        private Button btnEmail;
        private Button btnSMS;
        private Label label2;
        private PictureBox btnBack2;
        private Panel pnlRFID;
        private Label label3;
        private TextBox tbScan;
        private PictureBox btnBack3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}