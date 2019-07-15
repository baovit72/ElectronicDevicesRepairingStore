using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_Tracuu : Form
    {
        private int opt;
        private List<int> skippedIndex;
        private List<DTO_HoaDon> hoaDons;

        private int previousIndex;

        Form parent;
        /// <OPTION>
        /// 1 - Search by ID
        /// 2 - Search by Customer's Name
        /// 3 - Search by Device's Name
        /// </OPTION>
        public GUI_Tracuu()
        {
            InitializeComponent();
        }

        public GUI_Tracuu(Form p, int o, List<DTO_HoaDon> hd)
        {
            InitializeComponent();
            parent = p;
            opt = o;
            hoaDons = hd;
            skippedIndex = new List<int>();
        }

        private void GUI_Tracuu_Load(object sender, EventArgs e)
        {
            if (opt == 2)
                label1.Text = "Tên khách hàng: ";
            if (opt == 3)
                label1.Text = "Tên thiết bị";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (opt == 1)
                GUIUtility.HandleDigitTextBox(sender, ref e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (opt)
            {
                case 1:
                    previousIndex = hoaDons.FindIndex(hd => hd.ID == Int64.Parse(tbInfo.Text.Trim()));
                    break;
                case 2:
                    previousIndex = hoaDons.FindIndex(hd => hd.CustomerName.Contains(tbInfo.Text.TrimEnd().TrimStart()) && !skippedIndex.Contains(hoaDons.FindIndex(h=>h==hd)));
                    break;
                case 3:
                    previousIndex = hoaDons.FindIndex(hd => hd.DeviceName.Contains(tbInfo.Text.TrimEnd().TrimStart()) && !skippedIndex.Contains(hoaDons.FindIndex(h => h == hd)));
                    break;
                default:
                    previousIndex = -1;
                    break;
            }


            if (previousIndex != -1)
            {
                if (!skippedIndex.Contains(previousIndex))
                {
                    ((GUI_SuaChua)parent).ChangeSelectedHoaDon(previousIndex);
                    skippedIndex.Add(previousIndex);
                }
            }
            else if(skippedIndex.Count>0)
                skippedIndex = new List<int>();




        }
    }
}
