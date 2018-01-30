namespace ProjectPeriode2
{
    partial class addMenuPage
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
            this.addMenuButton = new System.Windows.Forms.Button();
            this.inputVoorgerecht = new System.Windows.Forms.TextBox();
            this.labelVoorgerecht = new System.Windows.Forms.Label();
            this.labelHoofdgerecht = new System.Windows.Forms.Label();
            this.inputHoofdgerecht = new System.Windows.Forms.TextBox();
            this.labelNagerecht = new System.Windows.Forms.Label();
            this.inputNagerecht = new System.Windows.Forms.TextBox();
            this.labelPrijs = new System.Windows.Forms.Label();
            this.inputPrijs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addMenuButton
            // 
            this.addMenuButton.Location = new System.Drawing.Point(752, 302);
            this.addMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.addMenuButton.Name = "addMenuButton";
            this.addMenuButton.Size = new System.Drawing.Size(329, 46);
            this.addMenuButton.TabIndex = 0;
            this.addMenuButton.Text = "+ Menu";
            this.addMenuButton.UseVisualStyleBackColor = true;
            this.addMenuButton.Click += new System.EventHandler(this.addMenuButton_Click);
            // 
            // inputVoorgerecht
            // 
            this.inputVoorgerecht.Location = new System.Drawing.Point(206, 83);
            this.inputVoorgerecht.Margin = new System.Windows.Forms.Padding(6);
            this.inputVoorgerecht.Name = "inputVoorgerecht";
            this.inputVoorgerecht.Size = new System.Drawing.Size(422, 31);
            this.inputVoorgerecht.TabIndex = 1;
            // 
            // labelVoorgerecht
            // 
            this.labelVoorgerecht.AutoSize = true;
            this.labelVoorgerecht.Location = new System.Drawing.Point(58, 88);
            this.labelVoorgerecht.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelVoorgerecht.Name = "labelVoorgerecht";
            this.labelVoorgerecht.Size = new System.Drawing.Size(135, 25);
            this.labelVoorgerecht.TabIndex = 2;
            this.labelVoorgerecht.Text = "Voorgerecht:";
            // 
            // labelHoofdgerecht
            // 
            this.labelHoofdgerecht.AutoSize = true;
            this.labelHoofdgerecht.Location = new System.Drawing.Point(44, 144);
            this.labelHoofdgerecht.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHoofdgerecht.Name = "labelHoofdgerecht";
            this.labelHoofdgerecht.Size = new System.Drawing.Size(147, 25);
            this.labelHoofdgerecht.TabIndex = 4;
            this.labelHoofdgerecht.Text = "Hoofdgerecht:";
            // 
            // inputHoofdgerecht
            // 
            this.inputHoofdgerecht.Location = new System.Drawing.Point(206, 138);
            this.inputHoofdgerecht.Margin = new System.Windows.Forms.Padding(6);
            this.inputHoofdgerecht.Name = "inputHoofdgerecht";
            this.inputHoofdgerecht.Size = new System.Drawing.Size(422, 31);
            this.inputHoofdgerecht.TabIndex = 3;
            // 
            // labelNagerecht
            // 
            this.labelNagerecht.AutoSize = true;
            this.labelNagerecht.Location = new System.Drawing.Point(74, 194);
            this.labelNagerecht.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNagerecht.Name = "labelNagerecht";
            this.labelNagerecht.Size = new System.Drawing.Size(117, 25);
            this.labelNagerecht.TabIndex = 6;
            this.labelNagerecht.Text = "Nagerecht:";
            // 
            // inputNagerecht
            // 
            this.inputNagerecht.Location = new System.Drawing.Point(206, 188);
            this.inputNagerecht.Margin = new System.Windows.Forms.Padding(6);
            this.inputNagerecht.Name = "inputNagerecht";
            this.inputNagerecht.Size = new System.Drawing.Size(422, 31);
            this.inputNagerecht.TabIndex = 5;
            // 
            // labelPrijs
            // 
            this.labelPrijs.AutoSize = true;
            this.labelPrijs.Location = new System.Drawing.Point(124, 258);
            this.labelPrijs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPrijs.Name = "labelPrijs";
            this.labelPrijs.Size = new System.Drawing.Size(60, 25);
            this.labelPrijs.TabIndex = 8;
            this.labelPrijs.Text = "Prijs:";
            // 
            // inputPrijs
            // 
            this.inputPrijs.Location = new System.Drawing.Point(206, 252);
            this.inputPrijs.Margin = new System.Windows.Forms.Padding(6);
            this.inputPrijs.Name = "inputPrijs";
            this.inputPrijs.Size = new System.Drawing.Size(422, 31);
            this.inputPrijs.TabIndex = 7;
            // 
            // addMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 431);
            this.Controls.Add(this.labelPrijs);
            this.Controls.Add(this.inputPrijs);
            this.Controls.Add(this.labelNagerecht);
            this.Controls.Add(this.inputNagerecht);
            this.Controls.Add(this.labelHoofdgerecht);
            this.Controls.Add(this.inputHoofdgerecht);
            this.Controls.Add(this.labelVoorgerecht);
            this.Controls.Add(this.inputVoorgerecht);
            this.Controls.Add(this.addMenuButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addMenuPage";
            this.Text = "Menu\'s toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addMenuButton;
        private System.Windows.Forms.TextBox inputVoorgerecht;
        private System.Windows.Forms.Label labelVoorgerecht;
        private System.Windows.Forms.Label labelHoofdgerecht;
        private System.Windows.Forms.TextBox inputHoofdgerecht;
        private System.Windows.Forms.Label labelNagerecht;
        private System.Windows.Forms.TextBox inputNagerecht;
        private System.Windows.Forms.Label labelPrijs;
        private System.Windows.Forms.TextBox inputPrijs;
    }
}