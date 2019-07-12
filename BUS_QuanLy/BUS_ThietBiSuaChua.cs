using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_QuanLy;
using DTO_QuanLy;
using System.Data;

namespace BUS_QuanLy
{
    public class BUS_ThietBiSuaChua
    {
        DAL_ThietBiSuaChua thietBiDAL;
        public BUS_ThietBiSuaChua()
        {
            thietBiDAL = new DAL_ThietBiSuaChua();
        }
        public DTO_ThietBiSuaChua getDeviceById(int _id)
        {
            DTO_ThietBiSuaChua thietBiDTO = new DTO_ThietBiSuaChua();
            DataTable dataTable = new DataTable();
            dataTable = thietBiDAL.getDeviceById(_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                thietBiDTO.fromDatarow(dr);
            }
            return thietBiDTO;
        }
        public List<DTO_ThietBiSuaChua> getAllDevices()
        {
            List<DTO_ThietBiSuaChua> list = new List<DTO_ThietBiSuaChua>();
            DataTable dataTable = thietBiDAL.getAllDevices();
            foreach (DataRow dr in dataTable.Rows)
            {
                list.Add(new DTO_ThietBiSuaChua(dr));
            }
            return list;
        }

        public List<string> getAllDeviceNames()
        {
            List<string> names = getAllDevices().Select(br => br.Name).ToList();
            return names;
        }

        public bool insertDevice(DTO_ThietBiSuaChua thietBiDTO)
        {
            return thietBiDAL.insertDevice(thietBiDTO);
        }

        public int getNextDeviceId()
        {
            return thietBiDAL.getNextDeviceID();
        }
    }
}
