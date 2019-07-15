using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using BUS_QuanLy;
using DTO_QuanLy;
 
namespace GUI_QuanLy
{
    public partial class GUI_DayStatistics : Form
    {
        BUS_Statistics statisticsBUS;
        public GUI_DayStatistics()
        {
            InitializeComponent();
            statisticsBUS = new BUS_Statistics();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void GUI_DayStatistics_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;

            chart1.Series.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            if (beginDate > endDate)
                return;
            DTO_Statistics thongKeDTO;
            thongKeDTO = statisticsBUS.getDayStatistics(beginDate, endDate);

            
            foreach(Series series in chart1.Series)
            {
                series.Points.Clear();
            }

            chart1.Series.Clear();
            if (radioButton1.Checked)
            {
                Series series = new Series("Yêu cầu sửa chữa");
                series.Points.DataBindXY(thongKeDTO.Dates.Select(date=>date.ToString("dd-MM-yyyy")).ToArray(), thongKeDTO.requestStatistics);
                chart1.Series.Add(series);
                 
                int totalRequest = thongKeDTO.requestStatistics.AsQueryable().Sum();
                label3.Text = "Tổng: " + totalRequest + " yêu cầu";
            }
            if (radioButton2.Checked)
            {
                Series series = new Series("Tiền công sửa chữa");
                series.Points.DataBindXY(thongKeDTO.Dates.Select(date => date.ToString("dd-MM-yyyy")).ToArray(), thongKeDTO.wageStatistics);
                // chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                //series.ChartType = SeriesChartType.Spline;
                chart1.Series.Add(series);
                long totalWage = thongKeDTO.wageStatistics.AsQueryable().Sum();
                label3.Text = "Tổng: " + totalWage + " VND";
            }
        }
    }
}
