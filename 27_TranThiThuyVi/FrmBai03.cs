using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
namespace _27_TranThiThuyVi
{
    public partial class FrmBai03 : Form
    {
        ArrayList arr = new ArrayList();
        int dem = 0;
        public FrmBai03()
        {
            InitializeComponent();
        }
        void Items_ChucNang()
        {
            cboChucNang.Items.Add("Xem tất cả");
            cboChucNang.Items.Add("Xem số nguyên tố");
        }
        private void FrmBai03_Load(object sender, EventArgs e)
        {
            Items_ChucNang();
        }

        private void bttNhap_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text.Trim() == "")
            {
                MessageBox.Show("Mời bạn nhập một số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                arr.Add(int.Parse(txtNhap.Text));
                dem = dem + 1;
                txtSoPhanTu.Text = dem.ToString();
                txtNhap.ResetText();
                txtNhap.Focus();
            }
        }

        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttNhap_Click(sender, e);
            }
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
        private void XuLyHienThi(ArrayList alist, int tuychon)
        {
            txtXuat.ResetText();
            int tong = 0;
            switch (tuychon)
            {
                case 0:
                    foreach (object s in alist)
                    {
                        txtXuat.Text += s + Environment.NewLine;
                        tong += int.Parse(s.ToString());
                    }
                    break;
                case 1:
                    foreach (object s in alist)
                    {
                        if (LaSoNguyenTo(int.Parse(s.ToString())))
                        {
                            txtXuat.Text += s + Environment.NewLine;
                            tong += int.Parse(s.ToString());
                        }
                    }
                    break;
            }
            txtTong.Text = tong.ToString();
        }
        private void bttThucHien_Click(object sender, EventArgs e)
        {
            if (cboChucNang.SelectedIndex >= 0)
                XuLyHienThi(arr, cboChucNang.SelectedIndex);
            else
                MessageBox.Show("Bạn chưa chọn tùy chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bttGhiFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Ghi file text";
            sf.Filter = "Text file | *.txt";
            sf.InitialDirectory = Application.StartupPath;
            sf.AddExtension = true;
            sf.DefaultExt = ".txt";
            if (sf.ShowDialog() == DialogResult.OK && sf.FileName != "")
            {
                StreamWriter wt = new StreamWriter(sf.FileName);
                wt.WriteLine(txtXuat.Text);
                wt.Dispose();
                wt.Close();
            }
        }
    }
}
