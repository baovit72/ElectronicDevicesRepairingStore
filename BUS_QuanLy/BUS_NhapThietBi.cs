using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

using DTO_QuanLy;
using DAL_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_NhapThietBi
    {
        DAL_NhapThietBi nhapDAL;
        public BUS_NhapThietBi()
        {
            nhapDAL = new DAL_NhapThietBi();
        }
        public DTO_NhapThietBi getBoughtDeviceById(int _id)
        {
            DTO_NhapThietBi nhapDTO = new DTO_NhapThietBi();
            DataTable dataTable = new DataTable();
            dataTable = nhapDAL.getBoughtDeviceById(_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                nhapDTO.fromDatarow(dr);
            }
            return nhapDTO;
        }

        public List<DTO_NhapThietBi> getBoughtDevicesByRequestId(int _id)
        {
            List<DTO_NhapThietBi> nhapDTOs = new List<DTO_NhapThietBi>();
            DataTable dataTable = new DataTable();
            dataTable = nhapDAL.getBoughtDevicesByRequestId(_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                nhapDTOs.Add(new DTO_NhapThietBi(dr));
            }
            return nhapDTOs;
        }

        public List<String> getBoughtDevicesDisplayStrByRequestId(int _id)
        {
            return getBoughtDevicesByRequestId(_id).Select(dev => dev.DeviceName + " SL:" + dev.Quantity.ToString() + " Tong:" + (dev.Quantity * dev.UnitPrice).ToString() + " Ngay:" + dev.Date.ToString("dd-MM-yyyy")).ToList();
        }

        public List<DTO_NhapThietBi> getAllBoughtDevices()
        {
            List<DTO_NhapThietBi> list = new List<DTO_NhapThietBi>();
            DataTable dataTable = nhapDAL.getAllBoughtDevices();
            foreach (DataRow dr in dataTable.Rows)
            {
                list.Add(new DTO_NhapThietBi(dr));
            }
            return list;
        }
        public bool insertBoughtDevice(DTO_NhapThietBi nhapDTO)
        {
            return nhapDAL.insertBoughtDevice(nhapDTO);
        }

        public int getNextBoughtDeviceId()
        {
            return nhapDAL.getNextBoughtDeviceID();
        }

        public bool deleteBoughtDevice(DTO_NhapThietBi nhapDTO)
        {
            return nhapDAL.deleteBoughtDevice(nhapDTO);
        }


    }
}
