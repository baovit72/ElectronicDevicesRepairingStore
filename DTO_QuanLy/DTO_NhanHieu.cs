using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace DTO_QuanLy
{
    public class DTO_NhanHieu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DTO_NhanHieu() { }

        public DTO_NhanHieu(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public DTO_NhanHieu(DataRow dr)
        {
            fromDatarow(dr);
        }

        public void fromDatarow(DataRow dr)
        {
            ID = Int32.Parse(dr["MaNhanHieu"].ToString());
            Name = dr["TenNhanHieu"].ToString();
        }
    }
}
