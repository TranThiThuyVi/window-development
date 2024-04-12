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
    public partial class FrmBai02 : Form
    {
        public FrmBai02()
        {
            InitializeComponent();
        }
        void Items_ChonXem()
        {
            cboChonXem.Items.Add("Số chẵn");
            cboChonXem.Items.Add("Số nguyên tố");
        }
        private void FrmBai02_Load(object sender, EventArgs e)
        {
            Items_ChonXem();
        }

        private void txtNhapChuoiSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ' || e.KeyChar == (char)8))
                e.Handled = true;
        }
        bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        bool LaSoChan(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }
        private void cboChonXem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboChonXem.SelectedIndex == 0)
            {
                lbKQ.Text = "Các số chẵn gồm có: ";
                foreach(string so in txtNhapChuoiSo.Text.Split(' '))
                {
                    if(so != "")
                    {
                        if(LaSoChan(int.Parse(so)) == true)
                        {
                            lbKQ.Text += so + " ";
                        }
                    }
                }
            }
            if (cboChonXem.SelectedIndex == 1)
            {
                lbKQ.Text = "Các số nguyên tố gồm có: ";
                foreach (string so in txtNhapChuoiSo.Text.Split(' '))
                {
                    if (so != "")
                    {
                        if (LaSoNguyenTo(int.Parse(so)) == true)
                        {
                            lbKQ.Text += so + " ";
                        }
                    }
                }
            }
        }

    }
}
