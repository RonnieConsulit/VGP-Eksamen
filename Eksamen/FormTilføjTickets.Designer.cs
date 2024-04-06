namespace Eksamen
{
    partial class FormTilføjTickets
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTilføjTickets));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_Header = new Label();
            lblNavn = new Label();
            btnTilbageTilTickets = new Button();
            btnTilføjTickets = new Button();
            btnExit = new Button();
            lblAnsvarlig = new Label();
            lblKunde = new Label();
            txtBoxNavn = new TextBox();
            lblStatus = new Label();
            comboBoxKunde = new ComboBox();
            comboBoxAnsvarlig = new ComboBox();
            comboBoxStatus = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 500);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 100);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_Header
            // 
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Segoe UI", 50F);
            lbl_Header.Location = new Point(212, 45);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(400, 89);
            lbl_Header.TabIndex = 4;
            lbl_Header.Text = "Tilføj Tickets";
            // 
            // lblNavn
            // 
            lblNavn.AutoSize = true;
            lblNavn.Location = new Point(232, 140);
            lblNavn.Name = "lblNavn";
            lblNavn.Size = new Size(35, 15);
            lblNavn.TabIndex = 8;
            lblNavn.Text = "Navn";
            // 
            // btnTilbageTilTickets
            // 
            btnTilbageTilTickets.Location = new Point(420, 428);
            btnTilbageTilTickets.Name = "btnTilbageTilTickets";
            btnTilbageTilTickets.Size = new Size(95, 23);
            btnTilbageTilTickets.TabIndex = 7;
            btnTilbageTilTickets.Text = "Tilbage";
            btnTilbageTilTickets.UseVisualStyleBackColor = true;
            btnTilbageTilTickets.Click += btnTilbageTilTickets_Click;
            // 
            // btnTilføjTickets
            // 
            btnTilføjTickets.Location = new Point(317, 428);
            btnTilføjTickets.Name = "btnTilføjTickets";
            btnTilføjTickets.Size = new Size(97, 23);
            btnTilføjTickets.TabIndex = 6;
            btnTilføjTickets.Text = "Tilføj ticket";
            btnTilføjTickets.UseVisualStyleBackColor = true;
            btnTilføjTickets.Click += btnTilføjTicket_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Location = new Point(870, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(31, 33);
            btnExit.TabIndex = 18;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblAnsvarlig
            // 
            lblAnsvarlig.AutoSize = true;
            lblAnsvarlig.Location = new Point(232, 196);
            lblAnsvarlig.Name = "lblAnsvarlig";
            lblAnsvarlig.Size = new Size(56, 15);
            lblAnsvarlig.TabIndex = 10;
            lblAnsvarlig.Text = "Ansvarlig";
            // 
            // lblKunde
            // 
            lblKunde.AutoSize = true;
            lblKunde.Location = new Point(232, 166);
            lblKunde.Name = "lblKunde";
            lblKunde.Size = new Size(41, 15);
            lblKunde.TabIndex = 9;
            lblKunde.Text = "Kunde";
            // 
            // txtBoxNavn
            // 
            txtBoxNavn.Location = new Point(300, 140);
            txtBoxNavn.Name = "txtBoxNavn";
            txtBoxNavn.Size = new Size(227, 23);
            txtBoxNavn.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(232, 226);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status";
            // 
            // comboBoxKunde
            // 
            comboBoxKunde.FormattingEnabled = true;
            comboBoxKunde.Location = new Point(300, 166);
            comboBoxKunde.Name = "comboBoxKunde";
            comboBoxKunde.Size = new Size(227, 23);
            comboBoxKunde.TabIndex = 19;
            // 
            // comboBoxAnsvarlig
            // 
            comboBoxAnsvarlig.FormattingEnabled = true;
            comboBoxAnsvarlig.Location = new Point(300, 197);
            comboBoxAnsvarlig.Name = "comboBoxAnsvarlig";
            comboBoxAnsvarlig.Size = new Size(227, 23);
            comboBoxAnsvarlig.TabIndex = 20;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(300, 226);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(227, 23);
            comboBoxStatus.TabIndex = 21;
            // 
            // FormTilføjTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 500);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxAnsvarlig);
            Controls.Add(comboBoxKunde);
            Controls.Add(btnExit);
            Controls.Add(txtBoxNavn);
            Controls.Add(lblStatus);
            Controls.Add(lblAnsvarlig);
            Controls.Add(lblKunde);
            Controls.Add(lblNavn);
            Controls.Add(btnTilbageTilTickets);
            Controls.Add(btnTilføjTickets);
            Controls.Add(lbl_Header);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTilføjTickets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formTilføjTickets";
            Load += formTilføjTicket_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lbl_Header;
        private Label lblNavn;
        private Button btnTilbageTilTickets;
        private Button btnTilføjTickets;
        private Button btnExit;
        private Label lblAnsvarlig;
        private Label lblKunde;
        private TextBox txtBoxNavn;
        private Label lblStatus;
        private ComboBox comboBoxKunde;
        private ComboBox comboBoxAnsvarlig;
        private ComboBox comboBoxStatus;
    }
}
