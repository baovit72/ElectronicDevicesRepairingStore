using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO_QuanLy
{
    public class DTO_KhachHang
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        public DTO_KhachHang()
        {
        }

        public DTO_KhachHang(int iD, string hoTen, string sDT, string diaChi)
        {
            ID = iD;
            HoTen = hoTen;
            SDT = sDT;
            DiaChi = diaChi;
        }
        public DTO_KhachHang(DataRow dr)
        {
            fromDatarow(dr);
        }

        public void fromDatarow(DataRow dr)
        {
            ID = Int32.Parse(dr["MaKhachHang"].ToString());
            HoTen = dr["HoTen"].ToString();
            DiaChi = dr["DiaChi"].ToString();
            SDT = dr["SoDienThoai"].ToString();
        }

    }
}
