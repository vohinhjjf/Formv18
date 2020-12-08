using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAO;
using System.Threading;
using Guna;

namespace RestaurantManagerment
{
    public partial class Tab1_1_1BanAn : UserControl
    {
        public Tab1_1_1BanAn()
        {
            InitializeComponent();
            this.Controls.Add(this.flpSoDoBan);
            tab1_3OrderMonAn1.Visible = false;
        }

        List<BanAn_DTO> tableList = BanAn_DAO.LayBanAn();
        int tableID;
        private void LoadBanAn()
        {
            ;
            for (int i = 0; i < tableList.Count; i++)
            {
                Guna.UI.WinForms.GunaAdvenceTileButton gunaBtn = new Guna.UI.WinForms.GunaAdvenceTileButton() { Width = BanAn_DAO.tableWidth, Height = BanAn_DAO.tableHeight };
                gunaBtn.Image = Properties.Resources.icons8_tableware_48px;
                gunaBtn.Text = tableList[i].TenBan;
                gunaBtn.BorderSize = 3;
                gunaBtn.ForeColor = Color.Black;
                gunaBtn.BorderColor = Color.LightGray;
                gunaBtn.OnHoverBaseColor = Color.Linen;
                gunaBtn.OnHoverBorderColor = Color.BlueViolet;
                gunaBtn.OnHoverForeColor = Color.Black;
                gunaBtn.Font = new Font("Arial", 11, FontStyle.Bold);

                gunaBtn.Click += btn_Click;
                if (tableList[i].TrangThai == "Trống")
                {
                    gunaBtn.DoubleClick += btn_DoubleClick;

                }
                
                tableID = BanAn_BUS.layIDBanAn(tableList[i].TenBan);
                gunaBtn.Tag = tableList[i];

                switch (tableList[i].TrangThai)
                {
                    case "Trống":
                        gunaBtn.BaseColor = Color.Linen;
                        break;
                    default:
                        gunaBtn.BaseColor = Color.Aqua;
                        gunaBtn.BorderSize = 2;
                        gunaBtn.BorderColor = Color.BlueViolet;
                        break;
                }
                flpSoDoBan.Controls.Add(gunaBtn);
            }
        }
        public void Add(int i)
        {          
                lbBan.Text = tableList[i].TenBan;
                if (tableList[i].TrangThai == "Có Người")
                {
                    LoadThoiGian();
                }
                else
                {
                    lbNgay.Text = "00/00/0000";
                }
                lbBan.Text = tableList[i].TrangThai;           
        }
        public void ShowBill(int iDBan)
        {
          
        }
        private void btn_DoubleClick(object sender, EventArgs e)
        {
            tab1_3OrderMonAn1.Visible = true;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int tableI = ((sender as Guna.UI.WinForms.GunaAdvenceTileButton).Tag as BanAn_DTO).IDBan;
            Add(tableI);
            ShowBill(tableID);
            LoadHoaDon(tableI+1);
        }

        private void Tab1_1_1BanAn_Load(object sender, EventArgs e)
        {
            LoadBanAn();
            
        }

        //------------- lấy ngày tháng năm hiện tại ---------------------------
        void LoadThoiGian()
        {
            DateTime nowTime = DateTime.Now;
            lbNgay.Text = nowTime.ToString("dd/MM/yyyy");
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            flpSoDoBan.Controls.Clear();
            LoadBanAn();
        }

        // ----------------------- Load Hóa Đơn -----------------------------
        List<HoaDonOrder_DTO> danhSachHoaDon;
        private void LoadHoaDon(int idBan)
        {
            int tongTien = 0;
            dgvHoaDonOrder.Rows.Clear();  // xóa hết các dòng trên listview đi để tránh cái sau đè lên cái trước
            danhSachHoaDon = HoaDonOrder_BUS.LoadHoaDon(idBan);  // lấy hóa đơn của bàn đang được click
            if (danhSachHoaDon == null)                    // nếu không có hóa đơn tiền = 0
            {
                LabelTongTienSo.Text = "0";
                return;
            }
              
            else    // nếu có hóa đơn
            {
                for (int i = 0; i < danhSachHoaDon.Count; i++)  // duyệt từ đầu danh sách hóa đơn đến cuối danh sách hóa đơn
                {

                    tongTien += int.Parse(danhSachHoaDon[i].ThanhTien.ToString());  // tính tổng tiền
                    dgvHoaDonOrder.Rows.Add(danhSachHoaDon[i].TenMonAn.ToString(), danhSachHoaDon[i].SoLuong.ToString(), danhSachHoaDon[i].Gia.ToString(), danhSachHoaDon[i].ThanhTien.ToString()); // thêm items vừa tạo vào listview
                }
                //CultureInfo cul = new CultureInfo("vi-VN");

                // Gán Tiền vào textbox
                LabelTongTienSo.Text = tongTien.ToString();
            }

        }

    }
}
