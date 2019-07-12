using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    class DTO_NhapThietBi
    {
        public int ID { get; set; }
        public int RequestID { get; set; }
        public DateTime Date { get; set; }

        public DTO_NhapThietBi()
        {
        }

        public DTO_NhapThietBi(int iD, int requestID, DateTime date)
        {
            ID = iD;
            RequestID = requestID;
            Date = date;
        }

    }
}
