using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_Statistics
    {
        public List<int> requestStatistics { get; set; }
        public List<long> wageStatistics { get; set; }
        public List<DateTime> Dates { get; set; }
        public DTO_Statistics()
        {

        }

        public DTO_Statistics(List<int> requestStatistics, List<long> wageStatistics, List<DateTime> dates)
        {
            this.requestStatistics = requestStatistics;
            this.wageStatistics = wageStatistics;
            Dates = dates;
        }
    }
}
