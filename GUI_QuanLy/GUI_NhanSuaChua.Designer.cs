namespace GUI_QuanLy
{
    partial class GUI_NhanSuaChua
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTenThietBi = new System.Windows.Forms.TextBox();
            this.tbMota = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.lbTenThietBi = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lbMota = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 466);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1003, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(579, 45);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(387, 20);
            this.tbDiaChi.TabIndex = 1;
            this.tbDiaChi.TextChanged += new System.EventHandler(this.tbDiaChi_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(858, 665);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(160, 56);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(249, 21);
            this.cbKhachHang.TabIndex = 3;
            this.cbKhachHang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(33, 59);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(99, 13);
            this.lbHoTen.TabIndex = 4;
            this.lbHoTen.Text = "Họ tên khách hàng";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(469, 48);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lbDiaChi.TabIndex = 5;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.lbSDT);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(148, 99);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(249, 20);
            this.tbSDT.TabIndex = 3;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(21, 99);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(70, 13);
            this.lbSDT.TabIndex = 2;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbBrand);
            this.groupBox2.Controls.Add(this.lbGhiChu);
            this.groupBox2.Controls.Add(this.lbMota);
            this.groupBox2.Controls.Add(this.tbQuantity);
            this.groupBox2.Controls.Add(this.lbQuantity);
            this.groupBox2.Controls.Add(this.lbBrand);
            this.groupBox2.Controls.Add(this.lbModel);
            this.groupBox2.Controls.Add(this.lbTenThietBi);
            this.groupBox2.Controls.Add(this.tbGhiChu);
            this.groupBox2.Controls.Add(this.tbModel);
            this.groupBox2.Controls.Add(this.tbMota);
            this.groupBox2.Controls.Add(this.tbTenThietBi);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(979, 255);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yêu cầu sửa chữa";
            // 
            // tbTenThietBi
            // 
            this.tbTenThietBi.Location = new System.Drawing.Point(148, 19);
            this.tbTenThietBi.Name = "tbTenThietBi";
            this.tbTenThietBi.Size = new System.Drawing.Size(249, 20);
            this.tbTenThietBi.TabIndex = 0;
            this.tbTenThietBi.TextChanged += new System.EventHandler(this.tbTenThietBi_TextChanged);
            // 
            // tbMota
            // 
            this.tbMota.Location = new System.Drawing.Point(579, 19);
            this.tbMota.MaxLength = 300;
            this.tbMota.Multiline = true;
            this.tbMota.Name = "tbMota";
            this.tbMota.Size = new System.Drawing.Size(387, 107);
            this.tbMota.TabIndex = 1;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(148, 72);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(164, 20);
            this.tbModel.TabIndex = 3;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(579, 179);
            this.tbGhiChu.MaxLength = 100;
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(387, 56);
            this.tbGhiChu.TabIndex = 4;
            // 
            // lbTenThietBi
            // 
            this.lbTenThietBi.AutoSize = true;
            this.lbTenThietBi.Location = new System.Drawing.Point(27, 26);
            this.lbTenThietBi.Name = "lbTenThietBi";
            this.lbTenThietBi.Size = new System.Drawing.Size(60, 13);
            this.lbTenThietBi.TabIndex = 5;
            this.lbTenThietBi.Text = "Tên thiết bị";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(27, 79);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(36, 13);
            this.lbModel.TabIndex = 6;
            this.lbModel.Text = "Model";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Location = new System.Drawing.Point(27, 133);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(56, 13);
            this.lbBrand.TabIndex = 7;
            this.lbBrand.Text = "Nhãn hiệu";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(30, 195);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(49, 13);
            this.lbQuantity.TabIndex = 8;
            this.lbQuantity.Text = "Số lượng";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(148, 192);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(164, 20);
            this.tbQuantity.TabIndex = 9;
            // 
            // lbMota
            // 
            this.lbMota.AutoSize = true;
            this.lbMota.Location = new System.Drawing.Point(469, 26);
            this.lbMota.Name = "lbMota";
            this.lbMota.Size = new System.Drawing.Size(81, 13);
            this.lbMota.TabIndex = 10;
            this.lbMota.Text = "Mô tả tình trạng";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(469, 179);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(44, 13);
            this.lbGhiChu.TabIndex = 11;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // cbBrand
            // 
            this.cbBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(148, 125);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(164, 21);
            this.cbBrand.TabIndex = 12;
            // 
            // GUI_NhanSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 710);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_NhanSuaChua";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTenThietBi;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbMota;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbTenThietBi;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbMota;
    }
}

