namespace Main.UserControls
{
    partial class uc_Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbx_Search = new System.Windows.Forms.GroupBox();
            this.cbx_SearchIsAdult = new System.Windows.Forms.ComboBox();
            this.tbx_SearchName = new System.Windows.Forms.TextBox();
            this.lbl_SearchIsAdult = new System.Windows.Forms.Label();
            this.lbl_SearchName = new System.Windows.Forms.Label();
            this.gbx_ADU = new System.Windows.Forms.GroupBox();
            this.lbl_Operation = new System.Windows.Forms.Label();
            this.cbx_Operation = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Okey = new System.Windows.Forms.Button();
            this.cbx_IsAdult = new System.Windows.Forms.ComboBox();
            this.tbx_TourId = new System.Windows.Forms.TextBox();
            this.lbl_TourId = new System.Windows.Forms.Label();
            this.tbx_RoomNo = new System.Windows.Forms.TextBox();
            this.lbl_RoomNo = new System.Windows.Forms.Label();
            this.tbx_PhoneNo = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_IsAdult = new System.Windows.Forms.Label();
            this.tbx_TcNo = new System.Windows.Forms.TextBox();
            this.lbl_TcNo = new System.Windows.Forms.Label();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.dgw_Customers = new System.Windows.Forms.DataGridView();
            this.gbx_Search.SuspendLayout();
            this.gbx_ADU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_Search
            // 
            this.gbx_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbx_Search.Controls.Add(this.cbx_SearchIsAdult);
            this.gbx_Search.Controls.Add(this.tbx_SearchName);
            this.gbx_Search.Controls.Add(this.lbl_SearchIsAdult);
            this.gbx_Search.Controls.Add(this.lbl_SearchName);
            this.gbx_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbx_Search.Location = new System.Drawing.Point(3, 3);
            this.gbx_Search.Name = "gbx_Search";
            this.gbx_Search.Size = new System.Drawing.Size(1500, 154);
            this.gbx_Search.TabIndex = 0;
            this.gbx_Search.TabStop = false;
            this.gbx_Search.Text = "Ara";
            // 
            // cbx_SearchIsAdult
            // 
            this.cbx_SearchIsAdult.FormattingEnabled = true;
            this.cbx_SearchIsAdult.Location = new System.Drawing.Point(743, 74);
            this.cbx_SearchIsAdult.Name = "cbx_SearchIsAdult";
            this.cbx_SearchIsAdult.Size = new System.Drawing.Size(410, 33);
            this.cbx_SearchIsAdult.TabIndex = 12;
            this.cbx_SearchIsAdult.SelectedIndexChanged += new System.EventHandler(this.cbx_SearchIsAdult_SelectedIndexChanged);
            // 
            // tbx_SearchName
            // 
            this.tbx_SearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_SearchName.Location = new System.Drawing.Point(106, 77);
            this.tbx_SearchName.Margin = new System.Windows.Forms.Padding(6);
            this.tbx_SearchName.Name = "tbx_SearchName";
            this.tbx_SearchName.Size = new System.Drawing.Size(450, 31);
            this.tbx_SearchName.TabIndex = 9;
            this.tbx_SearchName.TextChanged += new System.EventHandler(this.tbx_SearchName_TextChanged);
            // 
            // lbl_SearchIsAdult
            // 
            this.lbl_SearchIsAdult.AutoSize = true;
            this.lbl_SearchIsAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SearchIsAdult.Location = new System.Drawing.Point(738, 46);
            this.lbl_SearchIsAdult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_SearchIsAdult.Name = "lbl_SearchIsAdult";
            this.lbl_SearchIsAdult.Size = new System.Drawing.Size(95, 25);
            this.lbl_SearchIsAdult.TabIndex = 11;
            this.lbl_SearchIsAdult.Text = "Yetişkin:";
            // 
            // lbl_SearchName
            // 
            this.lbl_SearchName.AutoSize = true;
            this.lbl_SearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SearchName.Location = new System.Drawing.Point(101, 46);
            this.lbl_SearchName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_SearchName.Name = "lbl_SearchName";
            this.lbl_SearchName.Size = new System.Drawing.Size(56, 25);
            this.lbl_SearchName.TabIndex = 8;
            this.lbl_SearchName.Text = "İsim:";
            // 
            // gbx_ADU
            // 
            this.gbx_ADU.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbx_ADU.Controls.Add(this.lbl_Operation);
            this.gbx_ADU.Controls.Add(this.cbx_Operation);
            this.gbx_ADU.Controls.Add(this.btn_Clear);
            this.gbx_ADU.Controls.Add(this.btn_Okey);
            this.gbx_ADU.Controls.Add(this.cbx_IsAdult);
            this.gbx_ADU.Controls.Add(this.tbx_TourId);
            this.gbx_ADU.Controls.Add(this.lbl_TourId);
            this.gbx_ADU.Controls.Add(this.tbx_RoomNo);
            this.gbx_ADU.Controls.Add(this.lbl_RoomNo);
            this.gbx_ADU.Controls.Add(this.tbx_PhoneNo);
            this.gbx_ADU.Controls.Add(this.lbl_Phone);
            this.gbx_ADU.Controls.Add(this.lbl_IsAdult);
            this.gbx_ADU.Controls.Add(this.tbx_TcNo);
            this.gbx_ADU.Controls.Add(this.lbl_TcNo);
            this.gbx_ADU.Controls.Add(this.tbx_Name);
            this.gbx_ADU.Controls.Add(this.lbl_Name);
            this.gbx_ADU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbx_ADU.Location = new System.Drawing.Point(3, 532);
            this.gbx_ADU.Name = "gbx_ADU";
            this.gbx_ADU.Size = new System.Drawing.Size(1500, 207);
            this.gbx_ADU.TabIndex = 2;
            this.gbx_ADU.TabStop = false;
            this.gbx_ADU.Text = "Ekle/Sil/Güncelle";
            this.gbx_ADU.Visible = false;
            // 
            // lbl_Operation
            // 
            this.lbl_Operation.AutoSize = true;
            this.lbl_Operation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Operation.ForeColor = System.Drawing.Color.Black;
            this.lbl_Operation.Location = new System.Drawing.Point(42, 65);
            this.lbl_Operation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Operation.Name = "lbl_Operation";
            this.lbl_Operation.Size = new System.Drawing.Size(57, 20);
            this.lbl_Operation.TabIndex = 28;
            this.lbl_Operation.Text = "İşlem:";
            // 
            // cbx_Operation
            // 
            this.cbx_Operation.BackColor = System.Drawing.Color.Brown;
            this.cbx_Operation.FormattingEnabled = true;
            this.cbx_Operation.Location = new System.Drawing.Point(46, 88);
            this.cbx_Operation.Name = "cbx_Operation";
            this.cbx_Operation.Size = new System.Drawing.Size(158, 33);
            this.cbx_Operation.TabIndex = 30;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Brown;
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(1209, 170);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(125, 35);
            this.btn_Clear.TabIndex = 31;
            this.btn_Clear.Text = "Temizle";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Okey
            // 
            this.btn_Okey.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Okey.ForeColor = System.Drawing.Color.White;
            this.btn_Okey.Location = new System.Drawing.Point(1375, 170);
            this.btn_Okey.Name = "btn_Okey";
            this.btn_Okey.Size = new System.Drawing.Size(125, 35);
            this.btn_Okey.TabIndex = 29;
            this.btn_Okey.Text = "Onay";
            this.btn_Okey.UseVisualStyleBackColor = false;
            this.btn_Okey.Click += new System.EventHandler(this.btn_Okey_Click);
            // 
            // cbx_IsAdult
            // 
            this.cbx_IsAdult.FormattingEnabled = true;
            this.cbx_IsAdult.Location = new System.Drawing.Point(873, 53);
            this.cbx_IsAdult.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_IsAdult.Name = "cbx_IsAdult";
            this.cbx_IsAdult.Size = new System.Drawing.Size(196, 33);
            this.cbx_IsAdult.TabIndex = 27;
            // 
            // tbx_TourId
            // 
            this.tbx_TourId.Location = new System.Drawing.Point(1262, 120);
            this.tbx_TourId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_TourId.Name = "tbx_TourId";
            this.tbx_TourId.Size = new System.Drawing.Size(196, 31);
            this.tbx_TourId.TabIndex = 26;
            // 
            // lbl_TourId
            // 
            this.lbl_TourId.AutoSize = true;
            this.lbl_TourId.Location = new System.Drawing.Point(1152, 123);
            this.lbl_TourId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TourId.Name = "lbl_TourId";
            this.lbl_TourId.Size = new System.Drawing.Size(73, 25);
            this.lbl_TourId.TabIndex = 25;
            this.lbl_TourId.Text = "Tur Id:";
            // 
            // tbx_RoomNo
            // 
            this.tbx_RoomNo.Location = new System.Drawing.Point(1262, 54);
            this.tbx_RoomNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_RoomNo.Name = "tbx_RoomNo";
            this.tbx_RoomNo.Size = new System.Drawing.Size(196, 31);
            this.tbx_RoomNo.TabIndex = 24;
            // 
            // lbl_RoomNo
            // 
            this.lbl_RoomNo.AutoSize = true;
            this.lbl_RoomNo.Location = new System.Drawing.Point(1152, 58);
            this.lbl_RoomNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_RoomNo.Name = "lbl_RoomNo";
            this.lbl_RoomNo.Size = new System.Drawing.Size(91, 25);
            this.lbl_RoomNo.TabIndex = 23;
            this.lbl_RoomNo.Text = "Oda No:";
            // 
            // tbx_PhoneNo
            // 
            this.tbx_PhoneNo.Location = new System.Drawing.Point(873, 120);
            this.tbx_PhoneNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_PhoneNo.Name = "tbx_PhoneNo";
            this.tbx_PhoneNo.Size = new System.Drawing.Size(196, 31);
            this.tbx_PhoneNo.TabIndex = 22;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(776, 123);
            this.lbl_Phone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(90, 25);
            this.lbl_Phone.TabIndex = 21;
            this.lbl_Phone.Text = "Telefon:";
            // 
            // lbl_IsAdult
            // 
            this.lbl_IsAdult.AutoSize = true;
            this.lbl_IsAdult.Location = new System.Drawing.Point(776, 56);
            this.lbl_IsAdult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_IsAdult.Name = "lbl_IsAdult";
            this.lbl_IsAdult.Size = new System.Drawing.Size(95, 25);
            this.lbl_IsAdult.TabIndex = 20;
            this.lbl_IsAdult.Text = "Yetişkin:";
            // 
            // tbx_TcNo
            // 
            this.tbx_TcNo.Location = new System.Drawing.Point(484, 120);
            this.tbx_TcNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_TcNo.Name = "tbx_TcNo";
            this.tbx_TcNo.Size = new System.Drawing.Size(196, 31);
            this.tbx_TcNo.TabIndex = 19;
            // 
            // lbl_TcNo
            // 
            this.lbl_TcNo.AutoSize = true;
            this.lbl_TcNo.Location = new System.Drawing.Point(385, 124);
            this.lbl_TcNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TcNo.Name = "lbl_TcNo";
            this.lbl_TcNo.Size = new System.Drawing.Size(69, 25);
            this.lbl_TcNo.TabIndex = 18;
            this.lbl_TcNo.Text = "TcNo:";
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(484, 53);
            this.tbx_Name.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(196, 31);
            this.tbx_Name.TabIndex = 17;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(385, 59);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(56, 25);
            this.lbl_Name.TabIndex = 16;
            this.lbl_Name.Text = "İsim:";
            // 
            // dgw_Customers
            // 
            this.dgw_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Customers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgw_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_Customers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_Customers.Location = new System.Drawing.Point(3, 163);
            this.dgw_Customers.Name = "dgw_Customers";
            this.dgw_Customers.ReadOnly = true;
            this.dgw_Customers.RowHeadersWidth = 50;
            this.dgw_Customers.Size = new System.Drawing.Size(1500, 363);
            this.dgw_Customers.TabIndex = 3;
            this.dgw_Customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Customers_CellClick);
            // 
            // uc_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dgw_Customers);
            this.Controls.Add(this.gbx_ADU);
            this.Controls.Add(this.gbx_Search);
            this.Name = "uc_Customer";
            this.Size = new System.Drawing.Size(1506, 744);
            this.Load += new System.EventHandler(this.uc_Customer_Load);
            this.gbx_Search.ResumeLayout(false);
            this.gbx_Search.PerformLayout();
            this.gbx_ADU.ResumeLayout(false);
            this.gbx_ADU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Search;
        private System.Windows.Forms.TextBox tbx_SearchName;
        private System.Windows.Forms.Label lbl_SearchIsAdult;
        private System.Windows.Forms.Label lbl_SearchName;
        private System.Windows.Forms.GroupBox gbx_ADU;
        private System.Windows.Forms.ComboBox cbx_IsAdult;
        private System.Windows.Forms.TextBox tbx_TourId;
        private System.Windows.Forms.Label lbl_TourId;
        private System.Windows.Forms.TextBox tbx_RoomNo;
        private System.Windows.Forms.Label lbl_RoomNo;
        private System.Windows.Forms.TextBox tbx_PhoneNo;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_IsAdult;
        private System.Windows.Forms.TextBox tbx_TcNo;
        private System.Windows.Forms.Label lbl_TcNo;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Operation;
        private System.Windows.Forms.ComboBox cbx_Operation;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Okey;
        private System.Windows.Forms.ComboBox cbx_SearchIsAdult;
        private System.Windows.Forms.DataGridView dgw_Customers;
    }
}
