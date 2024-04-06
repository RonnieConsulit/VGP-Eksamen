namespace Eksamen
{
    partial class FormBrugere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrugere));
            panel1 = new Panel();
            btnBrugere = new Button();
            btnKunder = new Button();
            btnTickets = new Button();
            btnAktiviteter = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_Header = new Label();
            listBoxBrugere = new ListBox();
            btnSletBrugere = new Button();
            lblNavn = new Label();
            lblAdresse = new Label();
            lblEmail = new Label();
            lblTelefon = new Label();
            txtBoxNavn = new TextBox();
            txtBoxAdresse = new TextBox();
            txtBoxEmail = new TextBox();
            txtBoxTelefon = new TextBox();
            txtBoxBeskrivelse = new TextBox();
            lblBeskrivelse = new Label();
            btnGem = new Button();
            btnTilføjBrugere = new Button();
            btnExit = new Button();
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
            lbl_Header.Size = new Size(269, 89);
            lbl_Header.TabIndex = 4;
            lbl_Header.Text = "Brugere";
            // 
            // listBoxBrugere
            // 
            listBoxBrugere.FormattingEnabled = true;
            listBoxBrugere.ItemHeight = 15;
            listBoxBrugere.Location = new Point(232, 137);
            listBoxBrugere.Name = "listBoxBrugere";
            listBoxBrugere.Size = new Size(272, 274);
            listBoxBrugere.TabIndex = 5;
            // 
            // btnSletBrugere
            // 
            btnSletBrugere.Location = new Point(378, 428);
            btnSletBrugere.Name = "btnSletBrugere";
            btnSletBrugere.Size = new Size(126, 23);
            btnSletBrugere.TabIndex = 7;
            btnSletBrugere.Text = "Slet kunde";
            btnSletBrugere.UseVisualStyleBackColor = true;
            btnSletBrugere.Click += btnSletKunde_Click;
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
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Location = new Point(527, 181);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(48, 15);
            lblAdresse.TabIndex = 9;
            lblAdresse.Text = "Adresse";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(526, 221);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(527, 259);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(45, 15);
            lblTelefon.TabIndex = 11;
            lblTelefon.Text = "Telefon";
            // 
            // txtBoxNavn
            // 
            txtBoxNavn.Location = new Point(635, 137);
            txtBoxNavn.Name = "txtBoxNavn";
            txtBoxNavn.Size = new Size(227, 23);
            txtBoxNavn.TabIndex = 12;
            // 
            // txtBoxAdresse
            // 
            txtBoxAdresse.Location = new Point(635, 178);
            txtBoxAdresse.Name = "txtBoxAdresse";
            txtBoxAdresse.Size = new Size(227, 23);
            txtBoxAdresse.TabIndex = 13;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(635, 218);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(227, 23);
            txtBoxEmail.TabIndex = 14;
            // 
            // txtBoxTelefon
            // 
            txtBoxTelefon.Location = new Point(635, 256);
            txtBoxTelefon.Name = "txtBoxTelefon";
            txtBoxTelefon.Size = new Size(227, 23);
            txtBoxTelefon.TabIndex = 15;
            // 
            // txtBoxBeskrivelse
            // 
            txtBoxBeskrivelse.Location = new Point(635, 303);
            txtBoxBeskrivelse.Multiline = true;
            txtBoxBeskrivelse.Name = "txtBoxBeskrivelse";
            txtBoxBeskrivelse.ShortcutsEnabled = false;
            txtBoxBeskrivelse.Size = new Size(227, 108);
            txtBoxBeskrivelse.TabIndex = 16;
            // 
            // lblBeskrivelse
            // 
            lblBeskrivelse.AutoSize = true;
            lblBeskrivelse.Location = new Point(527, 303);
            lblBeskrivelse.Name = "lblBeskrivelse";
            lblBeskrivelse.Size = new Size(64, 15);
            lblBeskrivelse.TabIndex = 17;
            lblBeskrivelse.Text = "Beskrivelse";
            // 
            // btnGem
            // 
            btnGem.Location = new Point(635, 428);
            btnGem.Name = "btnGem";
            btnGem.Size = new Size(126, 23);
            btnGem.TabIndex = 18;
            btnGem.Text = "Gem ændringer";
            btnGem.UseVisualStyleBackColor = true;
            btnGem.Click += btnGem_Click;
            // 
            // btnTilføjBrugere
            // 
            btnTilføjBrugere.Location = new Point(232, 428);
            btnTilføjBrugere.Name = "btnTilføjBrugere";
            btnTilføjBrugere.Size = new Size(126, 23);
            btnTilføjBrugere.TabIndex = 19;
            btnTilføjBrugere.Text = "Tilføj Bruger";
            btnTilføjBrugere.UseVisualStyleBackColor = true;
            btnTilføjBrugere.Click += btnTilføjBrugere_Click;
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
            // FormBrugere
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 500);
            Controls.Add(btnExit);
            Controls.Add(btnTilføjBrugere);
            Controls.Add(btnGem);
            Controls.Add(lblBeskrivelse);
            Controls.Add(txtBoxBeskrivelse);
            Controls.Add(txtBoxTelefon);
            Controls.Add(txtBoxEmail);
            Controls.Add(txtBoxAdresse);
            Controls.Add(txtBoxNavn);
            Controls.Add(lblTelefon);
            Controls.Add(lblEmail);
            Controls.Add(lblAdresse);
            Controls.Add(lblNavn);
            Controls.Add(btnSletBrugere);
            Controls.Add(listBoxBrugere);
            Controls.Add(lbl_Header);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBrugere";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formBrugere";
            Load += formBrugere_Load;
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
        private ListBox listBoxBrugere;
        private Button btnSletBrugere;
        private Label lblNavn;
        private Label lblAdresse;
        private Label lblEmail;
        private Label lblTelefon;
        private TextBox txtBoxNavn;
        private TextBox txtBoxAdresse;
        private TextBox txtBoxEmail;
        private TextBox txtBoxTelefon;
        private TextBox txtBoxBeskrivelse;
        private Label lblBeskrivelse;
        private Button btnGem;
        private Button btnTilføjBrugere;
        private Button btnExit;
    }
}
