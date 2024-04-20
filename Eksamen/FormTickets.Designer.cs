namespace Eksamen
{
    partial class FormTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTickets));
            panel1 = new Panel();
            btnBrugere = new Button();
            btnKunder = new Button();
            btnTickets = new Button();
            btnAktiviteter = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_Header = new Label();
            listBoxTickets = new ListBox();
            btnTilføjTickets = new Button();
            btnSletTickets = new Button();
            listBoxAktiviteter = new ListBox();
            btnExit = new Button();
            btnGem = new Button();
            lblAktiviteter = new Label();
            lblNavn = new Label();
            comboBoxStatus = new ComboBox();
            comboBoxAnsvarlig = new ComboBox();
            comboBoxKunde = new ComboBox();
            txtBoxNavn = new TextBox();
            lblStatus = new Label();
            lblAnsvarlig = new Label();
            lblKunde = new Label();
            btnTilføjAktivitet = new Button();
            btnSletAktivitet = new Button();
            btnFakturer = new Button();
            btnSortLukket = new Button();
            btnSortÅbne = new Button();
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
            lbl_Header.Location = new Point(216, 45);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(239, 89);
            lbl_Header.TabIndex = 4;
            lbl_Header.Text = "Tickets";
            // 
            // listBoxTickets
            // 
            listBoxTickets.FormattingEnabled = true;
            listBoxTickets.ItemHeight = 15;
            listBoxTickets.Location = new Point(232, 137);
            listBoxTickets.Name = "listBoxTickets";
            listBoxTickets.Size = new Size(272, 274);
            listBoxTickets.TabIndex = 5;
            // 
            // btnTilføjTickets
            // 
            btnTilføjTickets.Location = new Point(232, 428);
            btnTilføjTickets.Name = "btnTilføjTickets";
            btnTilføjTickets.Size = new Size(126, 23);
            btnTilføjTickets.TabIndex = 6;
            btnTilføjTickets.Text = "Tilføj ticket";
            btnTilføjTickets.UseVisualStyleBackColor = true;
            btnTilføjTickets.Click += btnTilføjTickets_Click;
            // 
            // btnSletTickets
            // 
            btnSletTickets.Location = new Point(378, 428);
            btnSletTickets.Name = "btnSletTickets";
            btnSletTickets.Size = new Size(126, 23);
            btnSletTickets.TabIndex = 7;
            btnSletTickets.Text = "Slet ticket";
            btnSletTickets.UseVisualStyleBackColor = true;
            btnSletTickets.Click += btnSletTickets_Click;
            // 
            // listBoxAktiviteter
            // 
            listBoxAktiviteter.FormattingEnabled = true;
            listBoxAktiviteter.ItemHeight = 15;
            listBoxAktiviteter.Location = new Point(619, 302);
            listBoxAktiviteter.Name = "listBoxAktiviteter";
            listBoxAktiviteter.Size = new Size(227, 109);
            listBoxAktiviteter.TabIndex = 8;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Location = new Point(870, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(31, 33);
            btnExit.TabIndex = 10;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnGem
            // 
            btnGem.Location = new Point(745, 457);
            btnGem.Name = "btnGem";
            btnGem.Size = new Size(101, 23);
            btnGem.TabIndex = 29;
            btnGem.Text = "Gem ændringer";
            btnGem.UseVisualStyleBackColor = true;
            btnGem.Click += btnGem_Click;
            // 
            // lblAktiviteter
            // 
            lblAktiviteter.AutoSize = true;
            lblAktiviteter.Location = new Point(532, 302);
            lblAktiviteter.Name = "lblAktiviteter";
            lblAktiviteter.Size = new Size(61, 15);
            lblAktiviteter.TabIndex = 28;
            lblAktiviteter.Text = "Aktiviteter";
            // 
            // lblNavn
            // 
            lblNavn.AutoSize = true;
            lblNavn.Location = new Point(532, 150);
            lblNavn.Name = "lblNavn";
            lblNavn.Size = new Size(35, 15);
            lblNavn.TabIndex = 19;
            lblNavn.Text = "Navn";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(619, 256);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(227, 23);
            comboBoxStatus.TabIndex = 37;
            // 
            // comboBoxAnsvarlig
            // 
            comboBoxAnsvarlig.FormattingEnabled = true;
            comboBoxAnsvarlig.Location = new Point(619, 218);
            comboBoxAnsvarlig.Name = "comboBoxAnsvarlig";
            comboBoxAnsvarlig.Size = new Size(227, 23);
            comboBoxAnsvarlig.TabIndex = 36;
            // 
            // comboBoxKunde
            // 
            comboBoxKunde.FormattingEnabled = true;
            comboBoxKunde.Location = new Point(619, 181);
            comboBoxKunde.Name = "comboBoxKunde";
            comboBoxKunde.Size = new Size(227, 23);
            comboBoxKunde.TabIndex = 35;
            // 
            // txtBoxNavn
            // 
            txtBoxNavn.Location = new Point(619, 147);
            txtBoxNavn.Name = "txtBoxNavn";
            txtBoxNavn.Size = new Size(227, 23);
            txtBoxNavn.TabIndex = 34;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(534, 259);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 33;
            lblStatus.Text = "Status";
            // 
            // lblAnsvarlig
            // 
            lblAnsvarlig.AutoSize = true;
            lblAnsvarlig.Location = new Point(532, 221);
            lblAnsvarlig.Name = "lblAnsvarlig";
            lblAnsvarlig.Size = new Size(56, 15);
            lblAnsvarlig.TabIndex = 32;
            lblAnsvarlig.Text = "Ansvarlig";
            // 
            // lblKunde
            // 
            lblKunde.AutoSize = true;
            lblKunde.Location = new Point(532, 184);
            lblKunde.Name = "lblKunde";
            lblKunde.Size = new Size(41, 15);
            lblKunde.TabIndex = 31;
            lblKunde.Text = "Kunde";
            // 
            // btnTilføjAktivitet
            // 
            btnTilføjAktivitet.Location = new Point(619, 428);
            btnTilføjAktivitet.Name = "btnTilføjAktivitet";
            btnTilføjAktivitet.Size = new Size(101, 23);
            btnTilføjAktivitet.TabIndex = 38;
            btnTilføjAktivitet.Text = "Tilføj aktivitet";
            btnTilføjAktivitet.UseVisualStyleBackColor = true;
            btnTilføjAktivitet.Click += btnTilføjAktivitet_Click;
            // 
            // btnSletAktivitet
            // 
            btnSletAktivitet.Location = new Point(745, 428);
            btnSletAktivitet.Name = "btnSletAktivitet";
            btnSletAktivitet.Size = new Size(101, 23);
            btnSletAktivitet.TabIndex = 39;
            btnSletAktivitet.Text = "Slet aktivitet";
            btnSletAktivitet.UseVisualStyleBackColor = true;
            btnSletAktivitet.Click += btnSletAktivitet_Click;
            // 
            // btnFakturer
            // 
            btnFakturer.Location = new Point(619, 457);
            btnFakturer.Name = "btnFakturer";
            btnFakturer.Size = new Size(101, 23);
            btnFakturer.TabIndex = 40;
            btnFakturer.Text = "Luk og fakturer";
            btnFakturer.UseVisualStyleBackColor = true;
            btnFakturer.Click += btnFakturer_Click;
            // 
            // btnSortLukket
            // 
            btnSortLukket.Location = new Point(378, 457);
            btnSortLukket.Name = "btnSortLukket";
            btnSortLukket.Size = new Size(126, 23);
            btnSortLukket.TabIndex = 48;
            btnSortLukket.Text = "Sorter på lukket";
            btnSortLukket.UseVisualStyleBackColor = true;
            btnSortLukket.Click += btnSortLukket_Click;
            // 
            // btnSortÅbne
            // 
            btnSortÅbne.Location = new Point(232, 457);
            btnSortÅbne.Name = "btnSortÅbne";
            btnSortÅbne.Size = new Size(126, 23);
            btnSortÅbne.TabIndex = 47;
            btnSortÅbne.Text = "Sorter på åben";
            btnSortÅbne.UseVisualStyleBackColor = true;
            btnSortÅbne.Click += btnSortÅbne_Click;
            // 
            // FormTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 500);
            Controls.Add(btnSortLukket);
            Controls.Add(btnSortÅbne);
            Controls.Add(btnFakturer);
            Controls.Add(btnSletAktivitet);
            Controls.Add(btnTilføjAktivitet);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxAnsvarlig);
            Controls.Add(comboBoxKunde);
            Controls.Add(txtBoxNavn);
            Controls.Add(lblStatus);
            Controls.Add(lblAnsvarlig);
            Controls.Add(lblKunde);
            Controls.Add(btnGem);
            Controls.Add(lblAktiviteter);
            Controls.Add(lblNavn);
            Controls.Add(btnExit);
            Controls.Add(listBoxAktiviteter);
            Controls.Add(btnSletTickets);
            Controls.Add(btnTilføjTickets);
            Controls.Add(listBoxTickets);
            Controls.Add(lbl_Header);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTickets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formTickets";
            Load += formTickets_Load;
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
        private ListBox listBoxTickets;
        private Button btnTilføjTickets;
        private Button btnSletTickets;
        private ListBox listBoxAktiviteter;
        private Button btnExit;
        private Button btnGem;
        private Label lblAktiviteter;
        private Label lblNavn;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxAnsvarlig;
        private ComboBox comboBoxKunde;
        private TextBox txtBoxNavn;
        private Label lblStatus;
        private Label lblAnsvarlig;
        private Label lblKunde;
        private Button btnTilføjAktivitet;
        private Button btnSletAktivitet;
        private Button btnFakturer;
        private Button btnSortLukket;
        private Button btnSortÅbne;
    }
}
