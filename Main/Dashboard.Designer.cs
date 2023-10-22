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
            this.pnl_MainMenu = new System.Windows.Forms.Panel();
            this.btn_Customers = new System.Windows.Forms.Button();
            this.btn_Workers = new System.Windows.Forms.Button();
            this.btn_Rooms = new System.Windows.Forms.Button();
            this.btn_Tours = new System.Windows.Forms.Button();
            this.btn_Reservations = new System.Windows.Forms.Button();
            this.pbx_Exit = new System.Windows.Forms.PictureBox();
            this.pbx_Minimize = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uc_Customer1 = new Main.UserControls.uc_Customer();
            this.pnl_MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Minimize)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_MainMenu
            // 
            this.pnl_MainMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_MainMenu.Controls.Add(this.btn_Customers);
            this.pnl_MainMenu.Controls.Add(this.btn_Workers);
            this.pnl_MainMenu.Controls.Add(this.btn_Rooms);
            this.pnl_MainMenu.Controls.Add(this.btn_Tours);
            this.pnl_MainMenu.Controls.Add(this.btn_Reservations);
            this.pnl_MainMenu.Location = new System.Drawing.Point(0, 64);
            this.pnl_MainMenu.Name = "pnl_MainMenu";
            this.pnl_MainMenu.Size = new System.Drawing.Size(1920, 200);
            this.pnl_MainMenu.TabIndex = 0;
            // 
            // btn_Customers
            // 
            this.btn_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Customers.Location = new System.Drawing.Point(57, 65);
            this.btn_Customers.Name = "btn_Customers";
            this.btn_Customers.Size = new System.Drawing.Size(247, 88);
            this.btn_Customers.TabIndex = 0;
            this.btn_Customers.Text = "Müşteriler";
            this.btn_Customers.UseVisualStyleBackColor = true;
            this.btn_Customers.Click += new System.EventHandler(this.btn_Customers_Click);
            // 
            // btn_Workers
            // 
            this.btn_Workers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Workers.Location = new System.Drawing.Point(435, 65);
            this.btn_Workers.Name = "btn_Workers";
            this.btn_Workers.Size = new System.Drawing.Size(247, 88);
            this.btn_Workers.TabIndex = 1;
            this.btn_Workers.Text = "Çalışanlar";
            this.btn_Workers.UseVisualStyleBackColor = true;
            // 
            // btn_Rooms
            // 
            this.btn_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Rooms.Location = new System.Drawing.Point(818, 65);
            this.btn_Rooms.Name = "btn_Rooms";
            this.btn_Rooms.Size = new System.Drawing.Size(247, 88);
            this.btn_Rooms.TabIndex = 2;
            this.btn_Rooms.Text = "Odalar";
            this.btn_Rooms.UseVisualStyleBackColor = true;
            // 
            // btn_Tours
            // 
            this.btn_Tours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Tours.Location = new System.Drawing.Point(1206, 65);
            this.btn_Tours.Name = "btn_Tours";
            this.btn_Tours.Size = new System.Drawing.Size(247, 88);
            this.btn_Tours.TabIndex = 10;
            this.btn_Tours.Text = "Turlar";
            this.btn_Tours.UseVisualStyleBackColor = true;
            // 
            // btn_Reservations
            // 
            this.btn_Reservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Reservations.Location = new System.Drawing.Point(1568, 65);
            this.btn_Reservations.Name = "btn_Reservations";
            this.btn_Reservations.Size = new System.Drawing.Size(247, 88);
            this.btn_Reservations.TabIndex = 11;
            this.btn_Reservations.Text = "Rezervasyonlar";
            this.btn_Reservations.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.uc_Customer1);
            this.panel1.Location = new System.Drawing.Point(175, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1506, 744);
            this.panel1.TabIndex = 13;
            // 
            // uc_Customer1
            // 
            this.uc_Customer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_Customer1.Location = new System.Drawing.Point(0, 0);
            this.uc_Customer1.Name = "uc_Customer1";
            this.uc_Customer1.Size = new System.Drawing.Size(1506, 744);
            this.uc_Customer1.TabIndex = 0;
            this.uc_Customer1.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pbx_Minimize);
            this.Controls.Add(this.pbx_Exit);
            this.Controls.Add(this.pnl_MainMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_MainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Minimize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_MainMenu;
        private System.Windows.Forms.Button btn_Rooms;
        private System.Windows.Forms.Button btn_Workers;
        private System.Windows.Forms.Button btn_Customers;
        private System.Windows.Forms.PictureBox pbx_Exit;
        private System.Windows.Forms.PictureBox pbx_Minimize;
        private System.Windows.Forms.Button btn_Reservations;
        private System.Windows.Forms.Button btn_Tours;
        private System.Windows.Forms.Panel panel1;
        private UserControls.uc_Customer uc_Customer1;
    }
}