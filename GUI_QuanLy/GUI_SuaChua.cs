using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_SuaChua : Form
    {
        BUS_HoaDon hoaDonBUS;
        BUS_NhapThietBi nhapBUS;
        BUS_YeuCauSuaChua yeuCauBUS;
        BUS_SuaChua repairBUS;



        List<DTO_HoaDon> hoaDons; // Thực ra đây là thông tin đầy đủ của yêu cầu
        List<DTO_NhapThietBi> devices; // Đây là những thiết bị được nhập cho mỗi yêu cầu


        DTO_HoaDon selectedHoaDon;

        public GUI_SuaChua()
        {
            InitializeComponent();
            hoaDonBUS = new BUS_HoaDon();
            nhapBUS = new BUS_NhapThietBi();
            yeuCauBUS = new BUS_YeuCauSuaChua();
            repairBUS = new BUS_SuaChua();

            hoaDons = new List<DTO_HoaDon>();
            devices = new List<DTO_NhapThietBi>();
        }

        private void GUI_SuaChua_Load(object sender, EventArgs e)
        {
            ReloadRequestList();
            ReloadBoughtDevicesList();
        }

        public void ReloadRequestList()
        {
            if (cbOptRepair.Checked)
            {
                listRequest.DataSource = hoaDonBUS.getAllFullInfoDisplayStr();
                hoaDons = hoaDonBUS.getAllFullInfos();
            }
            else
            {
                listRequest.DataSource = hoaDonBUS.getUnrepairedFullInfoDisplayStr();
                hoaDons = hoaDonBUS.getUnrepairedFullInfos();
            }
        }


        public void ReloadBoughtDevicesList()
        {
            if (selectedHoaDon == null) return;
            int requestid = hoaDons[listRequest.SelectedIndex].ID;
            if (cbOptRepair.Checked)
                hoaDons = hoaDonBUS.getAllFullInfos();
            else
                hoaDons = hoaDonBUS.getUnrepairedFullInfos();
            devices = nhapBUS.getBoughtDevicesByRequestId(requestid);
            listDevices.DataSource = nhapBUS.getBoughtDevicesDisplayStrByRequestId(requestid);
            UpdateTotalPrice();

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fmAddRequest = new GUI_NhanSuaChua(this);
            fmAddRequest.ShowDialog();
        }

        private void listRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hoaDons.Count == 0)
                hoaDons = hoaDonBUS.getUnrepairedFullInfos();

            if (listRequest.SelectedIndex != -1 && hoaDons.Count > 0)
            {
                selectedHoaDon = hoaDons[listRequest.SelectedIndex];
                tbCusname.Text = selectedHoaDon.CustomerName;
                tbPhoneNum.Text = selectedHoaDon.PhoneNumber;
                tbAddress.Text = selectedHoaDon.Address;

                tbDevice.Text = selectedHoaDon.DeviceName + " | Hãng:" + selectedHoaDon.BrandName + " |  Model:"
                                                 + selectedHoaDon.Model + " | SL:" + selectedHoaDon.Quantity;
                tbRequestInfo.Text = "Tình trạng: " + selectedHoaDon.ProblemDescription + "\r\n" + "Ghi chú: " + selectedHoaDon.Note
                                        + "\r\nNgày nhận: " + selectedHoaDon.Date.ToString("dd-MM-yyyy");


                //Cập nhật tổng tiền và tình trạng
                lbStatus.Text = "Tình trạng: " + (selectedHoaDon.IsRepaired == 0 ? "Chưa sửa chữa" : "Đã sửa chữa");

                //Cập nhật thông tin các thiết bị được sử dụng
                ReloadBoughtDevicesList();

                tbWage.Text = "";
                tbRepairInfo.Text = "";
                //Disable them tien cong va thiet bi sua chua neu yeu cau da sua
                if (selectedHoaDon.IsRepaired == 1)
                {
                    
                    btnAddDevice.Enabled = false;
                    btnRemoveDevice.Enabled = false;
                    btnSave.Enabled = false;

                    tbWage.Enabled = false;
                    tbRepairInfo.Enabled = false;
                    //Cập nhật thông tin sửa chữa
                    List<DTO_SuaChua> repairDTOs = new List<DTO_SuaChua>();
                    if (selectedHoaDon != null)
                    {
                        repairDTOs = repairBUS.getRepairingByRequestId(selectedHoaDon.ID);
                        if (repairDTOs.Count > 0)
                        {
                            tbWage.Text = repairDTOs[0].TienCong.ToString();
                            tbRepairInfo.Text = repairDTOs[0].MoTaLoi.ToString();
                        }
                    }

                }
                else
                {
                    btnAddDevice.Enabled = true;
                    btnRemoveDevice.Enabled = true;

                    btnSave.Enabled = true;

                    tbWage.Enabled = true;
                    tbRepairInfo.Enabled = true;

                  
                }


                //Cập nhật lại thông tin tổng tiền

                UpdateTotalPrice();

            }





        }

        private void UpdateTotalPrice()
        {
            int tong = 0;
            foreach (DTO_NhapThietBi dev in devices)
            {
                tong += dev.Quantity * dev.UnitPrice;
            }

            List<DTO_SuaChua> repairings;
            repairings = new List<DTO_SuaChua>();

            if (selectedHoaDon != null)
            {
                repairings = repairBUS.getRepairingByRequestId(selectedHoaDon.ID);
                
            }
            int _wage = 0;

            if (repairings.Count > 0)
            {
               
                _wage += repairings[0].TienCong;
            }

            tong += _wage;
            lbTotal.Text = "Tổng tiền: " + tong.ToString() ;
        }

        private void cbOptRepair_CheckedChanged(object sender, EventArgs e)
        {
            ReloadRequestList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedHoaDon == null) return;
            if (selectedHoaDon.IsRepaired == 1)
            {
                MessageBox.Show("Không thể xoá yêu cầu đã sửa chữa !!");
                return;
            }

            if (!GUIUtility.PromptConfirmDelete()) return;
            //Xoá hoá đơn được chọn
            bool result = hoaDonBUS.deleteFullInfo(selectedHoaDon);
            if (result)
            {
                ReloadRequestList();
                MessageBox.Show("Xoá thành công !!!!!!!!!!");

            }
            else
                MessageBox.Show("Xoá không thành công !!!!!!!!!!!");
        }

        private void tbWage_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            GUIUtility.HandleDigitTextBox(sender, ref e);
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            if (selectedHoaDon == null) return;
            Form fmNhapThietBi = new GUI_NhapThietBi(this, selectedHoaDon);
            fmNhapThietBi.ShowDialog();

        }

        private void listDevices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listRequest_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listDevices_DoubleClick(object sender, EventArgs e)
        {
            if (listDevices.SelectedItem != null)
                MessageBox.Show(listDevices.SelectedItem.ToString());
        }

        private void btnRemoveDevice_Click(object sender, EventArgs e)
        {
            if (!GUIUtility.PromptConfirmDelete())
                return;
            if (listDevices.SelectedItem != null)
            {
                nhapBUS.deleteBoughtDevice(devices[listDevices.SelectedIndex]);
            }
            ReloadBoughtDevicesList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedHoaDon == null || tbRepairInfo.Text == "" || tbWage.Text == "")
                return;
            //Tạo đối tượng DTO sửa chữa
            try
            {
                DTO_SuaChua repairDTO = new DTO_SuaChua();
                repairDTO.Date = DateTime.Now;
                repairDTO.ID = repairBUS.getNextRepairingId();
                repairDTO.requestID = selectedHoaDon.ID;
                repairDTO.TienCong = Int32.Parse(tbWage.Text);
                repairDTO.MoTaLoi = tbRepairInfo.Text + "\r\nNgày sửa: " + DateTime.Now.ToString("dd-mm-yyyy HH:MM:ss");

                repairBUS.insertRepairing(repairDTO);

                //listRequest.SelectedIndex = -1;
                btnSave.Enabled = false;

                ReloadRequestList();
                UpdateTotalPrice();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
    }
}
