namespace Eksamen
{
    partial class FormTilføjBrugere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTilføjBrugere));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_Header = new Label();
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
            btnTilbageTilBrugere = new Button();
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
            lbl_Header.Size = new Size(395, 89);
            lbl_Header.TabIndex = 4;
            lbl_Header.Text = "Tilføj Bruger";
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
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Location = new Point(232, 166);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(48, 15);
            lblAdresse.TabIndex = 9;
            lblAdresse.Text = "Adresse";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(232, 196);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(232, 226);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(45, 15);
            lblTelefon.TabIndex = 11;
            lblTelefon.Text = "Telefon";
            // 
            // txtBoxNavn
            // 
            txtBoxNavn.Location = new Point(300, 137);
            txtBoxNavn.Name = "txtBoxNavn";
            txtBoxNavn.Size = new Size(227, 23);
            txtBoxNavn.TabIndex = 12;
            // 
            // txtBoxAdresse
            // 
            txtBoxAdresse.Location = new Point(300, 166);
            txtBoxAdresse.Name = "txtBoxAdresse";
            txtBoxAdresse.Size = new Size(227, 23);
            txtBoxAdresse.TabIndex = 13;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(300, 196);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(227, 23);
            txtBoxEmail.TabIndex = 14;
            // 
            // txtBoxTelefon
            // 
            txtBoxTelefon.Location = new Point(300, 226);
            txtBoxTelefon.Name = "txtBoxTelefon";
            txtBoxTelefon.Size = new Size(227, 23);
            txtBoxTelefon.TabIndex = 15;
            // 
            // txtBoxBeskrivelse
            // 
            txtBoxBeskrivelse.Location = new Point(300, 297);
            txtBoxBeskrivelse.Multiline = true;
            txtBoxBeskrivelse.Name = "txtBoxBeskrivelse";
            txtBoxBeskrivelse.ShortcutsEnabled = false;
            txtBoxBeskrivelse.Size = new Size(227, 108);
            txtBoxBeskrivelse.TabIndex = 16;
            // 
            // lblBeskrivelse
            // 
            lblBeskrivelse.AutoSize = true;
            lblBeskrivelse.Location = new Point(232, 274);
            lblBeskrivelse.Name = "lblBeskrivelse";
            lblBeskrivelse.Size = new Size(64, 15);
            lblBeskrivelse.TabIndex = 17;
            lblBeskrivelse.Text = "Beskrivelse";
            // 
            // btnTilbageTilBrugere
            // 
            btnTilbageTilBrugere.Location = new Point(420, 428);
            btnTilbageTilBrugere.Name = "btnTilbageTilBrugere";
            btnTilbageTilBrugere.Size = new Size(95, 23);
            btnTilbageTilBrugere.TabIndex = 7;
            btnTilbageTilBrugere.Text = "Tilbage";
            btnTilbageTilBrugere.UseVisualStyleBackColor = true;
            btnTilbageTilBrugere.Click += btnTilbageTilBrugere_Click;
            // 
            // btnTilføjBrugere
            // 
            btnTilføjBrugere.Location = new Point(317, 428);
            btnTilføjBrugere.Name = "btnTilføjBrugere";
            btnTilføjBrugere.Size = new Size(97, 23);
            btnTilføjBrugere.TabIndex = 6;
            btnTilføjBrugere.Text = "Tilføj bruger";
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
            btnExit.TabIndex = 18;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormTilføjBrugere
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 500);
            Controls.Add(btnExit);
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
            Controls.Add(btnTilbageTilBrugere);
            Controls.Add(btnTilføjBrugere);
            Controls.Add(lbl_Header);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTilføjBrugere";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formTilføjBrugere";
            Load += formTilføjBrugere_Load;
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
        private Label lblAdresse;
        private Label lblEmail;
        private Label lblTelefon;
        private TextBox txtBoxNavn;
        private TextBox txtBoxAdresse;
        private TextBox txtBoxEmail;
        private TextBox txtBoxTelefon;
        private TextBox txtBoxBeskrivelse;
        private Label lblBeskrivelse;
        private Button btnTilbageTilBrugere;
        private Button btnTilføjBrugere;
        private Button btnExit;
    }
}
