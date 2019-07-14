using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_NhapThietBi : Form
    {
        BUS_NhapThietBi nhapBUS;
        Form parent;
        DTO_HoaDon hoadonDTO;

        public GUI_NhapThietBi()
        {
            InitializeComponent();
            nhapBUS = new BUS_NhapThietBi();
        }

        public GUI_NhapThietBi(Form p, DTO_HoaDon request)
        {
            InitializeComponent();
            parent = p;
            hoadonDTO = request;

            nhapBUS = new BUS_NhapThietBi();

        }

        private void lbDeviceName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_NhapThietBi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(tbDeviceName.Text == "" || tbPrice.Text == "" || tbQuantity.Text == ""))
            {
                try
                {
                    //Tạo đối tượng DTO Nhập thiết bị
                    DTO_NhapThietBi nhapDTO;
                    nhapDTO = new DTO_NhapThietBi();
                    nhapDTO.Date = DateTime.Now;
                    nhapDTO.DeviceName = tbDeviceName.Text;
                    nhapDTO.Quantity = Int32.Parse(tbQuantity.Text);
                    nhapDTO.UnitPrice = Int32.Parse(tbPrice.Text);
                    nhapDTO.ID = nhapBUS.getNextBoughtDeviceId();
                    nhapDTO.RequestID = hoadonDTO.ID;

                    nhapBUS.insertBoughtDevice(nhapDTO);
                    ((GUI_SuaChua)parent).ReloadBoughtDevicesList();
                    MessageBox.Show("Ghi thông tin thành công !!!!!!!!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Kiểm tra lại thông tin nhập !!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin !!!!!!!!!!!");
            }


        }


        private void updateTotalPrice(object sender, EventArgs e)
        {
            if (tbPrice.Text != "" && tbQuantity.Text != "")
                tbTotal.Text = (Int64.Parse(tbPrice.Text) * Int64.Parse(tbQuantity.Text)).ToString();
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            GUIUtility.HandleDigitTextBox(sender, ref e);
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            GUIUtility.HandleDigitTextBox(sender, ref e);
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
