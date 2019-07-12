using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy    
{
    
    public class BUS_NhanHieu
    {
        DAL_NhanHieu nhanHieuDAL;
        public BUS_NhanHieu()
        {
            nhanHieuDAL = new DAL_NhanHieu();

        }
        public DTO_NhanHieu getBrandById(int _id)
        {
            DTO_NhanHieu nhanHieuDTO = new DTO_NhanHieu();
            DataTable dataTable = new DataTable();
            dataTable = nhanHieuDAL.getBrandById(_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                nhanHieuDTO.fromDatarow(dr);
            }
            return nhanHieuDTO;
        }
        public List<DTO_NhanHieu> getAllBrands()
        {
            List<DTO_NhanHieu> list = new List<DTO_NhanHieu>();
            DataTable dataTable = nhanHieuDAL.getAllBrands();
            foreach (DataRow dr in dataTable.Rows)
            {
                list.Add(new DTO_NhanHieu(dr));
            }
            return list;
        }

        public List<string> getAllBrandNames()
        {
            List<string> names = getAllBrands().Select(br => br.Name).ToList();
            return names;
        }

        public bool insertBrand(DTO_NhanHieu nhanHieuDTO)
        {
            return nhanHieuDAL.insertBrand(nhanHieuDTO);
        }

        public int getNextBrandId()
        {
            return nhanHieuDAL.getNextBrandID();
        }

        public int isDuplicate(DTO_NhanHieu nhanHieuDTO)
        {
            return nhanHieuDAL.IsDuplicate(nhanHieuDTO);
        }

    }
}
