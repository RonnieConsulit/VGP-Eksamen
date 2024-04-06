namespace Eksamen
{
    partial class FormAktiviteter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAktiviteter));
            panel1 = new Panel();
            btnBrugere = new Button();
            btnKunder = new Button();
            btnTickets = new Button();
            btnAktiviteter = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_Header = new Label();
            listBoxAktiviteter = new ListBox();
            lblNavn = new Label();
            lblAnsvarlig = new Label();
            lblTicketId = new Label();
            lblStatus = new Label();
            txtBoxNavn = new TextBox();
            txtBoxBeskrivelse = new TextBox();
            lblBeskrivelse = new Label();
            btnExit = new Button();
            lblKunde = new Label();
            comboBoxAnsvarlig = new ComboBox();
            comboBoxTickets = new ComboBox();
            comboBoxStatus = new ComboBox();
            comboBoxKunder = new ComboBox();
            btnSortÅbne = new Button();
            btnSortLukket = new Button();
            btnGem = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnBrugere);
            panel1.Controls.Add(btnKunder);
            panel1.Controls.Add(btnTickets);
            panel1.Controls.Add(btnAktiviteter);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 500);
            panel1.TabIndex = 0;
            // 
            // btnBrugere
            // 
            btnBrugere.BackColor = SystemColors.GradientActiveCaption;
            btnBrugere.FlatAppearance.BorderSize = 0;
            btnBrugere.Location = new Point(27, 383);
            btnBrugere.Name = "btnBrugere";
            btnBrugere.Size = new Size(123, 33);
            btnBrugere.TabIndex = 5;
            btnBrugere.Text = "Brugere";
            btnBrugere.UseVisualStyleBackColor = false;
            btnBrugere.Click += btnBrugere_Click;
            // 
            // btnKunder
            // 
            btnKunder.BackColor = SystemColors.GradientActiveCaption;
            btnKunder.FlatAppearance.BorderSize = 0;
            btnKunder.Location = new Point(27, 318);
            btnKunder.Name = "btnKunder";
            btnKunder.Size = new Size(123, 33);
            btnKunder.TabIndex = 4;
            btnKunder.Text = "Kunder";
            btnKunder.UseVisualStyleBackColor = false;
            btnKunder.Click += btnKunder_Click;
            // 
            // btnTickets
            // 
            btnTickets.BackColor = SystemColors.GradientActiveCaption;
            btnTickets.FlatAppearance.BorderSize = 0;
            btnTickets.Location = new Point(27, 256);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(123, 33);
            btnTickets.TabIndex = 3;
            btnTickets.Text = "Tickets";
            btnTickets.UseVisualStyleBackColor = false;
            btnTickets.Click += btnTickets_Click;
            // 
            // btnAktiviteter
            // 
            btnAktiviteter.BackColor = SystemColors.GradientActiveCaption;
            btnAktiviteter.FlatAppearance.BorderSize = 0;
            btnAktiviteter.Location = new Point(27, 196);
            btnAktiviteter.Name = "btnAktiviteter";
            btnAktiviteter.Size = new Size(123, 33);
            btnAktiviteter.TabIndex = 2;
            btnAktiviteter.Text = "Aktiviteter";
            btnAktiviteter.UseVisualStyleBackColor = false;
            btnAktiviteter.Click += btnAktiviteter_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.GradientActiveCaption;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.Location = new Point(27, 137);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(123, 33);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
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
            lbl_Header.Size = new Size(340, 89);
            lbl_Header.TabIndex = 4;
            lbl_Header.Text = "Aktiviteter";
            // 
            // listBoxAktiviteter
            // 
            listBoxAktiviteter.FormattingEnabled = true;
            listBoxAktiviteter.ItemHeight = 15;
            listBoxAktiviteter.Location = new Point(232, 137);
            listBoxAktiviteter.Name = "listBoxAktiviteter";
            listBoxAktiviteter.Size = new Size(272, 274);
            listBoxAktiviteter.TabIndex = 5;
            // 
            // lblNavn
            // 
            lblNavn.AutoSize = true;
            lblNavn.Location = new Point(527, 140);
            lblNavn.Name = "lblNavn";
            lblNavn.Size = new Size(35, 15);
            lblNavn.TabIndex = 8;
            lblNavn.Text = "Navn";
            // 
            // lblAnsvarlig
            // 
            lblAnsvarlig.AutoSize = true;
            lblAnsvarlig.Location = new Point(527, 181);
            lblAnsvarlig.Name = "lblAnsvarlig";
            lblAnsvarlig.Size = new Size(56, 15);
            lblAnsvarlig.TabIndex = 9;
            lblAnsvarlig.Text = "Ansvarlig";
            // 
            // lblTicketId
            // 
            lblTicketId.AutoSize = true;
            lblTicketId.Location = new Point(526, 221);
            lblTicketId.Name = "lblTicketId";
            lblTicketId.Size = new Size(38, 15);
            lblTicketId.TabIndex = 10;
            lblTicketId.Text = "Ticket";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(527, 259);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status";
            // 
            // txtBoxNavn
            // 
            txtBoxNavn.Location = new Point(635, 137);
            txtBoxNavn.Name = "txtBoxNavn";
            txtBoxNavn.Size = new Size(227, 23);
            txtBoxNavn.TabIndex = 12;
            // 
            // txtBoxBeskrivelse
            // 
            txtBoxBeskrivelse.Location = new Point(635, 336);
            txtBoxBeskrivelse.Multiline = true;
            txtBoxBeskrivelse.Name = "txtBoxBeskrivelse";
            txtBoxBeskrivelse.ShortcutsEnabled = false;
            txtBoxBeskrivelse.Size = new Size(227, 75);
            txtBoxBeskrivelse.TabIndex = 16;
            // 
            // lblBeskrivelse
            // 
            lblBeskrivelse.AutoSize = true;
            lblBeskrivelse.Location = new Point(526, 339);
            lblBeskrivelse.Name = "lblBeskrivelse";
            lblBeskrivelse.Size = new Size(64, 15);
            lblBeskrivelse.TabIndex = 17;
            lblBeskrivelse.Text = "Beskrivelse";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Location = new Point(870, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(31, 33);
            btnExit.TabIndex = 20;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblKunde
            // 
            lblKunde.AutoSize = true;
            lblKunde.Location = new Point(527, 297);
            lblKunde.Name = "lblKunde";
            lblKunde.Size = new Size(41, 15);
            lblKunde.TabIndex = 23;
            lblKunde.Text = "Kunde";
            // 
            // comboBoxAnsvarlig
            // 
            comboBoxAnsvarlig.FormattingEnabled = true;
            comboBoxAnsvarlig.Location = new Point(635, 178);
            comboBoxAnsvarlig.Name = "comboBoxAnsvarlig";
            comboBoxAnsvarlig.Size = new Size(227, 23);
            comboBoxAnsvarlig.TabIndex = 41;
            // 
            // comboBoxTickets
            // 
            comboBoxTickets.FormattingEnabled = true;
            comboBoxTickets.Location = new Point(635, 218);
            comboBoxTickets.Name = "comboBoxTickets";
            comboBoxTickets.Size = new Size(227, 23);
            comboBoxTickets.TabIndex = 42;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(635, 256);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(227, 23);
            comboBoxStatus.TabIndex = 43;
            // 
            // comboBoxKunder
            // 
            comboBoxKunder.FormattingEnabled = true;
            comboBoxKunder.Location = new Point(635, 294);
            comboBoxKunder.Name = "comboBoxKunder";
            comboBoxKunder.Size = new Size(227, 23);
            comboBoxKunder.TabIndex = 44;
            // 
            // btnSortÅbne
            // 
            btnSortÅbne.Location = new Point(232, 417);
            btnSortÅbne.Name = "btnSortÅbne";
            btnSortÅbne.Size = new Size(126, 23);
            btnSortÅbne.TabIndex = 45;
            btnSortÅbne.Text = "Sorter på åben";
            btnSortÅbne.UseVisualStyleBackColor = true;
            btnSortÅbne.Click += btnSortÅbne_Click;
            // 
            // btnSortLukket
            // 
            btnSortLukket.Location = new Point(378, 417);
            btnSortLukket.Name = "btnSortLukket";
            btnSortLukket.Size = new Size(126, 23);
            btnSortLukket.TabIndex = 46;
            btnSortLukket.Text = "Sorter på lukket";
            btnSortLukket.UseVisualStyleBackColor = true;
            btnSortLukket.Click += btnSortLukket_Click;
            // 
            // btnGem
            // 
            btnGem.Location = new Point(635, 417);
            btnGem.Name = "btnGem";
            btnGem.Size = new Size(126, 23);
            btnGem.TabIndex = 47;
            btnGem.Text = "Gem ændringer";
            btnGem.UseVisualStyleBackColor = true;
            btnGem.Click += btnGem_Click;
            // 
            // FormAktiviteter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 500);
            Controls.Add(btnGem);
            Controls.Add(btnSortLukket);
            Controls.Add(btnSortÅbne);
            Controls.Add(comboBoxKunder);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxTickets);
            Controls.Add(comboBoxAnsvarlig);
            Controls.Add(lblKunde);
            Controls.Add(btnExit);
            Controls.Add(lblBeskrivelse);
            Controls.Add(txtBoxBeskrivelse);
            Controls.Add(txtBoxNavn);
            Controls.Add(lblStatus);
            Controls.Add(lblTicketId);
            Controls.Add(lblAnsvarlig);
            Controls.Add(lblNavn);
            Controls.Add(listBoxAktiviteter);
            Controls.Add(lbl_Header);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAktiviteter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formAktiviteter";
            Load += formAktiviteter_Load;
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
        private Button btnBrugere;
        private Button btnKunder;
        private Button btnTickets;
        private Button btnAktiviteter;
        private Button btnDashboard;
        private Label lbl_Header;
        private ListBox listBoxAktiviteter;
        private Label lblNavn;
        private Label lblAnsvarlig;
        private Label lblTicketId;
        private Label lblStatus;
        private TextBox txtBoxNavn;
        private TextBox txtBoxBeskrivelse;
        private Label lblBeskrivelse;
        private Button btnExit;
        private Label lblKunde;
        private ComboBox comboBoxAnsvarlig;
        private ComboBox comboBoxKunde;
        private ComboBox comboBoxStatus;
        private ComboBox comboBox3;
        private ComboBox comboBoxTickets;
        private ComboBox comboBoxKunder;
        private Button btnSortÅbne;
        private Button btnSortLukket;
        private Button btnGem;
    }
}
