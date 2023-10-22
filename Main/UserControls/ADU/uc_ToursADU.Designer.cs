namespace Main.UserControls
{
    partial class uc_ToursADU
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_CurrentSize = new System.Windows.Forms.TextBox();
            this.lbl_CurrentSize = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.tbx_Capacity = new System.Windows.Forms.TextBox();
            this.lbl_Capacity = new System.Windows.Forms.Label();
            this.tbx_TourName = new System.Windows.Forms.TextBox();
            this.lbl_TourName = new System.Windows.Forms.Label();
            this.tbx_Price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx_CurrentSize
            // 
            this.tbx_CurrentSize.Location = new System.Drawing.Point(529, 103);
            this.tbx_CurrentSize.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_CurrentSize.Name = "tbx_CurrentSize";
            this.tbx_CurrentSize.Size = new System.Drawing.Size(196, 31);
            this.tbx_CurrentSize.TabIndex = 22;
            // 
            // lbl_CurrentSize
            // 
            this.lbl_CurrentSize.AutoSize = true;
            this.lbl_CurrentSize.Location = new System.Drawing.Point(432, 106);
            this.lbl_CurrentSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_CurrentSize.Name = "lbl_CurrentSize";
            this.lbl_CurrentSize.Size = new System.Drawing.Size(88, 25);
            this.lbl_CurrentSize.TabIndex = 21;
            this.lbl_CurrentSize.Text = "Mevcut:";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(432, 29);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(69, 25);
            this.lbl_Price.TabIndex = 20;
            this.lbl_Price.Text = "Ücret:";
            // 
            // tbx_Capacity
            // 
            this.tbx_Capacity.Location = new System.Drawing.Point(140, 103);
            this.tbx_Capacity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_Capacity.Name = "tbx_Capacity";
            this.tbx_Capacity.Size = new System.Drawing.Size(196, 31);
            this.tbx_Capacity.TabIndex = 19;
            // 
            // lbl_Capacity
            // 
            this.lbl_Capacity.AutoSize = true;
            this.lbl_Capacity.Location = new System.Drawing.Point(41, 107);
            this.lbl_Capacity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Capacity.Name = "lbl_Capacity";
            this.lbl_Capacity.Size = new System.Drawing.Size(102, 25);
            this.lbl_Capacity.TabIndex = 18;
            this.lbl_Capacity.Text = "Kapasite:";
            // 
            // tbx_TourName
            // 
            this.tbx_TourName.Location = new System.Drawing.Point(140, 26);
            this.tbx_TourName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_TourName.Name = "tbx_TourName";
            this.tbx_TourName.Size = new System.Drawing.Size(196, 31);
            this.tbx_TourName.TabIndex = 17;
            // 
            // lbl_TourName
            // 
            this.lbl_TourName.AutoSize = true;
            this.lbl_TourName.Location = new System.Drawing.Point(41, 32);
            this.lbl_TourName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TourName.Name = "lbl_TourName";
            this.lbl_TourName.Size = new System.Drawing.Size(87, 25);
            this.lbl_TourName.TabIndex = 16;
            this.lbl_TourName.Text = "Tur Adı:";
            // 
            // tbx_Price
            // 
            this.tbx_Price.Location = new System.Drawing.Point(529, 26);
            this.tbx_Price.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_Price.Name = "tbx_Price";
            this.tbx_Price.Size = new System.Drawing.Size(196, 31);
            this.tbx_Price.TabIndex = 23;
            // 
            // uc_ToursADU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tbx_Price);
            this.Controls.Add(this.tbx_CurrentSize);
            this.Controls.Add(this.lbl_CurrentSize);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.tbx_Capacity);
            this.Controls.Add(this.lbl_Capacity);
            this.Controls.Add(this.tbx_TourName);
            this.Controls.Add(this.lbl_TourName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "uc_ToursADU";
            this.Size = new System.Drawing.Size(1179, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_CurrentSize;
        private System.Windows.Forms.Label lbl_CurrentSize;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox tbx_Capacity;
        private System.Windows.Forms.Label lbl_Capacity;
        private System.Windows.Forms.TextBox tbx_TourName;
        private System.Windows.Forms.Label lbl_TourName;
        private System.Windows.Forms.TextBox tbx_Price;
    }
}
