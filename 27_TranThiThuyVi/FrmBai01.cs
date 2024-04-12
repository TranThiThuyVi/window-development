using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_TranThiThuyVi
{
    public partial class FrmBai01 : Form
    {
        public FrmBai01()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbNgayGio.Text = DateTime.Now.ToString(" Hiện tại: dd/MM/yyyy - HH:mm:ss tt");
        }

        private void FrmBai01_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttChon_Click(object sender, EventArgs e)
        {
            if (rdbCau2.Checked == true)
                new FrmBai02().Show();
            if (rdbCau3.Checked == true)
                new FrmBai03().Show();
        }

    }
}
