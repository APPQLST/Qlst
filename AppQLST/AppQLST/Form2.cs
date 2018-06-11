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
    public partial class FormAdmin : Form
    {
        string flag;
        private int index;

        public FormAdmin()
        {
            InitializeComponent();
        }
    
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lockcontrol1();
            lockcontrol2();
            lockcontrol3();
            lockcontrol4();
            lockcontrol5();
            lockcontrol6();
            load_combobox1();
            load_combobox2();
            load_combobox3();
            load_combobox4();
            load_combobox5();
            load_combobox6();
            load_combobox7();
            load_combobox8();
        }
        #region LOCKCONTROL
        public void lockcontrol1()
        {
           
            button9.Enabled = true;

            textBox24.ReadOnly = true;
            textBox24.Text = "";
            textBox25.ReadOnly = true;
            textBox25.Text = "";
            dateTimePicker3.Enabled = false;
            dateTimePicker3.Text = "";
            textBox27.ReadOnly = true;
            textBox27.Text = "";
            textBox28.ReadOnly = true;
            textBox28.Text = "";
            textBox29.ReadOnly = true;
            textBox29.Text = "";
            button9.Focus();
        }
        public void lockcontrol2()
        {
            
            button10.Enabled = true;

            textBox32.ReadOnly = true;
            textBox32.Text = "";
            textBox31.ReadOnly = true;
            textBox31.Text = "";
            textBox30.ReadOnly = true;
            textBox30.Text = "";
            button10.Focus();
        }
        public void lockcontrol3()
        {
           
            button5.Enabled = true;

            textBox1.ReadOnly = true;
            textBox1.Text = "";
            textBox2.ReadOnly = true;
            textBox2.Text = "";
            textBox3.ReadOnly = true;
            textBox3.Text = "";
            textBox4.ReadOnly = true;
            textBox4.Text = "";

            button5.Focus();
        }
        public void lockcontrol4()
        {
           
            button6.Enabled = true;

            textBox5.ReadOnly = true;
            textBox5.Text = "";
            textBox6.ReadOnly = true;
            textBox6.Text = "";
            textBox7.ReadOnly = true;
            textBox7.Text = "";
            textBox8.ReadOnly = true;
            textBox8.Text = "";
            textBox9.ReadOnly = true;
            textBox9.Text = "";

            button6.Focus();
        }
        public void lockcontrol5()
        {
            
            button7.Enabled = true;

            textBox14.ReadOnly = true;
            textBox14.Text = "";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Text = "";
            textBox12.ReadOnly = true;
            textBox12.Text = "";
            comboBox1.Enabled = false;
            comboBox1.Text = "";
            comboBox2.Enabled = false;
            comboBox2.Text = "";
            comboBox3.Enabled = false;
            comboBox3.Text = "";
            comboBox4.Enabled = false;
            comboBox4.Text = "";

            button7.Focus();
        }
        public void lockcontrol6()
        {
           
            button8.Enabled = true;

            textBox23.ReadOnly = true;
            textBox23.Text = "";
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Text = "";
            textBox19.ReadOnly = true;
            textBox19.Text = "";
            comboBox5.Enabled = false;
            comboBox5.Text = "";
            comboBox6.Enabled = false;
            comboBox6.Text = "";
            comboBox7.Enabled = false;
            comboBox7.Text = "";
            comboBox8.Enabled = false;
            comboBox8.Text = "";

            button8.Focus();
        }
        #endregion
        #region UNLOCKCONTROL
        public void unlockcontrol1()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            

            textBox24.ReadOnly =false;
            textBox25.ReadOnly = false;
            dateTimePicker3.Enabled = true;
            textBox27.ReadOnly = false;
            textBox28.ReadOnly = false;
            textBox29.ReadOnly = false;
            button9.Focus();
        }
        public void unlockcontrol2()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            

            textBox32.ReadOnly = false;
            textBox31.ReadOnly = false;
            textBox30.ReadOnly = false;
            button10.Focus();
        }
        public void unlockcontrol3()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            

            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;

            button5.Focus();
        }
        public void unlockcontrol4()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            

            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox8.ReadOnly = false;
            textBox9.ReadOnly = false;
            button6.Focus();
        }
        public void unlockcontrol5()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            

            textBox14.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            textBox12.ReadOnly = false;
            comboBox1.Enabled =true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            button7.Focus();
        }
        public void unlockcontrol6()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            

            textBox23.ReadOnly = false;
            dateTimePicker2.Enabled = true;
            textBox19.ReadOnly = false;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            comboBox7.Enabled = true;
            comboBox8.Enabled = true;
            button8.Focus();
        }
        #endregion
        #region loaddulieu
        public void load_NHANVIEN()
        {
            dataGridView2.DataSource = DataProvider.Instance.ExecuteQuery("EXEC LOAD_NHANVIEN");
        }
        public void LOAD_TAIKHOAN()
        {
            dataGridView2.DataSource = DataProvider.Instance.ExecuteQuery("EXEC LOAD_TAIKHOAN");
        }
        public void load_NCC()
        {
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery("EXEC LOAD_NCC");
        }
        public void load_MATHANG()
        {
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery("EXEC LOAD_MATHANG");
        }
        public void load_NHAPKHO()
        {
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery("EXEC LOAD_NHAPKHO");
        }
        public void load_XUATKHO()
        {
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery("EXEC LOAD_XUATKHO");
        }
        public void load_combobox1()
        {
            comboBox1.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MNCC,TenNCC FROM NCC");
            comboBox1.ValueMember = "MNCC";
            comboBox1.DisplayMember = "TenNCC";
        }
        public void load_combobox2()
        {
            comboBox2.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MSMH,TenMH FROM MATHANG");
            comboBox2.ValueMember = "MSMH";
            comboBox2.DisplayMember = "TenMH";
        }
        public void load_combobox3()
        {
            comboBox3.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MSNV,TenNV FROM NHANVIEN");
            comboBox3.ValueMember = "MSNV";
            comboBox3.DisplayMember = "TenNV";
        }
        public void load_combobox4()
        {
            comboBox4.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MSKH,TenKH FROM KHOHANG");
            comboBox4.ValueMember = "MSKH";
            comboBox4.DisplayMember = "TenKH";
        }
        public void load_combobox5()
        {
            comboBox5.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MSKH,TenKH FROM KHOHANG");
            comboBox5.ValueMember = "MSKH";
            comboBox5.DisplayMember = "TenKH";
        }
        public void load_combobox6()
        {
            comboBox6.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MSNV,TenNV FROM NHANVIEN");
            comboBox6.ValueMember = "MSNV";
            comboBox6.DisplayMember = "TenNV";
        }
        public void load_combobox7()
        {
            comboBox7.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MaQH,TenQH FROM QUAYHANG");
            comboBox7.ValueMember = "MaQH";
            comboBox7.DisplayMember = "TenQH";
        }
        public void load_combobox8()
        {
            comboBox8.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MSMH,TenMH FROM MATHANG");
            comboBox8.ValueMember = "MSMH";
            comboBox8.DisplayMember = "TenMH";
        }
        #endregion
        #region loadcontrol
        private void button9_Click(object sender, EventArgs e)
        {
            flag = "1";
            unlockcontrol1();
            load_NHANVIEN();
            lockcontrol2();
            lockcontrol3();
            lockcontrol4();
            lockcontrol5();
            lockcontrol6();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            flag = "2";
            unlockcontrol2();
            LOAD_TAIKHOAN();
            lockcontrol1();
            lockcontrol3();
            lockcontrol4();
            lockcontrol5();
            lockcontrol6();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flag = "3";
            unlockcontrol3();
            load_NCC();
            lockcontrol2();
            lockcontrol1();
            lockcontrol4();
            lockcontrol5();
            lockcontrol6();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flag = "4";
            unlockcontrol4();
            load_MATHANG();
            lockcontrol2();
            lockcontrol3();
            lockcontrol1();
            lockcontrol5();
            lockcontrol6();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flag = "5";
            unlockcontrol5();
            load_NHAPKHO();
            lockcontrol2();
            lockcontrol3();
            lockcontrol4();
            lockcontrol1();
            lockcontrol6();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            flag = "6";
            unlockcontrol6();
            load_XUATKHO();
            lockcontrol2();
            lockcontrol3();
            lockcontrol4();
            lockcontrol5();
            lockcontrol1();
        }
        #endregion
        #region thêm dữ liệu
        private void button1_Click(object sender, EventArgs e)
        {
            if(flag=="1")
            {
                if (textBox24.Text.ToString() == "" || textBox25.Text.ToString() == "" || dateTimePicker3.Text.ToString() == "" || textBox27.Text.ToString() == "" || textBox28.Text.ToString() == "" || textBox29.Text.ToString() == "")
                {
                    MessageBox.Show(" CHƯA NHẬP ĐẦY ĐỦ THÔNG TIN NHÂN VIÊN !");
                }
                else
                {
                    string query = string.Format("EXEC INSERT_NHANVIEN '" + textBox24.Text + "',N'" + textBox25.Text + "','" + dateTimePicker3.Text + "',N'" + textBox27.Text + "','" + textBox28.Text + "',N'" + textBox29.Text + "' ");
                    int result = DataProvider.Instance.ExecuteNonQuery(query);
                    load_NHANVIEN();
                }
               
            }
            if (flag == "2")
            {
                if (textBox32.Text.ToString() == "" || textBox31.Text.ToString() == "" || textBox30.Text.ToString() == "")
                {
                    MessageBox.Show(" CHƯA NHẬP ĐẦY ĐỦ THÔNG TIN TÀI KHOẢN !");
                }
                else
                {
                    string query = string.Format("EXEC INSERT_TAIKHOAN '" + textBox32.Text + "','" + textBox31.Text + "','" + textBox30.Text + "' ");
                    int result = DataProvider.Instance.ExecuteNonQuery(query);
                    LOAD_TAIKHOAN();
                }
            }
            if (flag == "3")
            {
                if (textBox1.Text.ToString() == "" || textBox2.Text.ToString() == "" || textBox3.Text.ToString() == "" || textBox4.Text.ToString() == "")
                {
                    MessageBox.Show(" CHƯA NHẬP ĐẦY ĐỦ THÔNG TIN NCC !");
                }
                else
                {
                    string query = string.Format("EXEC INSERT_NCC '" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "','" + textBox4.Text + "' ");
                    int result = DataProvider.Instance.ExecuteNonQuery(query);
                    load_NCC();
                }
            }
            if (flag == "4")
            {
                if (textBox5.Text.ToString() == "" || textBox6.Text.ToString() == "" || textBox7.Text.ToString() == "" || textBox8.Text.ToString() == "" || textBox9.Text.ToString() == "")
                {
                    MessageBox.Show(" CHƯA NHẬP ĐẦY ĐỦ THÔNG TIN MẶT HÀNG !");
                }
                else
                {
                    string query = string.Format("EXEC INSERT_MATHANG '" + textBox5.Text + "',N'" + textBox6.Text + "',N'" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "' ");
                    int result = DataProvider.Instance.ExecuteNonQuery(query);
                    load_MATHANG();
                }
            }
            if (flag == "5")
            {
                if (textBox14.Text.ToString() == "" || dateTimePicker1.Text.ToString() == "" || textBox12.Text.ToString() == "" || comboBox1.Text.ToString() == "" || comboBox2.Text.ToString() == "" || comboBox3.Text.ToString() == "" || comboBox4.Text.ToString() == "")
                {
                    MessageBox.Show(" CHƯA NHẬP ĐẦY ĐỦ THÔNG TIN NHẬP KHO !");
                }
                else
                {
                    string query = string.Format("EXEC INSERT_NHAPKHO '" + textBox14.Text + "','" + dateTimePicker1.Text + "','" + textBox12.Text + "','" + comboBox1.SelectedValue.ToString() + "','" + comboBox2.SelectedValue.ToString() + "','" + comboBox3.SelectedValue.ToString() + "','" + comboBox4.SelectedValue.ToString() + "' ");
                    int result = DataProvider.Instance.ExecuteNonQuery(query);
                    load_NHAPKHO();
                }
            }
            if (flag == "6")
            {
                if (textBox23.Text.ToString() == "" || dateTimePicker2.Text.ToString() == "" || textBox19.Text.ToString() == "" || comboBox5.Text.ToString() == "" || comboBox6.Text.ToString() == "" || comboBox7.Text.ToString() == "" || comboBox8.Text.ToString() == "")
                {
                    MessageBox.Show(" CHƯA NHẬP ĐẦY ĐỦ THÔNG TIN XUẤT KHO !");
                }
                else
                {
                    string query = string.Format("EXEC INSERT_XUATKHO '" + textBox23.Text + "','" + dateTimePicker2.Text + "','" + textBox19.Text + "','" + comboBox5.SelectedValue.ToString() + "','" + comboBox6.SelectedValue.ToString() + "','" + comboBox7.SelectedValue.ToString() + "','" + comboBox8.SelectedValue.ToString() + "' ");
                    int result = DataProvider.Instance.ExecuteNonQuery(query);
                    load_XUATKHO();
                }
            }
        }
        #endregion
        #region pick grip
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView2.CurrentRow.Index;
            if(flag=="1")
            {
                textBox24.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
                textBox25.Text = dataGridView2.Rows[index].Cells[1].Value.ToString();
                dateTimePicker3.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
                textBox27.Text = dataGridView2.Rows[index].Cells[3].Value.ToString();
                textBox28.Text = dataGridView2.Rows[index].Cells[4].Value.ToString();
                textBox29.Text = dataGridView2.Rows[index].Cells[5].Value.ToString();
            }
            if(flag=="2")
            {
                textBox32.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
                textBox31.Text = dataGridView2.Rows[index].Cells[1].Value.ToString();
                textBox30.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
            }
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            if (flag == "3")
            {
                textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[index].Cells[3].Value.ToString(); 
            }
            if (flag == "4")
            {
                textBox5.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                textBox6.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                textBox7.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                textBox8.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                textBox9.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            }
            if (flag == "5")
            {
                textBox14.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                textBox12.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                comboBox4.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            }
            if (flag == "6")
            {
                textBox23.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                dateTimePicker2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                textBox19.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                comboBox5.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                comboBox6.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                comboBox7.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                comboBox8.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            }
        }
        #endregion
        #region sửa dữ liệu
        private void button2_Click(object sender, EventArgs e)
        {
            if(flag=="1")
            {
                string query = string.Format("EXEC UPDATE_NHANVIEN '" + textBox24.Text + "',N'" + textBox25.Text + "','" + dateTimePicker3.Text + "',N'" + textBox27.Text + "','" + textBox28.Text + "',N'" + textBox29.Text + "' ");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                load_NHANVIEN();
            }
            if(flag=="2")
            {
                string query = string.Format("EXEC UPDATE_TAIKHOAN '" + textBox32.Text + "','" + textBox31.Text + "','" + textBox30.Text + "' ");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                LOAD_TAIKHOAN();
            }
            if(flag=="3")
            {
                string query = string.Format("EXEC UPDATE_NCC '" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "','" + textBox4.Text + "' ");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                load_NCC();
            }
            if(flag=="4")
            {
                string query = string.Format("EXEC UPDATE_MATHANG '" + textBox5.Text + "',N'" + textBox6.Text + "',N'" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "' ");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                load_MATHANG();
            }
            if (flag == "5")
            {
                string query = string.Format("EXEC UPDATE_NHAPKHO '" + textBox14.Text + "','" + dateTimePicker1.Text + "','" + textBox12.Text + "','" + comboBox1.SelectedValue.ToString() + "','" + comboBox2.SelectedValue.ToString() + "','" + comboBox3.SelectedValue.ToString() + "','" + comboBox4.SelectedValue.ToString() + "' ");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                load_NHAPKHO();
            }
            if (flag == "6")
            {
                string query = string.Format("EXEC UPDATE_XUATKHO '" + textBox23.Text + "','" + dateTimePicker2.Text + "','" + textBox19.Text + "','" + comboBox5.SelectedValue.ToString() + "','" + comboBox6.SelectedValue.ToString() + "','" + comboBox7.SelectedValue.ToString() + "','" + comboBox8.SelectedValue.ToString() + "' ");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                load_XUATKHO();
            }
        }
        #endregion
        #region xóa dữ liệu
        private void button3_Click(object sender, EventArgs e)
        {
            if(flag=="1")
            {
                string query = string.Format("EXEC DELETE_NHANVIEN '" + textBox24.Text + "' ");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                load_NHANVIEN();
            }
            if(flag=="2")
            {
                string query = string.Format("EXEC DELETE_TAIKHOAN '" + textBox32.Text + "' ");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                LOAD_TAIKHOAN();
            }
            if (flag == "3")
            {
                string query = string.Format("EXEC DELETE_MATHANG '" + textBox1.Text + "' ");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                load_MATHANG();
            }
            if (flag == "4")
            {
                string query = string.Format("EXEC DELETE_NCC '" + textBox5.Text + "' ");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                load_NCC();
            }
            if (flag == "5")
            {
                string query = string.Format("EXEC DELETE_NHAPKHO '" + textBox14.Text + "' ");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                load_NHAPKHO();
            }
            if (flag == "6")
            {
                string query = string.Format("EXEC DELETE_XUATKHO '" + textBox23.Text + "' ");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                load_XUATKHO();
            }
        }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
