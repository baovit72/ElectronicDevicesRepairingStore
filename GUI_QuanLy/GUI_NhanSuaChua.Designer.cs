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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_NhanSuaChua));
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbMota = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbTenThietBi = new System.Windows.Forms.Label();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbMota = new System.Windows.Forms.TextBox();
            this.tbTenThietBi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(172, 102);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(848, 35);
            this.tbDiaChi.TabIndex = 1;
            this.tbDiaChi.TextChanged += new System.EventHandler(this.tbDiaChi_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(172, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(734, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "GHI THÔNG TIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(172, 45);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(249, 37);
            this.cbKhachHang.TabIndex = 3;
            this.cbKhachHang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(33, 59);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(83, 29);
            this.lbHoTen.TabIndex = 4;
            this.lbHoTen.Text = "Họ tên";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(25, 108);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(86, 29);
            this.lbDiaChi.TabIndex = 5;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.cbKhachHang);
            this.groupBox1.Controls.Add(this.lbSDT);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(633, 37);
            this.tbSDT.MaxLength = 15;
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(387, 35);
            this.tbSDT.TabIndex = 3;
            this.tbSDT.TextChanged += new System.EventHandler(this.tbSDT_TextChanged);
            this.tbSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSDT_KeyPress);
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(461, 47);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(154, 29);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1038, 284);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yêu cầu sửa chữa";
            // 
            // cbBrand
            // 
            this.cbBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(172, 162);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(164, 37);
            this.cbBrand.TabIndex = 12;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(461, 179);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(94, 29);
            this.lbGhiChu.TabIndex = 11;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // lbMota
            // 
            this.lbMota.AutoSize = true;
            this.lbMota.Location = new System.Drawing.Point(451, 54);
            this.lbMota.Name = "lbMota";
            this.lbMota.Size = new System.Drawing.Size(176, 29);
            this.lbMota.TabIndex = 10;
            this.lbMota.Text = "Mô tả tình trạng";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(172, 221);
            this.tbQuantity.MaxLength = 2;
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(164, 35);
            this.tbQuantity.TabIndex = 9;
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantity_KeyPress);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(30, 221);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(109, 29);
            this.lbQuantity.TabIndex = 8;
            this.lbQuantity.Text = "Số lượng";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Location = new System.Drawing.Point(30, 165);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(122, 29);
            this.lbBrand.TabIndex = 7;
            this.lbBrand.Text = "Nhãn hiệu";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(30, 112);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(81, 29);
            this.lbModel.TabIndex = 6;
            this.lbModel.Text = "Model";
            // 
            // lbTenThietBi
            // 
            this.lbTenThietBi.AutoSize = true;
            this.lbTenThietBi.Location = new System.Drawing.Point(30, 51);
            this.lbTenThietBi.Name = "lbTenThietBi";
            this.lbTenThietBi.Size = new System.Drawing.Size(133, 29);
            this.lbTenThietBi.TabIndex = 5;
            this.lbTenThietBi.Text = "Tên thiết bị";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(633, 179);
            this.tbGhiChu.MaxLength = 100;
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(387, 56);
            this.tbGhiChu.TabIndex = 4;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(172, 106);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(164, 35);
            this.tbModel.TabIndex = 3;
            // 
            // tbMota
            // 
            this.tbMota.Location = new System.Drawing.Point(633, 48);
            this.tbMota.MaxLength = 300;
            this.tbMota.Multiline = true;
            this.tbMota.Name = "tbMota";
            this.tbMota.Size = new System.Drawing.Size(387, 107);
            this.tbMota.TabIndex = 1;
            // 
            // tbTenThietBi
            // 
            this.tbTenThietBi.Location = new System.Drawing.Point(172, 48);
            this.tbTenThietBi.Name = "tbTenThietBi";
            this.tbTenThietBi.Size = new System.Drawing.Size(249, 35);
            this.tbTenThietBi.TabIndex = 0;
            this.tbTenThietBi.TextChanged += new System.EventHandler(this.tbTenThietBi_TextChanged);
            // 
            // GUI_NhanSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1062, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI_NhanSuaChua";
            this.Text = "Nhận sửa chữa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GUI_NhanSuaChua_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbKhachHang;
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

