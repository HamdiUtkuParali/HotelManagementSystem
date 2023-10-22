namespace Main.UserControls
{
    partial class uc_CustomersSearch
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
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.cbx_IsAdult = new System.Windows.Forms.ComboBox();
            this.lbl_IsAdult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_Name
            // 
            this.tbx_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_Name.Location = new System.Drawing.Point(48, 52);
            this.tbx_Name.Margin = new System.Windows.Forms.Padding(6);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(450, 31);
            this.tbx_Name.TabIndex = 5;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Name.Location = new System.Drawing.Point(43, 21);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(56, 25);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "İsim:";
            // 
            // cbx_IsAdult
            // 
            this.cbx_IsAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_IsAdult.FormattingEnabled = true;
            this.cbx_IsAdult.Location = new System.Drawing.Point(578, 50);
            this.cbx_IsAdult.Margin = new System.Windows.Forms.Padding(6);
            this.cbx_IsAdult.Name = "cbx_IsAdult";
            this.cbx_IsAdult.Size = new System.Drawing.Size(450, 33);
            this.cbx_IsAdult.TabIndex = 6;
            // 
            // lbl_IsAdult
            // 
            this.lbl_IsAdult.AutoSize = true;
            this.lbl_IsAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_IsAdult.Location = new System.Drawing.Point(573, 21);
            this.lbl_IsAdult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_IsAdult.Name = "lbl_IsAdult";
            this.lbl_IsAdult.Size = new System.Drawing.Size(89, 25);
            this.lbl_IsAdult.TabIndex = 7;
            this.lbl_IsAdult.Text = "Yetişkin";
            // 
            // uc_CustomersSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.cbx_IsAdult);
            this.Controls.Add(this.lbl_IsAdult);
            this.Controls.Add(this.lbl_Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "uc_CustomersSearch";
            this.Size = new System.Drawing.Size(1488, 118);
            this.Load += new System.EventHandler(this.uc_CustomersSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.ComboBox cbx_IsAdult;
        private System.Windows.Forms.Label lbl_IsAdult;
    }
}
