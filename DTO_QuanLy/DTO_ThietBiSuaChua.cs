using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO_QuanLy
{
    public class DTO_ThietBiSuaChua
    { 
        public int ID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int BrandID { get; set; }
        public DTO_ThietBiSuaChua() { }

        public DTO_ThietBiSuaChua(int iD, string name, string model, int brandID)
        {
            ID = iD;
            Name = name;
            Model = model;
            BrandID = brandID;
        }

        public DTO_ThietBiSuaChua(DataRow dr)
        {
            fromDatarow(dr);
        }
        public void fromDatarow(DataRow dr)
        {
            ID = Int32.Parse(dr["MaThietBi"].ToString());
            Name = dr["TenThietBi"].ToString();
            Model = dr["Model"].ToString();
            BrandID = Int32.Parse(dr["MaNhanHieu"].ToString());
        }

       
    }
}
