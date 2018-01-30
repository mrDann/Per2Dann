namespace ProjectPeriode2
{
    partial class addKlantPage
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
            this.labelVoornaam = new System.Windows.Forms.Label();
            this.inputVoornaam = new System.Windows.Forms.TextBox();
            this.labelAchternaam = new System.Windows.Forms.Label();
            this.inputAchternaam = new System.Windows.Forms.TextBox();
            this.inputAdres = new System.Windows.Forms.TextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.inputPlaats = new System.Windows.Forms.TextBox();
            this.labelPlaats = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.inputTel = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.addKlantButton = new System.Windows.Forms.Button();
            this.cancelAddKlantButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVoornaam
            // 
            this.labelVoornaam.AutoSize = true;
            this.labelVoornaam.Location = new System.Drawing.Point(12, 13);
            this.labelVoornaam.Name = "labelVoornaam";
            this.labelVoornaam.Size = new System.Drawing.Size(58, 13);
            this.labelVoornaam.TabIndex = 0;
            this.labelVoornaam.Text = "Voornaam:";
            // 
            // inputVoornaam
            // 
            this.inputVoornaam.Location = new System.Drawing.Point(77, 10);
            this.inputVoornaam.Name = "inputVoornaam";
            this.inputVoornaam.Size = new System.Drawing.Size(160, 20);
            this.inputVoornaam.TabIndex = 1;
            this.inputVoornaam.TextChanged += new System.EventHandler(this.inputVoornaam_TextChanged);
            // 
            // labelAchternaam
            // 
            this.labelAchternaam.AutoSize = true;
            this.labelAchternaam.Location = new System.Drawing.Point(4, 39);
            this.labelAchternaam.Name = "labelAchternaam";
            this.labelAchternaam.Size = new System.Drawing.Size(67, 13);
            this.labelAchternaam.TabIndex = 2;
            this.labelAchternaam.Text = "Achternaam:";
            // 
            // inputAchternaam
            // 
            this.inputAchternaam.Location = new System.Drawing.Point(77, 36);
            this.inputAchternaam.Name = "inputAchternaam";
            this.inputAchternaam.Size = new System.Drawing.Size(160, 20);
            this.inputAchternaam.TabIndex = 3;
            this.inputAchternaam.TextChanged += new System.EventHandler(this.inputAchternaam_TextChanged);
            // 
            // inputAdres
            // 
            this.inputAdres.Location = new System.Drawing.Point(77, 71);
            this.inputAdres.Name = "inputAdres";
            this.inputAdres.Size = new System.Drawing.Size(160, 20);
            this.inputAdres.TabIndex = 5;
            this.inputAdres.TextChanged += new System.EventHandler(this.inputAdres_TextChanged);
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(33, 74);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(37, 13);
            this.labelAdres.TabIndex = 4;
            this.labelAdres.Text = "Adres:";
            // 
            // inputPlaats
            // 
            this.inputPlaats.Location = new System.Drawing.Point(77, 97);
            this.inputPlaats.Name = "inputPlaats";
            this.inputPlaats.Size = new System.Drawing.Size(160, 20);
            this.inputPlaats.TabIndex = 7;
            this.inputPlaats.TextChanged += new System.EventHandler(this.inputPlaats_TextChanged);
            // 
            // labelPlaats
            // 
            this.labelPlaats.AutoSize = true;
            this.labelPlaats.Location = new System.Drawing.Point(4, 100);
            this.labelPlaats.Name = "labelPlaats";
            this.labelPlaats.Size = new System.Drawing.Size(67, 13);
            this.labelPlaats.TabIndex = 6;
            this.labelPlaats.Text = "Woonplaats:";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(77, 136);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(160, 20);
            this.inputEmail.TabIndex = 9;
            this.inputEmail.TextChanged += new System.EventHandler(this.inputEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(7, 139);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(64, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "E-mailadres:";
            // 
            // inputTel
            // 
            this.inputTel.Location = new System.Drawing.Point(77, 162);
            this.inputTel.Name = "inputTel";
            this.inputTel.Size = new System.Drawing.Size(160, 20);
            this.inputTel.TabIndex = 11;
            this.inputTel.TextChanged += new System.EventHandler(this.inputTel_TextChanged);
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(27, 165);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(43, 13);
            this.labelTel.TabIndex = 10;
            this.labelTel.Text = "Tel. nr.:";
            // 
            // addKlantButton
            // 
            this.addKlantButton.Location = new System.Drawing.Point(257, 10);
            this.addKlantButton.Name = "addKlantButton";
            this.addKlantButton.Size = new System.Drawing.Size(75, 23);
            this.addKlantButton.TabIndex = 12;
            this.addKlantButton.Text = "Toevoegen";
            this.addKlantButton.UseVisualStyleBackColor = true;
            this.addKlantButton.Click += new System.EventHandler(this.addKlantButton_Click);
            // 
            // cancelAddKlantButton
            // 
            this.cancelAddKlantButton.Location = new System.Drawing.Point(257, 49);
            this.cancelAddKlantButton.Name = "cancelAddKlantButton";
            this.cancelAddKlantButton.Size = new System.Drawing.Size(75, 23);
            this.cancelAddKlantButton.TabIndex = 13;
            this.cancelAddKlantButton.Text = "Annuleren";
            this.cancelAddKlantButton.UseVisualStyleBackColor = true;
            this.cancelAddKlantButton.Click += new System.EventHandler(this.cancelAddKlantButton_Click);
            // 
            // addKlantPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 194);
            this.Controls.Add(this.cancelAddKlantButton);
            this.Controls.Add(this.addKlantButton);
            this.Controls.Add(this.inputTel);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.inputPlaats);
            this.Controls.Add(this.labelPlaats);
            this.Controls.Add(this.inputAdres);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.inputAchternaam);
            this.Controls.Add(this.labelAchternaam);
            this.Controls.Add(this.inputVoornaam);
            this.Controls.Add(this.labelVoornaam);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addKlantPage";
            this.Text = "Klant toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVoornaam;
        private System.Windows.Forms.TextBox inputVoornaam;
        private System.Windows.Forms.Label labelAchternaam;
        private System.Windows.Forms.TextBox inputAchternaam;
        private System.Windows.Forms.TextBox inputAdres;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.TextBox inputPlaats;
        private System.Windows.Forms.Label labelPlaats;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox inputTel;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Button addKlantButton;
        private System.Windows.Forms.Button cancelAddKlantButton;
    }
}