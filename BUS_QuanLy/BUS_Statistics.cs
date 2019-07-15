using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_QuanLy;
using DTO_QuanLy;
using System.Data;

namespace BUS_QuanLy
{
    
    public class BUS_Statistics
    {
        DAL_Statistics statisticsDAL;
        public BUS_Statistics()
        {
            statisticsDAL = new DAL_Statistics();
        }

        public DTO_Statistics getDayStatistics(DateTime dateBegin, DateTime dateEnd) 
        {
            List<int> listRequestStatistics;
            List<DateTime> listDates;
            List<long> listWageStatistics;
            listRequestStatistics = new List<int>();
            listDates = new List<DateTime>();
            listWageStatistics = new List<long>();
             
            DateTime temp = dateBegin;
             
            while(temp <= dateEnd)
            {
                DataTable dt = new DataTable();
                dt = statisticsDAL.getRequestSpecificDayStatistic(temp);
                listRequestStatistics.Add(Int32.Parse(dt.Rows[0][0].ToString()));
                dt = statisticsDAL.getWageSpecificDayStatistic(temp);
                if (dt.Rows[0][0] == DBNull.Value)
                    listWageStatistics.Add(0);
                else
                    listWageStatistics.Add(Int64.Parse(dt.Rows[0][0].ToString()));
                listDates.Add(temp);
                temp = temp.AddDays(1);
            }
            return new DTO_Statistics(listRequestStatistics, listWageStatistics, listDates);
        }
        public DTO_Statistics getMonthStatistics(int year)
        {
            List<int> listRequestStatistics;
            List<DateTime> listDates;
            List<long> listWageStatistics;
            listRequestStatistics = new List<int>();
            listDates = new List<DateTime>();
            listWageStatistics = new List<long>();

            DateTime temp = Convert.ToDateTime(year + "-1-1");
            DateTime dateEnd = Convert.ToDateTime(year + "-12-1");
            while (temp <= dateEnd)
            {
                DataTable dt = new DataTable();
                dt = statisticsDAL.getRequestSpecificMonthStatistic(temp);
                listRequestStatistics.Add(Int32.Parse(dt.Rows[0][0].ToString()));
                dt = statisticsDAL.getWageSpecificMonthStatistic(temp);
                if (dt.Rows[0][0] == DBNull.Value)
                    listWageStatistics.Add(0);
                else
                    listWageStatistics.Add(Int64.Parse(dt.Rows[0][0].ToString()));
                listDates.Add(temp);
                temp = temp.AddMonths(1);
            }
            return new DTO_Statistics(listRequestStatistics, listWageStatistics, listDates);
        }
    }
}
