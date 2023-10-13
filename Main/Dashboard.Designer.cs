namespace Main
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_UnderLine = new System.Windows.Forms.Panel();
            this.btn_Lists = new System.Windows.Forms.Button();
            this.btn_TourRegister = new System.Windows.Forms.Button();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.btn_CreateRes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uc_TourRegister1 = new Main.UserControls.uc_TourRegister();
            this.uc_CheckIn1 = new Main.UserControls.uc_CheckIn();
            this.uc_CreateRes1 = new Main.UserControls.uc_CreateRes();
            this.uc_Lists1 = new Main.UserControls.uc_Lists();
            this.pbx_Exit = new System.Windows.Forms.PictureBox();
            this.pbx_Minimize = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pnl_UnderLine);
            this.panel1.Controls.Add(this.btn_Lists);
            this.panel1.Controls.Add(this.btn_TourRegister);
            this.panel1.Controls.Add(this.btn_CheckIn);
            this.panel1.Controls.Add(this.btn_CreateRes);
            this.panel1.Location = new System.Drawing.Point(175, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 200);
            this.panel1.TabIndex = 0;
            // 
            // pnl_UnderLine
            // 
            this.pnl_UnderLine.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_UnderLine.Location = new System.Drawing.Point(57, 152);
            this.pnl_UnderLine.Name = "pnl_UnderLine";
            this.pnl_UnderLine.Size = new System.Drawing.Size(247, 5);
            this.pnl_UnderLine.TabIndex = 9;
            // 
            // btn_Lists
            // 
            this.btn_Lists.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Lists.Location = new System.Drawing.Point(1166, 65);
            this.btn_Lists.Name = "btn_Lists";
            this.btn_Lists.Size = new System.Drawing.Size(247, 88);
            this.btn_Lists.TabIndex = 3;
            this.btn_Lists.Text = "Listeler";
            this.btn_Lists.UseVisualStyleBackColor = true;
            this.btn_Lists.Click += new System.EventHandler(this.btn_Lists_Click);
            // 
            // btn_TourRegister
            // 
            this.btn_TourRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_TourRegister.Location = new System.Drawing.Point(800, 65);
            this.btn_TourRegister.Name = "btn_TourRegister";
            this.btn_TourRegister.Size = new System.Drawing.Size(247, 88);
            this.btn_TourRegister.TabIndex = 2;
            this.btn_TourRegister.Text = "Tur Kayıt";
            this.btn_TourRegister.UseVisualStyleBackColor = true;
            this.btn_TourRegister.Click += new System.EventHandler(this.btn_TourRegister_Click);
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CheckIn.Location = new System.Drawing.Point(411, 65);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(247, 88);
            this.btn_CheckIn.TabIndex = 1;
            this.btn_CheckIn.Text = "Check-In";
            this.btn_CheckIn.UseVisualStyleBackColor = true;
            this.btn_CheckIn.Click += new System.EventHandler(this.btn_CheckIn_Click);
            // 
            // btn_CreateRes
            // 
            this.btn_CreateRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CreateRes.Location = new System.Drawing.Point(57, 65);
            this.btn_CreateRes.Name = "btn_CreateRes";
            this.btn_CreateRes.Size = new System.Drawing.Size(247, 88);
            this.btn_CreateRes.TabIndex = 0;
            this.btn_CreateRes.Text = "Rezervasyon Oluştur";
            this.btn_CreateRes.UseVisualStyleBackColor = true;
            this.btn_CreateRes.Click += new System.EventHandler(this.btn_CreateRes_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uc_TourRegister1);
            this.panel2.Controls.Add(this.uc_CheckIn1);
            this.panel2.Controls.Add(this.uc_CreateRes1);
            this.panel2.Controls.Add(this.uc_Lists1);
            this.panel2.Location = new System.Drawing.Point(175, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 750);
            this.panel2.TabIndex = 1;
            // 
            // uc_TourRegister1
            // 
            this.uc_TourRegister1.BackColor = System.Drawing.Color.White;
            this.uc_TourRegister1.Location = new System.Drawing.Point(3, 3);
            this.uc_TourRegister1.Name = "uc_TourRegister1";
            this.uc_TourRegister1.Size = new System.Drawing.Size(1490, 740);
            this.uc_TourRegister1.TabIndex = 6;
            this.uc_TourRegister1.Visible = false;
            // 
            // uc_CheckIn1
            // 
            this.uc_CheckIn1.BackColor = System.Drawing.Color.White;
            this.uc_CheckIn1.Location = new System.Drawing.Point(3, 3);
            this.uc_CheckIn1.Name = "uc_CheckIn1";
            this.uc_CheckIn1.Size = new System.Drawing.Size(1490, 740);
            this.uc_CheckIn1.TabIndex = 5;
            this.uc_CheckIn1.Visible = false;
            // 
            // uc_CreateRes1
            // 
            this.uc_CreateRes1.BackColor = System.Drawing.Color.White;
            this.uc_CreateRes1.Location = new System.Drawing.Point(3, 3);
            this.uc_CreateRes1.Name = "uc_CreateRes1";
            this.uc_CreateRes1.Size = new System.Drawing.Size(1490, 740);
            this.uc_CreateRes1.TabIndex = 4;
            this.uc_CreateRes1.Visible = false;
            // 
            // uc_Lists1
            // 
            this.uc_Lists1.BackColor = System.Drawing.Color.White;
            this.uc_Lists1.Location = new System.Drawing.Point(3, 3);
            this.uc_Lists1.Name = "uc_Lists1";
            this.uc_Lists1.Size = new System.Drawing.Size(1490, 740);
            this.uc_Lists1.TabIndex = 3;
            this.uc_Lists1.Visible = false;
            // 
            // pbx_Exit
            // 
            this.pbx_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx_Exit.BackgroundImage")));
            this.pbx_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_Exit.Location = new System.Drawing.Point(1880, 0);
            this.pbx_Exit.Name = "pbx_Exit";
            this.pbx_Exit.Size = new System.Drawing.Size(40, 40);
            this.pbx_Exit.TabIndex = 8;
            this.pbx_Exit.TabStop = false;
            this.pbx_Exit.Click += new System.EventHandler(this.pbx_Exit_Click);
            // 
            // pbx_Minimize
            // 
            this.pbx_Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx_Minimize.BackgroundImage")));
            this.pbx_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_Minimize.Location = new System.Drawing.Point(1834, 0);
            this.pbx_Minimize.Name = "pbx_Minimize";
            this.pbx_Minimize.Size = new System.Drawing.Size(40, 40);
            this.pbx_Minimize.TabIndex = 9;
            this.pbx_Minimize.TabStop = false;
            this.pbx_Minimize.Click += new System.EventHandler(this.pbx_Minimize_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pbx_Minimize);
            this.Controls.Add(this.pbx_Exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Minimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Lists;
        private System.Windows.Forms.Button btn_TourRegister;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.Button btn_CreateRes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbx_Exit;
        private System.Windows.Forms.Panel pnl_UnderLine;
        private System.Windows.Forms.PictureBox pbx_Minimize;
        private UserControls.uc_CreateRes createRes1;
        private UserControls.uc_Lists uc_Lists1;
        private UserControls.uc_CreateRes uc_CreateRes1;
        private UserControls.uc_TourRegister uc_TourRegister1;
        private UserControls.uc_CheckIn uc_CheckIn1;
    }
}