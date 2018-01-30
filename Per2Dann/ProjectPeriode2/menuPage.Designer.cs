namespace ProjectPeriode2
{
    partial class menuPage
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
            this.menuView = new System.Windows.Forms.DataGridView();
            this.delMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuView)).BeginInit();
            this.SuspendLayout();
            // 
            // addMenuButton
            // 
            this.addMenuButton.Location = new System.Drawing.Point(1091, 49);
            this.addMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.addMenuButton.Name = "addMenuButton";
            this.addMenuButton.Size = new System.Drawing.Size(280, 62);
            this.addMenuButton.TabIndex = 0;
            this.addMenuButton.Text = "Menu toevoegen";
            this.addMenuButton.UseVisualStyleBackColor = true;
            this.addMenuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuView
            // 
            this.menuView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuView.Location = new System.Drawing.Point(46, 31);
            this.menuView.Margin = new System.Windows.Forms.Padding(6);
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(925, 550);
            this.menuView.TabIndex = 1;
            // 
            // delMenuButton
            // 
            this.delMenuButton.Location = new System.Drawing.Point(1091, 142);
            this.delMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.delMenuButton.Name = "delMenuButton";
            this.delMenuButton.Size = new System.Drawing.Size(280, 62);
            this.delMenuButton.TabIndex = 2;
            this.delMenuButton.Text = "Menu verwijderen";
            this.delMenuButton.UseVisualStyleBackColor = true;
            this.delMenuButton.Click += new System.EventHandler(this.delMenuButton_Click);
            // 
            // menuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1528, 813);
            this.Controls.Add(this.delMenuButton);
            this.Controls.Add(this.menuView);
            this.Controls.Add(this.addMenuButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menuPage";
            this.Text = "Menubeheer";
            this.Load += new System.EventHandler(this.menuPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addMenuButton;
        private System.Windows.Forms.DataGridView menuView;
        private System.Windows.Forms.Button delMenuButton;
    }
}