using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace DTO_QuanLy
{
    public class DTO_NhapThietBi
    {
        public int ID { get; set; }
        public int RequestID { get; set; }
        public string DeviceName { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public DateTime Date { get; set; }


        public DTO_NhapThietBi()
        {
        }

        public DTO_NhapThietBi(int iD, int requestID, string deviceName, int quantity, int unitPrice, DateTime date)
        {
            ID = iD;
            RequestID = requestID;
            DeviceName = deviceName;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Date = date;
        }

        public DTO_NhapThietBi(DataRow dr)
        {
            fromDatarow(dr);
        }

        public void fromDatarow(DataRow dr) {
            ID = Int32.Parse(dr["MaNhap"].ToString());
            RequestID = Int32.Parse(dr["MaYeuCau"].ToString());
            DeviceName = dr["TenThietBi"].ToString();
            Quantity = Int32.Parse(dr["SoLuong"].ToString());
            UnitPrice = Int32.Parse(dr["DonGia"].ToString());
            Date = Convert.ToDateTime(dr["NgayNhap"].ToString());
        }

    }
}
