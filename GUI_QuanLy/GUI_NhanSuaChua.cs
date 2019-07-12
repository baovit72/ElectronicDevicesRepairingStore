using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_NhanSuaChua : Form
    {
        BUS_KhachHang khachHangBUS = new BUS_KhachHang();
        BUS_NhanHieu nhanHieuBUS = new BUS_NhanHieu();
        BUS_ThietBiSuaChua thietbiBUS = new BUS_ThietBiSuaChua();
        BUS_YeuCauSuaChua yeucauBUS = new BUS_YeuCauSuaChua();

        List<DTO_KhachHang> khachHangs = new List<DTO_KhachHang>();
        List<DTO_NhanHieu> brands = new List<DTO_NhanHieu>();

        public GUI_NhanSuaChua()
        {
            InitializeComponent();

            khachHangs = khachHangBUS.getAllCustomers();
            brands = nhanHieuBUS.getAllBrands();


            cbKhachHang.Refresh();


            cbKhachHang.DataSource = khachHangBUS.getAllCustomerNames();
            cbBrand.DataSource = nhanHieuBUS.getAllBrandNames();


        }

        private void button1_Click(object sender, EventArgs e)
        {


            DTO_KhachHang khachHangDTO;

            //Tạo mới khách hàng
            khachHangDTO = new DTO_KhachHang();

            khachHangDTO.DiaChi = tbDiaChi.Text.TrimEnd().TrimStart();
            khachHangDTO.SDT = tbSDT.Text.Trim();
            khachHangDTO.HoTen = cbKhachHang.Text.TrimEnd().TrimStart();



            //Nếu khách hàng không có trong DB thì tiến hành thêm vào DB

            if (khachHangBUS.isDuplicate(khachHangDTO) == 0)
            {
                int nId = khachHangBUS.getNextCustomerId();
                khachHangDTO.ID = nId == -1 ? 1 : nId;
                khachHangBUS.insertCustomer(khachHangDTO);
            }
            else
            {
                khachHangs = khachHangBUS.getAllCustomers();
                foreach(DTO_KhachHang kh in khachHangs)
                {
                    if (kh.HoTen == khachHangDTO.HoTen && kh.SDT == khachHangDTO.SDT)
                    {
                        khachHangDTO = kh;
                        break;
                    }
                }
               
            }
            //Thêm thông tin nhãn hàng nếu không có
            DTO_NhanHieu nhanHieuDTO = new DTO_NhanHieu();
            nhanHieuDTO.Name = cbBrand.Text.TrimStart().TrimEnd();
            if (nhanHieuBUS.isDuplicate(nhanHieuDTO) == 0)
            {
                int newBrandId = nhanHieuBUS.getNextBrandId();
                nhanHieuDTO.ID =  newBrandId == -1?1:newBrandId;
                nhanHieuBUS.insertBrand(nhanHieuDTO);
            }

            else
            {
                brands = nhanHieuBUS.getAllBrands();
                foreach(DTO_NhanHieu brand in brands)
                {
                    if(brand.Name == nhanHieuDTO.Name)
                    {
                        nhanHieuDTO = brand;
                        break;
                    }
                }
                 
            }

            //Thêm thiết bị được sửa chữa
            DTO_ThietBiSuaChua thietBiDTO = new DTO_ThietBiSuaChua();
            thietBiDTO.Name = tbTenThietBi.Text;
            int nDeviceId = thietbiBUS.getNextDeviceId();
            thietBiDTO.ID = nDeviceId == -1 ? 1 : nDeviceId;
            thietBiDTO.Model = tbModel.Text;
            thietBiDTO.BrandID = nhanHieuDTO.ID;

            thietbiBUS.insertDevice(thietBiDTO);


            //Thêm thông tin yêu cầu
            DTO_YeuCauSuaChua yeuCauDTO = new DTO_YeuCauSuaChua();

            int newYeuCauID = yeucauBUS.getNextRequestId();
            yeuCauDTO.ID = newYeuCauID == -1 ? 1 : newYeuCauID;

            yeuCauDTO.MaKH = khachHangDTO.ID;
            yeuCauDTO.MaMonHang = thietBiDTO.ID;
            yeuCauDTO.NgayNhan = DateTime.Now;
            yeuCauDTO.SoLuong = Int32.Parse(tbQuantity.Text);
            yeuCauDTO.MoTaTinhTrang = tbMota.Text.TrimEnd().TrimStart();
            yeuCauDTO.ChiTiet = tbGhiChu.Text.TrimEnd().TrimStart();
            yeuCauDTO.DaSuaChua = 0;

            yeucauBUS.insertRequest(yeuCauDTO);



            dataGridView1.Refresh();
            dataGridView1.DataSource = yeucauBUS.getAllRequests();

            
            //cbKhachHang.DataSource = khachHangBUS.getAllCustomerNames();
            //cbBrand.DataSource = nhanHieuBUS.getAllBrandNames();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhachHang.SelectedIndex == -1)
                return;
            tbDiaChi.Text = khachHangs[cbKhachHang.SelectedIndex].DiaChi;
            tbSDT.Text = khachHangs[cbKhachHang.SelectedIndex].SDT;
        }

        private void tbDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTenThietBi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
