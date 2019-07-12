using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    class DTO_ChiTietNhapThietBi
    {
        public int ID { get; set; }
        public int importID { get; set; }
        public int DeviceName { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }

        public DTO_ChiTietNhapThietBi()
        {
        }

        public DTO_ChiTietNhapThietBi(int iD, int importID, int deviceName, int quantity, int unitPrice)
        {
            ID = iD;
            this.importID = importID;
            DeviceName = deviceName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
