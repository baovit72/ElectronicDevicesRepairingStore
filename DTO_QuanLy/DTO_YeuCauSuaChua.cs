using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace DTO_QuanLy
{
    public class DTO_YeuCauSuaChua
    {
        public int ID { get; set; }
        public int MaKH { get; set; }
        public DateTime NgayNhan { get; set; }
        public int MaMonHang { get; set; }
        public int SoLuong { get; set; }
        public string MoTaTinhTrang { get; set; }
        public int DaSuaChua { get; set; }
        public string ChiTiet { get; set; }
        public DTO_YeuCauSuaChua()
        {

        }
        public DTO_YeuCauSuaChua(int id, int customerId, DateTime date, int goodId, int quantity, string problem, int isRepaired, string chiTiet)
        {
            ID = id;
            MaKH = customerId;
            NgayNhan = date;
            MaMonHang = goodId;
            SoLuong = quantity;
            MoTaTinhTrang = problem;
            DaSuaChua = isRepaired;
            ChiTiet = chiTiet;
        }

        public DTO_YeuCauSuaChua(DataRow dr)
        {
            fromDatarow(dr);
        }

        public void fromDatarow(DataRow dr)
        {
            ID = Int32.Parse(dr["MaYeuCau"].ToString());
            MaKH = Int32.Parse(dr["MaKH"].ToString());
            NgayNhan = Convert.ToDateTime(dr["NgayNhan"].ToString());
            MaMonHang = Int32.Parse(dr["MaMonHang"].ToString());
            SoLuong = Int32.Parse(dr["SoLuong"].ToString());
            MoTaTinhTrang = dr["MoTaTinhTrang"].ToString();
            DaSuaChua = Int32.Parse(dr["DaSuaChua"].ToString());
            ChiTiet = dr["ChiTiet"].ToString();
        }

    }
}
