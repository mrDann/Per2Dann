namespace ProjectPeriode2
{
    partial class klantOverzicht
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
            this.addKlantButtonOverzicht = new System.Windows.Forms.Button();
            this.klantenView = new System.Windows.Forms.DataGridView();
            this.delKlantButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.klantenView)).BeginInit();
            this.SuspendLayout();
            // 
            // addKlantButtonOverzicht
            // 
            this.addKlantButtonOverzicht.Location = new System.Drawing.Point(1125, 52);
            this.addKlantButtonOverzicht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addKlantButtonOverzicht.Name = "addKlantButtonOverzicht";
            this.addKlantButtonOverzicht.Size = new System.Drawing.Size(250, 65);
            this.addKlantButtonOverzicht.TabIndex = 0;
            this.addKlantButtonOverzicht.Text = "Klant toevoegen";
            this.addKlantButtonOverzicht.UseVisualStyleBackColor = true;
            this.addKlantButtonOverzicht.Click += new System.EventHandler(this.addKlantButtonOverzicht_Click);
            // 
            // klantenView
            // 
            this.klantenView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klantenView.Location = new System.Drawing.Point(24, 52);
            this.klantenView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.klantenView.Name = "klantenView";
            this.klantenView.Size = new System.Drawing.Size(1091, 369);
            this.klantenView.TabIndex = 1;
            // 
            // delKlantButton
            // 
            this.delKlantButton.Location = new System.Drawing.Point(1125, 148);
            this.delKlantButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delKlantButton.Name = "delKlantButton";
            this.delKlantButton.Size = new System.Drawing.Size(250, 65);
            this.delKlantButton.TabIndex = 2;
            this.delKlantButton.Text = "Klant verwijderen";
            this.delKlantButton.UseVisualStyleBackColor = true;
            this.delKlantButton.Click += new System.EventHandler(this.delKlantButton_Click);
            // 
            // klantOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1408, 486);
            this.Controls.Add(this.delKlantButton);
            this.Controls.Add(this.klantenView);
            this.Controls.Add(this.addKlantButtonOverzicht);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "klantOverzicht";
            this.Text = "Overzicht klanten";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.klantOverzicht_Closed);
            this.Load += new System.EventHandler(this.klantOverzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klantenView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addKlantButtonOverzicht;
        private System.Windows.Forms.DataGridView klantenView;
        private System.Windows.Forms.Button delKlantButton;
    }
}