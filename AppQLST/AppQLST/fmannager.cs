using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppQLST
{
    public partial class fmannager : Form
    {
        string username = "", password = "";
        bool quyen = false;
        string flag;
        private int index;
        public fmannager()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (quyen == true)
            {
                FormAdmin f = new FormAdmin();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("bạn không có quyền đăng nhập! ", "thông báo", MessageBoxButtons.OK);
            }
        }

        public fmannager(string username, string password, bool quyen)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

            this.quyen = quyen;
        }
        private void fmannager_Load(object sender, EventArgs e)
        {
            lock1();
            lock2();
            lock3();
            lock4();
            lock5();
            load_combobox3();
            load_combobox4();
           
        }
        #region lock
        public void lock1()
        {
            textBox3.ReadOnly = true;
            textBox3.Text = "";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Text = "";
            textBox2.ReadOnly = true;
            textBox2.Text = "";
            textBox4.ReadOnly = true;
            textBox4.Text = "";
            textBox7.ReadOnly = true;
            textBox7.Text = "";
            comboBox3.Enabled = false;
            comboBox3.Text = "";
        }
        public void lock2()
        {
            textBox5.ReadOnly = true;
            textBox5.Text = "";
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Text = "";
            comboBox4.Enabled = false;
            comboBox4.Text = "";
            textBox6.ReadOnly = true;
            textBox6.Text = "";
            textBox10.ReadOnly = true;
            textBox10.Text = "";
            textBox11.ReadOnly = true;
            textBox11.Text = "";
        }
        public void lock3()
        {
            textBox1.ReadOnly = true;
            textBox1.Text = "";
        }
        public void lock4()
        {
            textBox8.ReadOnly = true;
            textBox8.Text = "";
        }
        public void lock5()
        {
            textBox9.ReadOnly = true;
            textBox9.Text = "";
        }
        #endregion
        #region unlock
        public void unlock1()
        {
            textBox3.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            textBox2.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox7.ReadOnly = false;
            comboBox3.Enabled = true;
        }
        public void unlock2()
        {
            textBox5.ReadOnly = false;
            dateTimePicker2.Enabled = true;
            comboBox4.Enabled = true;
            textBox6.ReadOnly = false;
            textBox10.ReadOnly = false;
            textBox11.ReadOnly = false;
        }
        public void unlock3()
        {
            textBox1.ReadOnly = false;
        }
        public void unlock4()
        {
            textBox8.ReadOnly = false;
        }
        public void unlock5()
        {
            textBox9.ReadOnly = false;
        }
        #endregion
        #region load dulieu
        public void LOAD_HOADON()
        {
            dataGridView2.DataSource = DataProvider.Instance.ExecuteQuery("EXEC LOAD_HOADON");
        }
        public void LOAD_PHIEUKIEMKE()
        {
            dataGridView2.DataSource = DataProvider.Instance.ExecuteQuery("EXEC LOAD_PHIEUKIEMKE");
        }
        public void load_combobox3()
        {
            comboBox3.DataSource = DataProvider.Instance.ExecuteQuery("SELECT MSMH,TenMH FROM MATHANG");
            comboBox3.ValueMember = "MSMH";
            comboBox3.DisplayMember = "TenMH";
        }
        public void load_combobox4()
        {
            comboBox4.DataSource = DataProvider.Instance.ExecuteQuery("SELECT TenMH FROM MATHANG");
            comboBox4.ValueMember = "TenMH";
            comboBox4.DisplayMember = "TenMH";
        }
        #endregion
        #region hoadon
        private void button2_Click(object sender, EventArgs e)
        {
            string query = string.Format("EXEC INSERT_HOADON '" + textBox3.Text + "','" + dateTimePicker1.Text + "',N'" + textBox2.Text + "','" + textBox4.Text + "','" + textBox7.Text + "','" + comboBox3.SelectedValue.ToString() + "' ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = string.Format("EXEC DELETE_HOADON '" + textBox3.Text + "' ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            LOAD_HOADON();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            flag = "1";
            unlock1();
            lock2();
            LOAD_HOADON();
        }
        #endregion
        private void button10_Click(object sender, EventArgs e)
        {
            flag = "2";
            unlock2();
            lock1();
            LOAD_PHIEUKIEMKE();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            flag = "3";
            dataGridView2.DataSource = DataProvider.Instance.ExecuteQuery("EXEC LOAD_SOLUONG N'" + comboBox4.SelectedValue.ToString() + "'");
        }
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView2.CurrentRow.Index;
            if (flag == "1")
            {
                textBox3.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
                dateTimePicker1.Text = dataGridView2.Rows[index].Cells[1].Value.ToString();
                textBox2.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
                textBox4.Text = dataGridView2.Rows[index].Cells[3].Value.ToString();
                textBox7.Text = dataGridView2.Rows[index].Cells[4].Value.ToString();
                comboBox3.Text = dataGridView2.Rows[index].Cells[5].Value.ToString();
            }
            if (flag == "2")
            {
                textBox5.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
                dateTimePicker2.Text = dataGridView2.Rows[index].Cells[1].Value.ToString();
                comboBox4.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
                textBox6.Text = dataGridView2.Rows[index].Cells[3].Value.ToString();
                textBox10.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
                textBox11.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
            }
            if (flag == "3")
            {
                textBox6.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string query = string.Format("EXEC DELETE_PHIEUKIEMKE '" + textBox5.Text + "' ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            LOAD_PHIEUKIEMKE();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            flag = "3";
            unlock3();
            lock4();
            lock5();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            flag = "4";
            unlock4();
            lock3();
            lock5();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            flag = "5";
            unlock5();
            lock3();
            lock4();
        }
        public DataTable timkiem_mathang(string data)
        {
            string query = string.Format("EXEC FIND_MATHANG N'{0}'", data);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable timkiem_ncc(string data)
        {
            string query = string.Format("EXEC load_find_ncc N'{0}'", data);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable timkiem_qh(string data)
        {
            string query = string.Format("EXEC find_qh N'{0}'", data);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(flag=="3")
            {
                dataGridView1.DataSource = timkiem_mathang(textBox1.Text);
            }
            if(flag=="4")
            {
                dataGridView1.DataSource = timkiem_ncc(textBox8.Text);
            }
            if(flag=="5")
            {
                dataGridView1.DataSource = timkiem_qh(textBox9.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = string.Format("EXEC INSERT_PHIEUKIEMKE '" + textBox5.Text + "','" + dateTimePicker2.Text + "',N'" + comboBox4.SelectedValue.ToString() + "','" + textBox6.Text + "','" + textBox10.Text + "','" + textBox11.Text + "' ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            LOAD_PHIEUKIEMKE();
        }

       

    }
}
