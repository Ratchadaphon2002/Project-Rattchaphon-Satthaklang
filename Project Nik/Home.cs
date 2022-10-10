using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Nik
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        //MySqlConnection con = new MySqlConnection("localhost=host;user=root;password=;database=project");
        //DataTable visaTable = new DataTable();
        //private void database(string email)
        //{
        //    con.Open();
        //    var cmd = new MySqlCommand($"SELECT * FROM visa_card WHERE email = '{Login.globalEmail.Trim()}'", con);
        //    DataTable dt = new DataTable();
        //    new MySqlDataAdapter(cmd).Fill(dt);
        //    visaTable = dt;
        //    con.Close();
        //}
        private void button3_Click(object sender, EventArgs e)
        {
            product pro = new product();
            pro.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPreoder pre = new FormPreoder();
            pre.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();
        }

        //ซ่อนวีซ่าในกรณีที่ยังไม่เข้าสู่ระบบ
        public static bool visa_visible = false;
        private void Home_Load(object sender, EventArgs e)
        {
            btn_visa.Visible = visa_visible;
        }

        private void btn_visa_Click(object sender, EventArgs e)
        {
            visa vs = new visa();
            vs.ShowDialog();
        }
    }
}
