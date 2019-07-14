using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO_QuanLy;
using DAL_QuanLy;
namespace BUS_QuanLy
{
    public class BUS_SuaChua
    {
        DAL_SuaChua repairDAL;
        public BUS_SuaChua()
        {
            repairDAL = new DAL_SuaChua();
        }

        public DTO_SuaChua getRepairingById(int _id)
        {
            DTO_SuaChua repairDTO = new DTO_SuaChua();
            DataTable dataTable = new DataTable();
            dataTable = repairDAL.getRepairingById(_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                repairDTO.fromDatarow(dr);
            }
            return repairDTO;
        }

        public List<DTO_SuaChua> getRepairingByRequestId(int _id)
        {
            List<DTO_SuaChua> repairDTOs = new List<DTO_SuaChua>();
            DataTable dataTable = new DataTable();
            dataTable = repairDAL.getRepairingByRequestId(_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                repairDTOs.Add(new DTO_SuaChua(dr));
            }
            return repairDTOs;
        }
 
        public List<DTO_SuaChua> getAllBoughtDevices()
        {
            List<DTO_SuaChua> list = new List<DTO_SuaChua>();
            DataTable dataTable = repairDAL.getAllRepairings();
            foreach (DataRow dr in dataTable.Rows)
            {
                list.Add(new DTO_SuaChua(dr));
            }
            return list;
        }
        public bool insertRepairing(DTO_SuaChua repairDTO)
        {
            return repairDAL.insertRepairing(repairDTO);
        }

        public int getNextRepairingId()
        {
            return repairDAL.getNextRepairingID();
        }

        public bool deleteBoughtDevice(DTO_SuaChua repairDTO)
        {
            return repairDAL.deleteRepairing(repairDTO);
        }


    }
}
