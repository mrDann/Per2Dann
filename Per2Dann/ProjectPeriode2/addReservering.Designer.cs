namespace ProjectPeriode2
{
    partial class addReservering
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
            this.addResButton = new System.Windows.Forms.Button();
            this.reserveringView = new System.Windows.Forms.DataGridView();
            this.delResButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reserveringView)).BeginInit();
            this.SuspendLayout();
            // 
            // addResButton
            // 
            this.addResButton.Location = new System.Drawing.Point(551, 27);
            this.addResButton.Margin = new System.Windows.Forms.Padding(2);
            this.addResButton.Name = "addResButton";
            this.addResButton.Size = new System.Drawing.Size(131, 34);
            this.addResButton.TabIndex = 0;
            this.addResButton.Text = "Reservering toevoegen";
            this.addResButton.UseVisualStyleBackColor = true;
            this.addResButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // reserveringView
            // 
            this.reserveringView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserveringView.Location = new System.Drawing.Point(12, 27);
            this.reserveringView.Name = "reserveringView";
            this.reserveringView.Size = new System.Drawing.Size(512, 192);
            this.reserveringView.TabIndex = 1;
            this.reserveringView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reserveringView_CellContentClick);
            // 
            // delResButton
            // 
            this.delResButton.Location = new System.Drawing.Point(551, 79);
            this.delResButton.Margin = new System.Windows.Forms.Padding(2);
            this.delResButton.Name = "delResButton";
            this.delResButton.Size = new System.Drawing.Size(131, 34);
            this.delResButton.TabIndex = 2;
            this.delResButton.Text = "Reservering verwijderen";
            this.delResButton.UseVisualStyleBackColor = true;
            // 
            // addReservering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 281);
            this.Controls.Add(this.delResButton);
            this.Controls.Add(this.reserveringView);
            this.Controls.Add(this.addResButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addReservering";
            this.Text = "Overzicht reserveringen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addReservering_Closed);
            this.Load += new System.EventHandler(this.addReservering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reserveringView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addResButton;
        private System.Windows.Forms.DataGridView reserveringView;
        private System.Windows.Forms.Button delResButton;
    }
}