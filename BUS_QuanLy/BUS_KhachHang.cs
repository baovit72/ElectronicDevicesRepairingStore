using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;
namespace BUS_QuanLy
{
    public class BUS_KhachHang
    {
        DAL_KhachHang khachHangDAL;
        public BUS_KhachHang()
        {
            khachHangDAL = new DAL_KhachHang();
        }
        public DTO_KhachHang getCustomerById(int _id)
        {
            DTO_KhachHang khachHangDTO = new DTO_KhachHang();
            DataTable dataTable = new DataTable();
            dataTable = khachHangDAL.getCustomerById(_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                khachHangDTO.fromDatarow(dr);
            }
            return khachHangDTO;
        }
        public List<DTO_KhachHang> getAllCustomers()
        {
            List<DTO_KhachHang> list = new List<DTO_KhachHang>();
            DataTable dataTable = khachHangDAL.getAllCustomers();
            foreach (DataRow dr in dataTable.Rows)
            {
                list.Add(new DTO_KhachHang(dr));
            }
            return list;
        }

        public List<string> getAllCustomerNames()
        {
            List<string> names = getAllCustomers().Select(cus => cus.ID.ToString()+"/" + cus.HoTen).ToList();
            return names;
        }

        public bool insertCustomer(DTO_KhachHang khachHangDTO)
        {
            return khachHangDAL.insertCustomer(khachHangDTO);
        }

        public int getNextCustomerId()
        { 
            return khachHangDAL.getNextCustomerID();
        }
        public int isDuplicate(DTO_KhachHang khachHangDTO)
        {
            return khachHangDAL.IsDuplicate(khachHangDTO);
        }
    }
}
