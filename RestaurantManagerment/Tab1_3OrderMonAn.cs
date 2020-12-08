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
using Guna;

namespace RestaurantManagerment
{
    public partial class Tab1_3OrderMonAn : UserControl
    {
        public Tab1_3OrderMonAn()
        {
            InitializeComponent();
            //this.Visible = false;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        List<NhomMonAn_DTO> listNhomMonAn;
        private void LoadNhomMonAn()
        {
            listNhomMonAn = NhomMonAn_DAO.LayNhomMonAn();
            for (int i = 0; i < listNhomMonAn.Count; i++)
            {
                Button btn = new Button() { Width = 100, Height = 35 };
                btn.Text = listNhomMonAn[i].TenNhomMonAn; 
                btn.BackColor = Color.SkyBlue;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Arial", 10, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                flplistNhomMon.Controls.Add(btn);
                if(btn.Text == listNhomMonAn[0].TenNhomMonAn)
                {
                    btn.Click += btnFood_click;
                }
                else
                {
                    btn.Click += btnDrinks_click;
                }
                    
            }
        }
        private void btnFood_click(object sender, EventArgs e)
        {
            flplistMonAn.Controls.Clear();
            for (int i = 0; i < listMonAn.Count; i++)
            {
                if (listMonAn[i].TenNhomMon == "Lẫu")
                {
                    loadMonAn(i);
                }
            }
        }
        private void btnDrinks_click(object sender, EventArgs e)
        {
            flplistMonAn.Controls.Clear();
            for (int i = 0; i < listMonAn.Count; i++)
            {
                if (listMonAn[i].TenNhomMon == "Nước Uống")
                {
                    loadMonAn(i);
                }
            }
        }
        List<MonAn_DTO> listMonAn = MonAn_DAO.LoadMonAn();
        private void loadMonAn(int i)
        {
            
            
                Guna.UI.WinForms.GunaAdvenceTileButton gunaBtn = new Guna.UI.WinForms.GunaAdvenceTileButton() { Width = 116, Height = 154 };
                gunaBtn.Image = listMonAn[i].IMAGE;
                gunaBtn.BaseColor = Color.LightGray;
                gunaBtn.ImageSize = new Size(107, 90);
                gunaBtn.Font = new Font("Arial", 10, FontStyle.Bold);
                gunaBtn.Text = listMonAn[i].TenMonAn + Environment.NewLine + listMonAn[i].Gia + " Đồng";
                flplistMonAn.Controls.Add(gunaBtn);
            
        }
        private void Tab1_3OrderMonAn_Load(object sender, EventArgs e)
        {
            LoadNhomMonAn();
            
        }
    }
}
