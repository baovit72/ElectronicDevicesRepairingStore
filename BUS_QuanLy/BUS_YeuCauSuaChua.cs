using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_QuanLy;
using DAL_QuanLy;
using System.Data;

namespace BUS_QuanLy
{
    public class BUS_YeuCauSuaChua
    {
        DAL_YeuCauSuaChua yeuCauDAL;
        public BUS_YeuCauSuaChua()
        {
            yeuCauDAL = new DAL_YeuCauSuaChua();
        }
        public DTO_YeuCauSuaChua getDeviceById(int _id)
        {
            DTO_YeuCauSuaChua yeuCauDTO = new DTO_YeuCauSuaChua();
            DataTable dataTable = new DataTable();
            dataTable = yeuCauDAL.getRequestById(_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                yeuCauDTO.fromDatarow(dr);
            }
            return yeuCauDTO;
        }
        public List<DTO_YeuCauSuaChua> getAllRequests()
        {
            List<DTO_YeuCauSuaChua> list = new List<DTO_YeuCauSuaChua>();
            DataTable dataTable = yeuCauDAL.getAllRequests();
            foreach (DataRow dr in dataTable.Rows)
            {
                list.Add(new DTO_YeuCauSuaChua(dr));
            }
            return list;
        } 
        public bool insertRequest(DTO_YeuCauSuaChua yeuCauDTO)
        {
            return yeuCauDAL.insertRequest(yeuCauDTO);
        }

        public int getNextRequestId()
        {
            return yeuCauDAL.getNextRequestID();
        }
    }
}
