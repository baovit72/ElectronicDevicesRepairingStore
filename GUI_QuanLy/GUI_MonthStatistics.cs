using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;
using System.Windows.Forms.DataVisualization.Charting; 


namespace GUI_QuanLy
{
    public partial class GUI_MonthStatistics : Form
    {
        BUS_Statistics statisticsBUS;
        public GUI_MonthStatistics()
        {

            InitializeComponent();
            statisticsBUS = new BUS_Statistics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
                return;
            int year = Int32.Parse(textBox1.Text);
            DTO_Statistics thongKeDTO;
            thongKeDTO = statisticsBUS.getMonthStatistics(year);


            foreach (Series series in chart1.Series)
            {
                series.Points.Clear();
            }

            chart1.Series.Clear();
            if (radioButton1.Checked)
            {
                Series series = new Series("Yêu cầu sửa chữa");
                series.Points.DataBindXY(thongKeDTO.Dates.Select(date=>date.ToString("MM")).ToArray(), thongKeDTO.requestStatistics);
                chart1.Series.Add(series);
                int totalRequest = thongKeDTO.requestStatistics.AsQueryable().Sum();
                label2.Text = "Tổng: " + totalRequest + " yêu cầu";
            }
            if (radioButton2.Checked)
            {
                Series series = new Series("Tiền công sửa chữa");
                series.Points.DataBindXY(thongKeDTO.Dates.Select(date => date.ToString("MM")).ToArray(), thongKeDTO.wageStatistics); 
                chart1.Series.Add(series);
                long totalWage = thongKeDTO.wageStatistics.AsQueryable().Sum();
                label2.Text = "Tổng: " + totalWage + " VND";
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            GUIUtility.HandleDigitTextBox(sender, ref e);
        }

        private void GUI_MonthStatistics_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            textBox1.Text = DateTime.Now.ToString("yyyy");
        }
    }
}
