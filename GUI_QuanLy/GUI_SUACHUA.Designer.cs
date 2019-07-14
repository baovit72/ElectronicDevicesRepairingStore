namespace GUI_QuanLy
{
    partial class GUI_SuaChua
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
            this.listRequest = new System.Windows.Forms.ListBox();
            this.lbRequest = new System.Windows.Forms.Label();
            this.cbOptRepair = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbCusname = new System.Windows.Forms.TextBox();
            this.lbcusname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbRequestInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDevice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoveDevice = new System.Windows.Forms.Button();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.listDevices = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbRepairInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listRequest
            // 
            this.listRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRequest.FormattingEnabled = true;
            this.listRequest.ItemHeight = 20;
            this.listRequest.Location = new System.Drawing.Point(17, 123);
            this.listRequest.Name = "listRequest";
            this.listRequest.Size = new System.Drawing.Size(273, 424);
            this.listRequest.TabIndex = 0;
            this.listRequest.SelectedIndexChanged += new System.EventHandler(this.listRequest_SelectedIndexChanged);
            this.listRequest.DoubleClick += new System.EventHandler(this.listRequest_DoubleClick);
            // 
            // lbRequest
            // 
            this.lbRequest.AutoSize = true;
            this.lbRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequest.Location = new System.Drawing.Point(12, 19);
            this.lbRequest.Name = "lbRequest";
            this.lbRequest.Size = new System.Drawing.Size(258, 25);
            this.lbRequest.TabIndex = 1;
            this.lbRequest.Text = "Danh sách các yêu cầu";
            // 
            // cbOptRepair
            // 
            this.cbOptRepair.AutoSize = true;
            this.cbOptRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOptRepair.Location = new System.Drawing.Point(17, 83);
            this.cbOptRepair.Name = "cbOptRepair";
            this.cbOptRepair.Size = new System.Drawing.Size(261, 24);
            this.cbOptRepair.TabIndex = 2;
            this.cbOptRepair.Text = "Hiển thị các yêu cầu đã sửa chữa";
            this.cbOptRepair.UseVisualStyleBackColor = true;
            this.cbOptRepair.CheckedChanged += new System.EventHandler(this.cbOptRepair_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.lbDiachi);
            this.groupBox1.Controls.Add(this.tbPhoneNum);
            this.groupBox1.Controls.Add(this.lbPhone);
            this.groupBox1.Controls.Add(this.tbCusname);
            this.groupBox1.Controls.Add(this.lbcusname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(352, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 103);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(135, 72);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(527, 26);
            this.tbAddress.TabIndex = 5;
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Location = new System.Drawing.Point(41, 78);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(57, 20);
            this.lbDiachi.TabIndex = 4;
            this.lbDiachi.Text = "Địa chỉ";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(485, 38);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.ReadOnly = true;
            this.tbPhoneNum.Size = new System.Drawing.Size(177, 26);
            this.tbPhoneNum.TabIndex = 3;
            this.tbPhoneNum.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(361, 44);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(102, 20);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Số điện thoại";
            this.lbPhone.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbCusname
            // 
            this.tbCusname.Location = new System.Drawing.Point(135, 38);
            this.tbCusname.Name = "tbCusname";
            this.tbCusname.ReadOnly = true;
            this.tbCusname.Size = new System.Drawing.Size(177, 26);
            this.tbCusname.TabIndex = 1;
            // 
            // lbcusname
            // 
            this.lbcusname.AutoSize = true;
            this.lbcusname.Location = new System.Drawing.Point(38, 44);
            this.lbcusname.Name = "lbcusname";
            this.lbcusname.Size = new System.Drawing.Size(36, 20);
            this.lbcusname.TabIndex = 0;
            this.lbcusname.Text = "Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbRequestInfo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbDevice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(352, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 154);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin yêu cầu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbRequestInfo
            // 
            this.tbRequestInfo.Location = new System.Drawing.Point(137, 67);
            this.tbRequestInfo.Multiline = true;
            this.tbRequestInfo.Name = "tbRequestInfo";
            this.tbRequestInfo.ReadOnly = true;
            this.tbRequestInfo.Size = new System.Drawing.Size(527, 75);
            this.tbRequestInfo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chi tiết";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbDevice
            // 
            this.tbDevice.Location = new System.Drawing.Point(137, 34);
            this.tbDevice.Name = "tbDevice";
            this.tbDevice.ReadOnly = true;
            this.tbDevice.Size = new System.Drawing.Size(527, 26);
            this.tbDevice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thiết bị";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoveDevice);
            this.groupBox3.Controls.Add(this.btnAddDevice);
            this.groupBox3.Controls.Add(this.listDevices);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(352, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 141);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách thiết bị nhập";
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.Location = new System.Drawing.Point(24, 97);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(75, 32);
            this.btnRemoveDevice.TabIndex = 2;
            this.btnRemoveDevice.Text = "Xoá";
            this.btnRemoveDevice.UseVisualStyleBackColor = true;
            this.btnRemoveDevice.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Location = new System.Drawing.Point(26, 35);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(75, 36);
            this.btnAddDevice.TabIndex = 1;
            this.btnAddDevice.Text = "Thêm";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // listDevices
            // 
            this.listDevices.FormattingEnabled = true;
            this.listDevices.ItemHeight = 20;
            this.listDevices.Location = new System.Drawing.Point(135, 25);
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(249, 104);
            this.listDevices.TabIndex = 0;
            this.listDevices.SelectedIndexChanged += new System.EventHandler(this.listDevices_SelectedIndexChanged);
            this.listDevices.DoubleClick += new System.EventHandler(this.listDevices_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.tbRepairInfo);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbWage);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(352, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(692, 142);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin sửa chữa";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(597, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 86);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbRepairInfo
            // 
            this.tbRepairInfo.Location = new System.Drawing.Point(135, 71);
            this.tbRepairInfo.Multiline = true;
            this.tbRepairInfo.Name = "tbRepairInfo";
            this.tbRepairInfo.Size = new System.Drawing.Size(456, 54);
            this.tbRepairInfo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chi tiết";
            // 
            // tbWage
            // 
            this.tbWage.Location = new System.Drawing.Point(135, 39);
            this.tbWage.MaxLength = 8;
            this.tbWage.Name = "tbWage";
            this.tbWage.Size = new System.Drawing.Size(456, 26);
            this.tbWage.TabIndex = 5;
            this.tbWage.TextChanged += new System.EventHandler(this.tbWage_TextChanged);
            this.tbWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWage_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiền công";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Maroon;
            this.lbStatus.Location = new System.Drawing.Point(762, 474);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(138, 29);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.Text = "Tình trạng:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lbTotal.Location = new System.Drawing.Point(762, 549);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(131, 29);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "Tổng tiền:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 139);
            this.button2.TabIndex = 9;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 145);
            this.button3.TabIndex = 10;
            this.button3.Text = "Xoá";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(296, 420);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 127);
            this.button4.TabIndex = 11;
            this.button4.Text = "Xuất hoá đơn";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // GUI_SuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1094, 607);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbOptRepair);
            this.Controls.Add(this.lbRequest);
            this.Controls.Add(this.listRequest);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI_SuaChua";
            this.Text = "GUI_SUACHUA";
            this.Load += new System.EventHandler(this.GUI_SuaChua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listRequest;
        private System.Windows.Forms.Label lbRequest;
        private System.Windows.Forms.CheckBox cbOptRepair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbCusname;
        private System.Windows.Forms.Label lbcusname;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.TextBox tbDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRequestInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRemoveDevice;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.ListBox listDevices;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbRepairInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}