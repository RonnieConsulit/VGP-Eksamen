﻿namespace Eksamen
{
    partial class FormTilføjAktivitet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTilføjAktivitet));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_Header = new Label();
            lblNavn = new Label();
            btnTilbageTilTickets = new Button();
            btnTilføjTAktivitet = new Button();
            btnExit = new Button();
            lblAnsvarlig = new Label();
            lblKunde = new Label();
            txtBoxNavn = new TextBox();
            lblBeskrivelse = new Label();
            textBoxKunde = new TextBox();
            comboBoxAnsvarlig = new ComboBox();
            txtBoxTicketId = new TextBox();
            lblTicketId = new Label();
            txtBoxBeskrivelse = new TextBox();
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
            lbl_Header.Size = new Size(443, 89);
            lbl_Header.TabIndex = 4;
            lbl_Header.Text = "Tilføj Aktivitet";
            // 
            // lblNavn
            // 
            lblNavn.AutoSize = true;
            lblNavn.Location = new Point(232, 143);
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
            // btnTilføjTAktivitet
            // 
            btnTilføjTAktivitet.Location = new Point(317, 428);
            btnTilføjTAktivitet.Name = "btnTilføjTAktivitet";
            btnTilføjTAktivitet.Size = new Size(97, 23);
            btnTilføjTAktivitet.TabIndex = 6;
            btnTilføjTAktivitet.Text = "Tilføj Aktivitet";
            btnTilføjTAktivitet.UseVisualStyleBackColor = true;
            btnTilføjTAktivitet.Click += btnTilføjTAktivitet_Click;
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
            lblAnsvarlig.Location = new Point(232, 230);
            lblAnsvarlig.Name = "lblAnsvarlig";
            lblAnsvarlig.Size = new Size(56, 15);
            lblAnsvarlig.TabIndex = 10;
            lblAnsvarlig.Text = "Ansvarlig";
            // 
            // lblKunde
            // 
            lblKunde.AutoSize = true;
            lblKunde.Location = new Point(232, 172);
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
            // lblBeskrivelse
            // 
            lblBeskrivelse.AutoSize = true;
            lblBeskrivelse.Location = new Point(232, 262);
            lblBeskrivelse.Name = "lblBeskrivelse";
            lblBeskrivelse.Size = new Size(64, 15);
            lblBeskrivelse.TabIndex = 11;
            lblBeskrivelse.Text = "Beskrivelse";
            // 
            // textBoxKunde
            // 
            textBoxKunde.Location = new Point(300, 169);
            textBoxKunde.Name = "textBoxKunde";
            textBoxKunde.Size = new Size(227, 23);
            textBoxKunde.TabIndex = 22;
            // 
            // comboBoxAnsvarlig
            // 
            comboBoxAnsvarlig.FormattingEnabled = true;
            comboBoxAnsvarlig.Location = new Point(300, 227);
            comboBoxAnsvarlig.Name = "comboBoxAnsvarlig";
            comboBoxAnsvarlig.Size = new Size(227, 23);
            comboBoxAnsvarlig.TabIndex = 21;
            // 
            // txtBoxTicketId
            // 
            txtBoxTicketId.Location = new Point(300, 198);
            txtBoxTicketId.Name = "txtBoxTicketId";
            txtBoxTicketId.Size = new Size(227, 23);
            txtBoxTicketId.TabIndex = 23;
            // 
            // lblTicketId
            // 
            lblTicketId.AutoSize = true;
            lblTicketId.Location = new Point(232, 201);
            lblTicketId.Name = "lblTicketId";
            lblTicketId.Size = new Size(55, 15);
            lblTicketId.TabIndex = 24;
            lblTicketId.Text = "Ticket ID:";
            // 
            // txtBoxBeskrivelse
            // 
            txtBoxBeskrivelse.Location = new Point(300, 281);
            txtBoxBeskrivelse.Multiline = true;
            txtBoxBeskrivelse.Name = "txtBoxBeskrivelse";
            txtBoxBeskrivelse.ShortcutsEnabled = false;
            txtBoxBeskrivelse.Size = new Size(227, 108);
            txtBoxBeskrivelse.TabIndex = 25;
            // 
            // FormTilføjAktivitet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 500);
            Controls.Add(txtBoxBeskrivelse);
            Controls.Add(lblTicketId);
            Controls.Add(txtBoxTicketId);
            Controls.Add(textBoxKunde);
            Controls.Add(comboBoxAnsvarlig);
            Controls.Add(btnExit);
            Controls.Add(txtBoxNavn);
            Controls.Add(lblBeskrivelse);
            Controls.Add(lblAnsvarlig);
            Controls.Add(lblKunde);
            Controls.Add(lblNavn);
            Controls.Add(btnTilbageTilTickets);
            Controls.Add(btnTilføjTAktivitet);
            Controls.Add(lbl_Header);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTilføjAktivitet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formTilføjTickets";
            Load += formTilføjAktivitet_Load;
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
        private Button btnTilføjTAktivitet;
        private Button btnExit;
        private Label lblAnsvarlig;
        private Label lblKunde;
        private TextBox txtBoxNavn;
        private Label lblBeskrivelse;
        private TextBox textBoxKunde;
        private ComboBox comboBoxAnsvarlig;
        private TextBox txtBoxTicketId;
        private Label lblTicketId;
        private TextBox txtBoxBeskrivelse;
    }
}
