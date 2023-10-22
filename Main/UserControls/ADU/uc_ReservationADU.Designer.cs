namespace Main.UserControls
{
    partial class uc_ReservationADU
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
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_RoomNo = new System.Windows.Forms.Label();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tbx_ResNo = new System.Windows.Forms.TextBox();
            this.lbl_ResNo = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.tbx_RoomNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(810, 107);
            this.lbl_EndDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(65, 25);
            this.lbl_EndDate.TabIndex = 25;
            this.lbl_EndDate.Text = "Çıkış:";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(810, 32);
            this.lbl_StartDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(62, 25);
            this.lbl_StartDate.TabIndex = 23;
            this.lbl_StartDate.Text = "Giriş:";
            // 
            // lbl_RoomNo
            // 
            this.lbl_RoomNo.AutoSize = true;
            this.lbl_RoomNo.Location = new System.Drawing.Point(434, 30);
            this.lbl_RoomNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_RoomNo.Name = "lbl_RoomNo";
            this.lbl_RoomNo.Size = new System.Drawing.Size(91, 25);
            this.lbl_RoomNo.TabIndex = 20;
            this.lbl_RoomNo.Text = "Oda No:";
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(142, 104);
            this.tbx_Name.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(196, 31);
            this.tbx_Name.TabIndex = 19;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(43, 108);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(56, 25);
            this.lbl_Name.TabIndex = 18;
            this.lbl_Name.Text = "İsim:";
            // 
            // tbx_ResNo
            // 
            this.tbx_ResNo.Location = new System.Drawing.Point(142, 27);
            this.tbx_ResNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_ResNo.Name = "tbx_ResNo";
            this.tbx_ResNo.Size = new System.Drawing.Size(196, 31);
            this.tbx_ResNo.TabIndex = 17;
            // 
            // lbl_ResNo
            // 
            this.lbl_ResNo.AutoSize = true;
            this.lbl_ResNo.Location = new System.Drawing.Point(43, 33);
            this.lbl_ResNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ResNo.Name = "lbl_ResNo";
            this.lbl_ResNo.Size = new System.Drawing.Size(89, 25);
            this.lbl_ResNo.TabIndex = 16;
            this.lbl_ResNo.Text = "Rez No:";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Location = new System.Drawing.Point(920, 28);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(196, 31);
            this.dtp_StartDate.TabIndex = 28;
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(920, 103);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(196, 31);
            this.dtp_EndDate.TabIndex = 29;
            // 
            // tbx_RoomNo
            // 
            this.tbx_RoomNo.Location = new System.Drawing.Point(531, 27);
            this.tbx_RoomNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_RoomNo.Name = "tbx_RoomNo";
            this.tbx_RoomNo.Size = new System.Drawing.Size(196, 31);
            this.tbx_RoomNo.TabIndex = 30;
            // 
            // uc_ReservationADU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tbx_RoomNo);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.dtp_StartDate);
            this.Controls.Add(this.lbl_EndDate);
            this.Controls.Add(this.lbl_StartDate);
            this.Controls.Add(this.lbl_RoomNo);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tbx_ResNo);
            this.Controls.Add(this.lbl_ResNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "uc_ReservationADU";
            this.Size = new System.Drawing.Size(1179, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Label lbl_RoomNo;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tbx_ResNo;
        private System.Windows.Forms.Label lbl_ResNo;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.TextBox tbx_RoomNo;
    }
}
