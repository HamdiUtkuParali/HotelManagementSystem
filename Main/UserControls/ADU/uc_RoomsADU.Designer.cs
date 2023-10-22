namespace Main.UserControls
{
    partial class uc_RoomsADU
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
            this.cbx_Status = new System.Windows.Forms.ComboBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.tbx_Bed = new System.Windows.Forms.TextBox();
            this.lbl_Bed = new System.Windows.Forms.Label();
            this.tbx_RoomNo = new System.Windows.Forms.TextBox();
            this.lbl_RoomNo = new System.Windows.Forms.Label();
            this.tbx_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_Status
            // 
            this.cbx_Status.FormattingEnabled = true;
            this.cbx_Status.Location = new System.Drawing.Point(530, 26);
            this.cbx_Status.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Status.Name = "cbx_Status";
            this.cbx_Status.Size = new System.Drawing.Size(196, 33);
            this.cbx_Status.TabIndex = 37;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(433, 29);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(81, 25);
            this.lbl_Status.TabIndex = 34;
            this.lbl_Status.Text = "Durum:";
            // 
            // tbx_Bed
            // 
            this.tbx_Bed.Location = new System.Drawing.Point(141, 103);
            this.tbx_Bed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_Bed.Name = "tbx_Bed";
            this.tbx_Bed.Size = new System.Drawing.Size(196, 31);
            this.tbx_Bed.TabIndex = 33;
            // 
            // lbl_Bed
            // 
            this.lbl_Bed.AutoSize = true;
            this.lbl_Bed.Location = new System.Drawing.Point(42, 107);
            this.lbl_Bed.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Bed.Name = "lbl_Bed";
            this.lbl_Bed.Size = new System.Drawing.Size(74, 25);
            this.lbl_Bed.TabIndex = 32;
            this.lbl_Bed.Text = "Yatak:";
            // 
            // tbx_RoomNo
            // 
            this.tbx_RoomNo.Location = new System.Drawing.Point(141, 26);
            this.tbx_RoomNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_RoomNo.Name = "tbx_RoomNo";
            this.tbx_RoomNo.Size = new System.Drawing.Size(196, 31);
            this.tbx_RoomNo.TabIndex = 31;
            // 
            // lbl_RoomNo
            // 
            this.lbl_RoomNo.AutoSize = true;
            this.lbl_RoomNo.Location = new System.Drawing.Point(42, 32);
            this.lbl_RoomNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_RoomNo.Name = "lbl_RoomNo";
            this.lbl_RoomNo.Size = new System.Drawing.Size(91, 25);
            this.lbl_RoomNo.TabIndex = 30;
            this.lbl_RoomNo.Text = "Oda No:";
            // 
            // tbx_Price
            // 
            this.tbx_Price.Location = new System.Drawing.Point(530, 103);
            this.tbx_Price.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_Price.Name = "tbx_Price";
            this.tbx_Price.Size = new System.Drawing.Size(196, 31);
            this.tbx_Price.TabIndex = 40;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(433, 106);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(69, 25);
            this.lbl_Price.TabIndex = 41;
            this.lbl_Price.Text = "Ücret:";
            // 
            // uc_RoomsADU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.tbx_Price);
            this.Controls.Add(this.cbx_Status);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.tbx_Bed);
            this.Controls.Add(this.lbl_Bed);
            this.Controls.Add(this.tbx_RoomNo);
            this.Controls.Add(this.lbl_RoomNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "uc_RoomsADU";
            this.Size = new System.Drawing.Size(1179, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_Status;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TextBox tbx_Bed;
        private System.Windows.Forms.Label lbl_Bed;
        private System.Windows.Forms.TextBox tbx_RoomNo;
        private System.Windows.Forms.Label lbl_RoomNo;
        private System.Windows.Forms.TextBox tbx_Price;
        private System.Windows.Forms.Label lbl_Price;
    }
}
