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
    public partial class Astock : Form
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
        public Astock()
        {
            InitializeComponent();
        }

        private void Astock_Load(object sender, EventArgs e)
        {
            database($"SELECT * FROM stock");
            dataHistory.DataSource = mainTable;
        }

        private void dataHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //function of turn off all panel 
        private void turnOffPanel()
        {
            panelAdd.Visible = false;
            panelDel.Visible = false;
            panelEdit.Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            turnOffPanel(); //ซ่อนทุก Visible panel  
            panelAdd.Visible = true; // เปิด Visible เฉพาะของ Panel Add 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            turnOffPanel();//ซ่อนทุก Visible panel  
            panelEdit.Visible = true; // เปิด Visible เฉพาะของ Panel Edit
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            turnOffPanel();//ซ่อนทุก Visible panel  
            panelDel.Visible = true; // เปิด Visible เฉพาะของ Panel Delete
        }
        string itemNo = "1";
        string itemColumn = "product";
        private void dataHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ข้อมูลแต่ละคอลัมน์จะถูกเก็บไว้ในแต่ละตัวแปรที่สร้างไว้
            labelProduct.Text = mainTable.Rows[e.RowIndex][1].ToString();
            labelColor.Text = mainTable.Rows[e.RowIndex][2].ToString();
            labelPrice.Text = mainTable.Rows[e.RowIndex][3].ToString();
            labelQ.Text = mainTable.Rows[e.RowIndex][4].ToString();
            tbxNewData.Text = dataHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            itemNo = mainTable.Rows[e.RowIndex][0].ToString();
            itemColumn = dataHistory.Columns[e.ColumnIndex].DataPropertyName.ToString();
        }

        private void btnOkEdit_Click(object sender, EventArgs e)
        {
            //ตรงนี้จะเป็นในส่วนของการอัพเดทตามแถวที่เลือกไว้
            con.Open();
            var cmd = new MySqlCommand($"UPDATE stock SET {itemColumn} = '{tbxNewData.Text}' WHERE id = '{itemNo}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            database("SELECT * FROM stock");
            dataHistory.DataSource = mainTable;
        }

        private void btnOkDel_Click(object sender, EventArgs e)
        {
            //ตรงนี้จะเป็นการลบข้อมูลตามที่เลือกไว้
            con.Open();
            var cmd = new MySqlCommand($"DELETE FROM stock WHERE id = '{itemNo}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            database("SELECT * FROM stock");
            dataHistory.DataSource = mainTable;
        }

        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            //และในส่วนของตรงนี้จะเป็นการอัพโหลดรูปภาพ
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                labelAddressPic.Text = open.FileName;
            }
        }

        private void btnOkAdd_Click(object sender, EventArgs e)
        {
            //ส่วนของการ insert ข้อมูลโดยจะทำการ insert ข้อมูลลงไปในDatabaseแต่การinsert รูปภาพนั้นจะทำการเอาๅ path ของรูปไป insert แทน
            con.Open();
            var cmd = new MySqlCommand($"INSERT INTO stock (product,color,price,quantity,picture) VALUES ('{tbxPrct.Text}'," +
                $"'{tbxColor.Text}','{nmberPrice.Value}','{nmberQntity.Value}','{labelAddressPic.Text.Replace("\\","\\\\")}')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            database("SELECT * FROM stock");
            dataHistory.DataSource = mainTable;
        }

        private void btnBack2Home_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            Ahistory ahistory = new Ahistory();
            ahistory.Show();
            this.Hide();
        }

        private void panelDel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
