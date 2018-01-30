namespace ProjectPeriode2
{
    partial class AddReserveringNew
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputKlantID = new System.Windows.Forms.TextBox();
            this.inputMenuID = new System.Windows.Forms.TextBox();
            this.inputAantalPersonen = new System.Windows.Forms.TextBox();
            this.inputAantalTafels = new System.Windows.Forms.TextBox();
            this.inputTijd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(790, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "+ Reservering";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputKlantID
            // 
            this.inputKlantID.Location = new System.Drawing.Point(254, 75);
            this.inputKlantID.Name = "inputKlantID";
            this.inputKlantID.Size = new System.Drawing.Size(397, 31);
            this.inputKlantID.TabIndex = 1;
            // 
            // inputMenuID
            // 
            this.inputMenuID.Location = new System.Drawing.Point(254, 145);
            this.inputMenuID.Name = "inputMenuID";
            this.inputMenuID.Size = new System.Drawing.Size(397, 31);
            this.inputMenuID.TabIndex = 2;
            // 
            // inputAantalPersonen
            // 
            this.inputAantalPersonen.Location = new System.Drawing.Point(254, 214);
            this.inputAantalPersonen.Name = "inputAantalPersonen";
            this.inputAantalPersonen.Size = new System.Drawing.Size(397, 31);
            this.inputAantalPersonen.TabIndex = 3;
            // 
            // inputAantalTafels
            // 
            this.inputAantalTafels.Location = new System.Drawing.Point(254, 293);
            this.inputAantalTafels.Name = "inputAantalTafels";
            this.inputAantalTafels.Size = new System.Drawing.Size(397, 31);
            this.inputAantalTafels.TabIndex = 4;
            // 
            // inputTijd
            // 
            this.inputTijd.Location = new System.Drawing.Point(254, 368);
            this.inputTijd.Name = "inputTijd";
            this.inputTijd.Size = new System.Drawing.Size(397, 31);
            this.inputTijd.TabIndex = 5;
            this.inputTijd.Text = "18:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "KlantID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "MenuID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "AantalPersonen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aantal Tafels";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tijd";
            // 
            // AddReserveringNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 471);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTijd);
            this.Controls.Add(this.inputAantalTafels);
            this.Controls.Add(this.inputAantalPersonen);
            this.Controls.Add(this.inputMenuID);
            this.Controls.Add(this.inputKlantID);
            this.Controls.Add(this.button1);
            this.Name = "AddReserveringNew";
            this.Text = "Voeg reservering toe:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputKlantID;
        private System.Windows.Forms.TextBox inputMenuID;
        private System.Windows.Forms.TextBox inputAantalPersonen;
        private System.Windows.Forms.TextBox inputAantalTafels;
        private System.Windows.Forms.TextBox inputTijd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}