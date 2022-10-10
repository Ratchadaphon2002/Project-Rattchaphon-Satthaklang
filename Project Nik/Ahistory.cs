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
    public partial class Ahistory : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project");
        DataTable mainTable = new DataTable();
        private void database(string sql)
        {
            con.Open();
            DataTable dt = new DataTable();
            var cmd = new MySqlCommand(sql, con);
            new MySqlDataAdapter(cmd).Fill(dt);
            mainTable = dt;
            con.Close();
        }
        public Ahistory()
        {
            InitializeComponent();
        }
       
        private void dataHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //ส่วนของการแสดง history ของ admin จะทำการเอาเงื่อนไข where ออกเพื่อที่ว่าจะได้เห็น history ของทุกคน
        private void Ahistory_Load(object sender, EventArgs e)
        {
            database($"SELECT * FROM history");
            dataHistory.DataSource = mainTable;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //ตรงนี้จะเป็นการค้นหาข้อมูลโดยอ้างอิงการค้นหาโดยคอลัมน์ product or email or dataTime or price
        private void btnSrch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(mainTable);
            dv.RowFilter = $"color Like '%{search.Text}%' OR product Like '%{search.Text}%' OR email Like '%{search.Text}%' OR dateTime Like '%{search.Text}%'OR price Like '%{search.Text}%'";
            dataHistory.DataSource = dv;
        }

        private void btnBack2Home_Click(object sender, EventArgs e)
        {
            Astock astck = new Astock();
            astck.Show();
            this.Close();
        }
    }
}
