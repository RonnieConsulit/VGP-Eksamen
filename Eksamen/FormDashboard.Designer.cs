namespace Eksamen
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            panel1 = new Panel();
            btnBrugere = new Button();
            btnKunder = new Button();
            btnTickets = new Button();
            btnAktiviteter = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            label1 = new Label();
            lblHeader = new Label();
            lblLukkedeTickets = new Label();
            lblÅbneTickets = new Label();
            lblLukkedeAkt = new Label();
            textBoxÅbneTickets = new TextBox();
            textBoxLukkedeTickets = new TextBox();
            lblÅbneAkt = new Label();
            textBoxÅbneAkt = new TextBox();
            textBoxLukkedeAkt = new TextBox();
            lblAntalBrugere = new Label();
            textBoxAntalBrugere = new TextBox();
            textBoxAntalKunder = new TextBox();
            lblAntalKunder = new Label();
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
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Location = new Point(870, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(31, 33);
            btnExit.TabIndex = 7;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 146);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 8;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 50F);
            lblHeader.Location = new Point(207, 110);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(668, 89);
            lblHeader.TabIndex = 9;
            lblHeader.Text = "Ronnie's ticketsystem";
            // 
            // lblLukkedeTickets
            // 
            lblLukkedeTickets.AutoSize = true;
            lblLukkedeTickets.Location = new Point(295, 309);
            lblLukkedeTickets.Name = "lblLukkedeTickets";
            lblLukkedeTickets.Size = new Size(88, 15);
            lblLukkedeTickets.TabIndex = 36;
            lblLukkedeTickets.Text = "Lukkede tickets";
            // 
            // lblÅbneTickets
            // 
            lblÅbneTickets.AutoSize = true;
            lblÅbneTickets.Location = new Point(295, 243);
            lblÅbneTickets.Name = "lblÅbneTickets";
            lblÅbneTickets.Size = new Size(72, 15);
            lblÅbneTickets.TabIndex = 38;
            lblÅbneTickets.Text = "Åbne tickets";
            // 
            // lblLukkedeAkt
            // 
            lblLukkedeAkt.AutoSize = true;
            lblLukkedeAkt.Location = new Point(477, 309);
            lblLukkedeAkt.Name = "lblLukkedeAkt";
            lblLukkedeAkt.Size = new Size(106, 15);
            lblLukkedeAkt.TabIndex = 39;
            lblLukkedeAkt.Text = "Lukkede aktiviteter";
            // 
            // textBoxÅbneTickets
            // 
            textBoxÅbneTickets.Location = new Point(295, 262);
            textBoxÅbneTickets.Name = "textBoxÅbneTickets";
            textBoxÅbneTickets.Size = new Size(97, 23);
            textBoxÅbneTickets.TabIndex = 37;
            // 
            // textBoxLukkedeTickets
            // 
            textBoxLukkedeTickets.Location = new Point(295, 327);
            textBoxLukkedeTickets.Name = "textBoxLukkedeTickets";
            textBoxLukkedeTickets.Size = new Size(97, 23);
            textBoxLukkedeTickets.TabIndex = 40;
            // 
            // lblÅbneAkt
            // 
            lblÅbneAkt.AutoSize = true;
            lblÅbneAkt.Location = new Point(477, 244);
            lblÅbneAkt.Name = "lblÅbneAkt";
            lblÅbneAkt.Size = new Size(90, 15);
            lblÅbneAkt.TabIndex = 41;
            lblÅbneAkt.Text = "Åbne aktiviteter";
            // 
            // textBoxÅbneAkt
            // 
            textBoxÅbneAkt.Location = new Point(477, 262);
            textBoxÅbneAkt.Name = "textBoxÅbneAkt";
            textBoxÅbneAkt.Size = new Size(97, 23);
            textBoxÅbneAkt.TabIndex = 42;
            // 
            // textBoxLukkedeAkt
            // 
            textBoxLukkedeAkt.Location = new Point(477, 328);
            textBoxLukkedeAkt.Name = "textBoxLukkedeAkt";
            textBoxLukkedeAkt.Size = new Size(97, 23);
            textBoxLukkedeAkt.TabIndex = 43;
            // 
            // lblAntalBrugere
            // 
            lblAntalBrugere.AutoSize = true;
            lblAntalBrugere.Location = new Point(653, 244);
            lblAntalBrugere.Name = "lblAntalBrugere";
            lblAntalBrugere.Size = new Size(79, 15);
            lblAntalBrugere.TabIndex = 44;
            lblAntalBrugere.Text = "Antal brugere";
            // 
            // textBoxAntalBrugere
            // 
            textBoxAntalBrugere.Location = new Point(657, 266);
            textBoxAntalBrugere.Name = "textBoxAntalBrugere";
            textBoxAntalBrugere.Size = new Size(97, 23);
            textBoxAntalBrugere.TabIndex = 45;
            // 
            // textBoxAntalKunder
            // 
            textBoxAntalKunder.Location = new Point(657, 328);
            textBoxAntalKunder.Name = "textBoxAntalKunder";
            textBoxAntalKunder.Size = new Size(97, 23);
            textBoxAntalKunder.TabIndex = 46;
            // 
            // lblAntalKunder
            // 
            lblAntalKunder.AutoSize = true;
            lblAntalKunder.Location = new Point(657, 309);
            lblAntalKunder.Name = "lblAntalKunder";
            lblAntalKunder.Size = new Size(75, 15);
            lblAntalKunder.TabIndex = 47;
            lblAntalKunder.Text = "Antal kunder";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 500);
            Controls.Add(lblAntalKunder);
            Controls.Add(textBoxAntalKunder);
            Controls.Add(textBoxAntalBrugere);
            Controls.Add(lblAntalBrugere);
            Controls.Add(textBoxLukkedeAkt);
            Controls.Add(textBoxÅbneAkt);
            Controls.Add(lblÅbneAkt);
            Controls.Add(textBoxLukkedeTickets);
            Controls.Add(lblLukkedeAkt);
            Controls.Add(lblÅbneTickets);
            Controls.Add(textBoxÅbneTickets);
            Controls.Add(lblLukkedeTickets);
            Controls.Add(lblHeader);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formDashboard";
            Load += formDashboard_Load;
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
        private Button btnExit;
        private Label label1;
        private Label lblHeader;
        private TextBox txtBoxNavn;
        private Label lblLukkedeTickets;
        private Label lblÅbneTickets;
        private Label lblLukkedeAkt;
        private TextBox textBoxÅbneTickets;
        private TextBox textBoxLukkedeTickets;
        private Label lblÅbneAkt;
        private TextBox textBoxÅbneAkt;
        private TextBox textBoxLukkedeAkt;
        private Label lblAntalBrugere;
        private TextBox textBoxAntalBrugere;
        private TextBox textBoxAntalKunder;
        private Label lblAntalKunder;
    }
}
