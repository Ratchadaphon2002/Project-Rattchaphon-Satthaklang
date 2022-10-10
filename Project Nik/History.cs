using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Nik
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project");
        DataTable mainTable = new DataTable();

        private void btnBack2Home_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Close();
        }

        private void database(string sql)
        {
            con.Open();
            DataTable dt = new DataTable();
            var cmd = new MySqlCommand(sql, con);
            new MySqlDataAdapter(cmd).Fill(dt);
            mainTable = dt;
            con.Close();
        }
        private void History_Load(object sender, EventArgs e)
        {
            database($"SELECT * FROM history WHERE email = '{Login.globalEmail}'"); 
            //ทำการดึง history ของ email คนนั้นๆมาแสดงใน DataGridView
            dataHistory.DataSource = mainTable;
        }

        // ในส่วนของการ search
        private void search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(mainTable);
            dv.RowFilter = $"color Like '%{search.Text}%' OR price Like '%{search.Text}%'";
            dataHistory.DataSource = dv;
        }

        //ในส่วนของการคลิกค้นหาข้อมูล
        private void btnSrch_Click(object sender, EventArgs e)
        {
            database($"SELECT * FROM history WHERE email = '{Login.globalEmail}' AND color Like '%{search.Text}%' OR price Like '%{search.Text}%'");
            dataHistory.DataSource = mainTable;
        }
        private string No = "";
        private void dataHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            No = mainTable.Rows[e.RowIndex][0].ToString(); //ตัวแปร No จะเป็นตัวแปรไว้เก็บตัวที่เป็น Primary key ไว้
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (No != "") //เช็กว่า ตัวแปร No ไม่เท่ากับ ช่องว่างใช่หรือไม่ หากไม่ ก็จะไปทำในส่วนของ else 
            {
                // ทำการลบข้อมูลตามแถวที่เลือกและตามที่เงือนไขกำหนด
                var cmd = new MySqlCommand($"DELETE FROM history WHERE email = '{Login.globalEmail}' AND No = '{No}'",con);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0) { MessageBox.Show("Delete Done"); }
                con.Close();
                database($"SELECT * FROM history WHERE email = '{Login.globalEmail}'");
                dataHistory.DataSource = mainTable;
            }
            else
            {
                MessageBox.Show("Please Select your item to Delete First");
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            con.Open();
            //ทำการลบข้อมูลทั้งหมดของบัญชี email คนนั้น
            var cmd = new MySqlCommand($"DELETE FROM history WHERE email = '{Login.globalEmail}'",con);
            if (cmd.ExecuteNonQuery() > 0) { MessageBox.Show("Delete All Done"); }
            con.Close();
            database($"SELECT * FROM history WHERE email = '{Login.globalEmail}'");
            dataHistory.DataSource = mainTable;
        }
    }
}
