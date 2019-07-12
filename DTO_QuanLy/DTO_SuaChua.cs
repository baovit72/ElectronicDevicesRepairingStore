using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    class DTO_SuaChua
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

    }
}
