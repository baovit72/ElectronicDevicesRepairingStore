using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using DTO_QuanLy;
using DAL_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_HoaDon
    {
        DAL_HoaDon hoaDonDAL;
        public BUS_HoaDon()
        {
            hoaDonDAL = new DAL_HoaDon();
        }
        public DTO_HoaDon getFullInfoByRequestId(int _id)
        {
            DTO_HoaDon hoaDonDTO = new DTO_HoaDon();
            DataTable dataTable = new DataTable();
            dataTable = hoaDonDAL.getFullInfoByRequestId(_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                hoaDonDTO.fromDatarow(dr);
            }
            return hoaDonDTO;
        }
        public List<DTO_HoaDon> getAllFullInfos()
        {
            List<DTO_HoaDon> list = new List<DTO_HoaDon>();
            DataTable dataTable = hoaDonDAL.getAllFullInfos();
            foreach (DataRow dr in dataTable.Rows)
            {
                list.Add(new DTO_HoaDon(dr));
            }
            return list;
        }

        public List<string> getAllFullInfoDisplayStr()
        {
            return getAllFullInfos().Select(info =>   (info.IsRepaired == 0 ? "+" : "-")+ info.DeviceName + "/" + info.Date.ToString("dd-MM-yyyy") + "/" + info.CustomerName + "/" + info.PhoneNumber + "/" + info.Address).ToList();
        }

        public List<string> getUnrepairedFullInfoDisplayStr()
        {
            return getUnrepairedFullInfos().Select(info =>   info.DeviceName + "/" + info.Date.ToString("dd-MM-yyyy") + "/" + info.CustomerName + "/" + info.PhoneNumber + "/" + info.Address).ToList();
        }

        public List<DTO_HoaDon> getUnrepairedFullInfos()
        {
            List<DTO_HoaDon> list = new List<DTO_HoaDon>();
            DataTable dataTable = hoaDonDAL.getUnRepairedFullInfos();
            foreach (DataRow dr in dataTable.Rows)
            {
                list.Add(new DTO_HoaDon(dr));
            }
            return list;
        }

        public bool deleteFullInfo(DTO_HoaDon hoadondto)
        {
            return hoaDonDAL.deleteFullInfo(hoadondto);
        }

    }
}
