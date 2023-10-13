namespace Main
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbx_Exit = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_ErrorText = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.tbx_UserName = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbx_Exit);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.lbl_ErrorText);
            this.panel1.Controls.Add(this.lbl_Password);
            this.panel1.Controls.Add(this.tbx_Password);
            this.panel1.Controls.Add(this.lbl_UserName);
            this.panel1.Controls.Add(this.tbx_UserName);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Location = new System.Drawing.Point(828, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 390);
            this.panel1.TabIndex = 0;
            // 
            // pbx_Exit
            // 
            this.pbx_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx_Exit.BackgroundImage")));
            this.pbx_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_Exit.Location = new System.Drawing.Point(274, -1);
            this.pbx_Exit.Name = "pbx_Exit";
            this.pbx_Exit.Size = new System.Drawing.Size(25, 25);
            this.pbx_Exit.TabIndex = 7;
            this.pbx_Exit.TabStop = false;
            this.pbx_Exit.Click += new System.EventHandler(this.pbx_Exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Login.Location = new System.Drawing.Point(22, 242);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(256, 37);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_ErrorText
            // 
            this.lbl_ErrorText.AutoSize = true;
            this.lbl_ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ErrorText.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorText.Location = new System.Drawing.Point(57, 302);
            this.lbl_ErrorText.Name = "lbl_ErrorText";
            this.lbl_ErrorText.Size = new System.Drawing.Size(193, 16);
            this.lbl_ErrorText.TabIndex = 5;
            this.lbl_ErrorText.Text = "Wrong Username Or Password";
            this.lbl_ErrorText.Visible = false;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Password.Location = new System.Drawing.Point(18, 184);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(82, 20);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "Password:";
            // 
            // tbx_Password
            // 
            this.tbx_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_Password.Location = new System.Drawing.Point(115, 181);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.PasswordChar = '*';
            this.tbx_Password.Size = new System.Drawing.Size(163, 26);
            this.tbx_Password.TabIndex = 3;
            this.tbx_Password.Text = "12345";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_UserName.Location = new System.Drawing.Point(18, 122);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(93, 20);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "User Name:";
            // 
            // tbx_UserName
            // 
            this.tbx_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_UserName.Location = new System.Drawing.Point(115, 119);
            this.tbx_UserName.Name = "tbx_UserName";
            this.tbx_UserName.Size = new System.Drawing.Size(163, 26);
            this.tbx_UserName.TabIndex = 1;
            this.tbx_UserName.Text = "Utku Paralı";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Title.Location = new System.Drawing.Point(75, 40);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(145, 31);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "User Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox tbx_UserName;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_ErrorText;
        private System.Windows.Forms.PictureBox pbx_Exit;
    }
}

