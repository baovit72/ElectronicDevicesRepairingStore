using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO_QuanLy
{
    public class DTO_SuaChua
    {
        public int ID { get; set; }
        public int requestID { get; set; }
        public DateTime Date { get; set; }
        public int TienCong { get; set; }
        public string MoTaLoi { get; set; }

        public DTO_SuaChua() { }
        public DTO_SuaChua(int id, int rId, DateTime date, int tienCong, string moTaLoi)
        {
            ID = id;
            requestID = rId;
            Date = date;
            TienCong = tienCong;
            MoTaLoi = moTaLoi;
        }

        public DTO_SuaChua(DataRow dr)
        {
            fromDatarow(dr);
        }

        public void fromDatarow(DataRow dr)
        {
            ID = Int32.Parse(dr["MaSuaChua"].ToString());

            requestID = Int32.Parse(dr["MaYeuCau"].ToString());

            Date = Convert.ToDateTime(dr["NgayLap"].ToString());

            TienCong = Int32.Parse(dr["TienCong"].ToString());

            MoTaLoi =  dr["MoTaLoi"].ToString();
        }

    }
}
