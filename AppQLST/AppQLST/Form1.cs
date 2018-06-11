using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có thực sự muốn thoát!", "Thông báo ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string query = string.Format("EXEC DUYET_TAIKHOAN '{0}','{1}'", txbusername.Text, txbpassword.Text);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            //string tempp = result.Rows[0][2].ToString();
            if (txbpassword.Text.Length == 0 || txbusername.Text.Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tài Khoản Hoặc Mật Khẩu !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbpassword.Text = "";
                txbusername.Text = "";
                txbusername.Focus();
            }
            else if (result.Rows.Count > 0)
            {
                if ((bool)result.Rows[0][2] == true)
                {
                    fmannager f = new fmannager(result.Rows[0][0].ToString(), result.Rows[0][1].ToString(), true);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    fmannager f = new fmannager(result.Rows[0][0].ToString(), result.Rows[0][1].ToString(), false);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn Đã Nhập Sai Tài Khoản Hoặc Mật Khẩu !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbpassword.Text = "";
                txbpassword.Focus();
            }
        }
    }
}
