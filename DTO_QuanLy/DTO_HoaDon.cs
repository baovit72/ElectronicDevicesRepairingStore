using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace DTO_QuanLy
{
    public class DTO_HoaDon
    {
        public int ID { get; set; } // Đây là mã yêu cầu
        public string DeviceName { get; set; }
        public DateTime Date { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int IsRepaired { get; set; }
        public int Quantity { get; set; }
        public string ProblemDescription { get; set; }
        public string Note { get; set; }
        public int Wage { get; set; }
        public string AssertedProblem { get; set; }
        public List<DTO_NhapThietBi> BoughtDevices;

        public DTO_HoaDon()
        {

        }

        public DTO_HoaDon(int iD, string deviceName, DateTime date, string brandName, string model, string customerName, string phoneNumber, string address, int isRepaired, int quantity, string problemDescription, string note, int wage, string assertedProblem, List<DTO_NhapThietBi> boughtDevices)
        {
            ID = iD;
            DeviceName = deviceName;
            Date = date;
            BrandName = brandName;
            Model = model;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            Address = address;
            IsRepaired = isRepaired;
            Quantity = quantity;
            ProblemDescription = problemDescription;
            Note = note;
            Wage = wage;
            AssertedProblem = assertedProblem;
            BoughtDevices = boughtDevices;
        }

        public void fromDatarow(DataRow dr)
        {
            ID = Int32.Parse(dr["MaYeuCau"].ToString());
            DeviceName = dr["TenThietBi"].ToString();
            Date = Convert.ToDateTime(dr["NgayNhan"].ToString());
            BrandName = dr["TenNhanHieu"].ToString();
            Model = dr["Model"].ToString();
            CustomerName = dr["HoTen"].ToString();
            PhoneNumber = dr["SoDienThoai"].ToString();
            Address = dr["DiaChi"].ToString();
            IsRepaired = Int32.Parse(dr["DaSuaChua"].ToString());
            Quantity = Int32.Parse(dr["SoLuong"].ToString());
            ProblemDescription = dr["MoTaTinhTrang"].ToString();
            Note = dr["ChiTiet"].ToString();
            Wage = dr["TienCong"] == DBNull.Value ? -1 : Int32.Parse(dr["TienCong"].ToString());
            AssertedProblem = dr["MoTaLoi"].ToString();

        }

        public DTO_HoaDon(DataRow dr)
        {
            fromDatarow(dr);
        }

    }
}
