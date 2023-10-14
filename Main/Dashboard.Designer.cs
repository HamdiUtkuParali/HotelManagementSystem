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
            this.btn_Reservations = new System.Windows.Forms.Button();
            this.btn_Tours = new System.Windows.Forms.Button();
            this.btn_Rooms = new System.Windows.Forms.Button();
            this.btn_Workers = new System.Windows.Forms.Button();
            this.btn_Customers = new System.Windows.Forms.Button();
            this.pbx_Exit = new System.Windows.Forms.PictureBox();
            this.pbx_Minimize = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.gbxADU = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.cbx_Operation = new System.Windows.Forms.ComboBox();
            this.btn_Okey = new System.Windows.Forms.Button();
            this.lbl_Operation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uc_WorkersSearch1 = new Main.UserControls.uc_WorkersSearch();
            this.uc_ToursSearch1 = new Main.UserControls.uc_ToursSearch();
            this.uc_RoomsSearch1 = new Main.UserControls.uc_RoomsSearch();
            this.uc_ReservationSearch1 = new Main.UserControls.uc_ReservationSearch();
            this.uc_CustomersSearch1 = new Main.UserControls.uc_CustomersSearch();
            this.uc_WorkersADU1 = new Main.UserControls.uc_WorkersADU();
            this.uc_ToursADU1 = new Main.UserControls.uc_ToursADU();
            this.uc_RoomsADU1 = new Main.UserControls.uc_RoomsADU();
            this.uc_ReservationADU1 = new Main.UserControls.uc_ReservationADU();
            this.uc_CustomersADU1 = new Main.UserControls.uc_CustomersADU();
            this.pnl_MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.gbxADU.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // btn_Workers
            // 
            this.btn_Workers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Workers.Location = new System.Drawing.Point(435, 65);
            this.btn_Workers.Name = "btn_Workers";
            this.btn_Workers.Size = new System.Drawing.Size(247, 88);
            this.btn_Workers.TabIndex = 1;
            this.btn_Workers.Text = "Çalışanlar";
            this.btn_Workers.UseVisualStyleBackColor = true;
            this.btn_Workers.Click += new System.EventHandler(this.btn_Workers_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 432);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1500, 362);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.pnlSearch);
            this.gbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearch.ForeColor = System.Drawing.Color.White;
            this.gbxSearch.Location = new System.Drawing.Point(175, 270);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(1500, 154);
            this.gbxSearch.TabIndex = 11;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ara";
            this.gbxSearch.Visible = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.uc_WorkersSearch1);
            this.pnlSearch.Controls.Add(this.uc_ToursSearch1);
            this.pnlSearch.Controls.Add(this.uc_RoomsSearch1);
            this.pnlSearch.Controls.Add(this.uc_ReservationSearch1);
            this.pnlSearch.Controls.Add(this.uc_CustomersSearch1);
            this.pnlSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlSearch.Location = new System.Drawing.Point(6, 30);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1488, 118);
            this.pnlSearch.TabIndex = 4;
            // 
            // gbxADU
            // 
            this.gbxADU.Controls.Add(this.lbl_Operation);
            this.gbxADU.Controls.Add(this.cbx_Operation);
            this.gbxADU.Controls.Add(this.btn_Clear);
            this.gbxADU.Controls.Add(this.btn_Okey);
            this.gbxADU.Controls.Add(this.panel2);
            this.gbxADU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxADU.ForeColor = System.Drawing.Color.White;
            this.gbxADU.Location = new System.Drawing.Point(175, 807);
            this.gbxADU.Name = "gbxADU";
            this.gbxADU.Size = new System.Drawing.Size(1500, 207);
            this.gbxADU.TabIndex = 12;
            this.gbxADU.TabStop = false;
            this.gbxADU.Text = "Ekle/Sil/Güncelle";
            this.gbxADU.Visible = false;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Brown;
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(28, 123);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(101, 35);
            this.btn_Clear.TabIndex = 21;
            this.btn_Clear.Text = "Temizle";
            this.btn_Clear.UseVisualStyleBackColor = false;
            // 
            // cbx_Operation
            // 
            this.cbx_Operation.FormattingEnabled = true;
            this.cbx_Operation.Location = new System.Drawing.Point(119, 55);
            this.cbx_Operation.Name = "cbx_Operation";
            this.cbx_Operation.Size = new System.Drawing.Size(158, 33);
            this.cbx_Operation.TabIndex = 20;
            // 
            // btn_Okey
            // 
            this.btn_Okey.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Okey.ForeColor = System.Drawing.Color.White;
            this.btn_Okey.Location = new System.Drawing.Point(152, 123);
            this.btn_Okey.Name = "btn_Okey";
            this.btn_Okey.Size = new System.Drawing.Size(125, 35);
            this.btn_Okey.TabIndex = 19;
            this.btn_Okey.Text = "Onay";
            this.btn_Okey.UseVisualStyleBackColor = false;
            // 
            // lbl_Operation
            // 
            this.lbl_Operation.AutoSize = true;
            this.lbl_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Operation.Location = new System.Drawing.Point(24, 62);
            this.lbl_Operation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Operation.Name = "lbl_Operation";
            this.lbl_Operation.Size = new System.Drawing.Size(57, 20);
            this.lbl_Operation.TabIndex = 18;
            this.lbl_Operation.Text = "İşlem:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uc_WorkersADU1);
            this.panel2.Controls.Add(this.uc_ToursADU1);
            this.panel2.Controls.Add(this.uc_RoomsADU1);
            this.panel2.Controls.Add(this.uc_ReservationADU1);
            this.panel2.Controls.Add(this.uc_CustomersADU1);
            this.panel2.Location = new System.Drawing.Point(315, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 171);
            this.panel2.TabIndex = 0;
            // 
            // uc_WorkersSearch1
            // 
            this.uc_WorkersSearch1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_WorkersSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uc_WorkersSearch1.Location = new System.Drawing.Point(0, 0);
            this.uc_WorkersSearch1.Margin = new System.Windows.Forms.Padding(6);
            this.uc_WorkersSearch1.Name = "uc_WorkersSearch1";
            this.uc_WorkersSearch1.Size = new System.Drawing.Size(1488, 118);
            this.uc_WorkersSearch1.TabIndex = 4;
            this.uc_WorkersSearch1.Visible = false;
            // 
            // uc_ToursSearch1
            // 
            this.uc_ToursSearch1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_ToursSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uc_ToursSearch1.Location = new System.Drawing.Point(0, 0);
            this.uc_ToursSearch1.Margin = new System.Windows.Forms.Padding(6);
            this.uc_ToursSearch1.Name = "uc_ToursSearch1";
            this.uc_ToursSearch1.Size = new System.Drawing.Size(1488, 118);
            this.uc_ToursSearch1.TabIndex = 3;
            this.uc_ToursSearch1.Visible = false;
            // 
            // uc_RoomsSearch1
            // 
            this.uc_RoomsSearch1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_RoomsSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uc_RoomsSearch1.Location = new System.Drawing.Point(0, 0);
            this.uc_RoomsSearch1.Margin = new System.Windows.Forms.Padding(6);
            this.uc_RoomsSearch1.Name = "uc_RoomsSearch1";
            this.uc_RoomsSearch1.Size = new System.Drawing.Size(1488, 118);
            this.uc_RoomsSearch1.TabIndex = 2;
            this.uc_RoomsSearch1.Visible = false;
            // 
            // uc_ReservationSearch1
            // 
            this.uc_ReservationSearch1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_ReservationSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uc_ReservationSearch1.Location = new System.Drawing.Point(0, 0);
            this.uc_ReservationSearch1.Margin = new System.Windows.Forms.Padding(6);
            this.uc_ReservationSearch1.Name = "uc_ReservationSearch1";
            this.uc_ReservationSearch1.Size = new System.Drawing.Size(1488, 118);
            this.uc_ReservationSearch1.TabIndex = 1;
            this.uc_ReservationSearch1.Visible = false;
            // 
            // uc_CustomersSearch1
            // 
            this.uc_CustomersSearch1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_CustomersSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uc_CustomersSearch1.Location = new System.Drawing.Point(0, 0);
            this.uc_CustomersSearch1.Margin = new System.Windows.Forms.Padding(6);
            this.uc_CustomersSearch1.Name = "uc_CustomersSearch1";
            this.uc_CustomersSearch1.Size = new System.Drawing.Size(1488, 118);
            this.uc_CustomersSearch1.TabIndex = 0;
            this.uc_CustomersSearch1.Visible = false;
            // 
            // uc_WorkersADU1
            // 
            this.uc_WorkersADU1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_WorkersADU1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uc_WorkersADU1.Location = new System.Drawing.Point(0, 0);
            this.uc_WorkersADU1.Margin = new System.Windows.Forms.Padding(6);
            this.uc_WorkersADU1.Name = "uc_WorkersADU1";
            this.uc_WorkersADU1.Size = new System.Drawing.Size(1179, 171);
            this.uc_WorkersADU1.TabIndex = 4;
            this.uc_WorkersADU1.Visible = false;
            // 
            // uc_ToursADU1
            // 
            this.uc_ToursADU1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_ToursADU1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uc_ToursADU1.Location = new System.Drawing.Point(0, 0);
            this.uc_ToursADU1.Margin = new System.Windows.Forms.Padding(6);
            this.uc_ToursADU1.Name = "uc_ToursADU1";
            this.uc_ToursADU1.Size = new System.Drawing.Size(1179, 171);
            this.uc_ToursADU1.TabIndex = 3;
            this.uc_ToursADU1.Visible = false;
            // 
            // uc_RoomsADU1
            // 
            this.uc_RoomsADU1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_RoomsADU1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uc_RoomsADU1.Location = new System.Drawing.Point(0, 0);
            this.uc_RoomsADU1.Margin = new System.Windows.Forms.Padding(6);
            this.uc_RoomsADU1.Name = "uc_RoomsADU1";
            this.uc_RoomsADU1.Size = new System.Drawing.Size(1179, 171);
            this.uc_RoomsADU1.TabIndex = 2;
            this.uc_RoomsADU1.Visible = false;
            // 
            // uc_ReservationADU1
            // 
            this.uc_ReservationADU1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_ReservationADU1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uc_ReservationADU1.Location = new System.Drawing.Point(0, 0);
            this.uc_ReservationADU1.Margin = new System.Windows.Forms.Padding(6);
            this.uc_ReservationADU1.Name = "uc_ReservationADU1";
            this.uc_ReservationADU1.Size = new System.Drawing.Size(1179, 171);
            this.uc_ReservationADU1.TabIndex = 1;
            this.uc_ReservationADU1.Visible = false;
            // 
            // uc_CustomersADU1
            // 
            this.uc_CustomersADU1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_CustomersADU1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uc_CustomersADU1.Location = new System.Drawing.Point(0, 0);
            this.uc_CustomersADU1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uc_CustomersADU1.Name = "uc_CustomersADU1";
            this.uc_CustomersADU1.Size = new System.Drawing.Size(1179, 171);
            this.uc_CustomersADU1.TabIndex = 0;
            this.uc_CustomersADU1.Visible = false;
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
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxADU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_MainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.gbxADU.ResumeLayout(false);
            this.gbxADU.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_MainMenu;
        private System.Windows.Forms.Button btn_Rooms;
        private System.Windows.Forms.Button btn_Workers;
        private System.Windows.Forms.Button btn_Customers;
        private System.Windows.Forms.PictureBox pbx_Exit;
        private System.Windows.Forms.PictureBox pbx_Minimize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Reservations;
        private System.Windows.Forms.Button btn_Tours;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.GroupBox gbxADU;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox cbx_Operation;
        private System.Windows.Forms.Button btn_Okey;
        private System.Windows.Forms.Label lbl_Operation;
        private System.Windows.Forms.Panel pnlSearch;
        private UserControls.uc_WorkersSearch uc_WorkersSearch1;
        private UserControls.uc_ToursSearch uc_ToursSearch1;
        private UserControls.uc_RoomsSearch uc_RoomsSearch1;
        private UserControls.uc_ReservationSearch uc_ReservationSearch1;
        private UserControls.uc_CustomersSearch uc_CustomersSearch1;
        private UserControls.uc_WorkersADU uc_WorkersADU1;
        private UserControls.uc_ToursADU uc_ToursADU1;
        private UserControls.uc_RoomsADU uc_RoomsADU1;
        private UserControls.uc_ReservationADU uc_ReservationADU1;
        private UserControls.uc_CustomersADU uc_CustomersADU1;
    }
}