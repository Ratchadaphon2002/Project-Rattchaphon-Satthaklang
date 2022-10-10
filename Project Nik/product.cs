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
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }
        private MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project");
        DataTable mainTable = new DataTable();

        private void database(string sql)
        {
            if (con.State == ConnectionState.Closed) //เช็กสถานะการเชื่อมต่อ
            {
                con.Open();
            }
            var cmd = new MySqlCommand(sql, con);
            DataTable dt = new DataTable(); 
            new MySqlDataAdapter(cmd).Fill(dt);
            // ดึงข้อมูลมาเก็บไว้ใน DataTable dt และเอาข้อมูลจาก dt ไปเติมลงใน mainTable ด้วย เพื่อที่ทุก function หรือทุกๆ Form จะสามารถเรียกใช้ได้
       
            con.Close();
            mainTable = dt;
            data.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Home back1 = new Home();
            back1.Show();
            this.Hide();
        }

        // บรรทัดแรกที่จะทำ 
        private void product_Load(object sender, EventArgs e)
        {
            database("SELECT * FROM stock"); 
            //ดึงข้อมูลทั้งหมดจาก table stock ไปเก็บไว้ใน DataTable ที่มีชื่อว่า dt จากนั้นให้เอาข้อมูลทั้งหมดไปแสดงใน DataGridView
            
        }

        string rowID = "1";
        int priceItem = 0;

        #region button pay
        //ส่วนของบรรทัดนี้ จะทำการดึงข้อมูลทั้งหมดจากแถวที่เราเลือกลงไปเก็บไว้ใน Table cart โดยที่ insert email ของคนๆนั้นไปด้วยเพื่อที่จะได้แยกเป็นข้อมูลกัน
        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (priceItem != 0) //เช็กราคาของสินค้าว่าไม่เท่ากับ 0 ใช่มั้ย
            {
                
                con.Open();
                var cmd = new MySqlCommand($"INSERT INTO cart (id,product,color,count,price,email) VALUES ('{rowID}','{labelNameOfItem.Text}'," +
                    $"'{labelColorOfItem.Text}','{countOfItem.Value}','{priceItem*countOfItem.Value}','{Login.globalEmail}')",con);
                if (cmd.ExecuteNonQuery() >= 0)
                {
                    MessageBox.Show("เพิ่มสินค้าในตะกร้าสำเร็จ");
                }
                con.Close();

                //และในส่วนของบรรทัดนี้จะเป็นการลดจำนวณสินค้าที่มีอยู่ใน stock ตามจำนวนที่ถูกหยิบออกไป
                int selectedRow = data.CurrentCell.RowIndex;
                int cur_quantity = Convert.ToInt32(data.Rows[selectedRow].Cells["quantity"].FormattedValue.ToString());
                string product = data.Rows[selectedRow].Cells["productClmn"].FormattedValue.ToString();
                string color = data.Rows[selectedRow].Cells["color"].FormattedValue.ToString();
                cmd = new MySqlCommand($"UPDATE stock SET quantity = '{cur_quantity - countOfItem.Value}' WHERE product = '{product}' AND color = '{color}'", con);
                con.Open();

                if (cmd.ExecuteNonQuery() >= 0)
                {
                    database("SELECT * FROM stock");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("กรุาเลือกจำนวณสินค้า");
            }
        }
        #endregion

        private void btnCartPage_Click(object sender, EventArgs e)
        {
            cart ctp = new cart();
            ctp.Show();
            this.Close();
        }

        private void countOfItem_ValueChanged(object sender, EventArgs e)
        {
            labelPriceOfItem.Text = $"{priceItem * countOfItem.Value}.00 บาท";
        }

        // ในส่วนของบรรทัดนี้จะเป็นการเก็บข้อมูลในแต่ละคอมลัมน์ที่เราคลิก และแสดงผลข้อมูลตามที่เราเลือก
        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string itemPic = mainTable.Rows[e.RowIndex][0].ToString(); // คอลัมน์ที่ 0 จะเป็น column id ใน Table Stock
            rowID = itemPic; //ตรงนีิจะเป็นการเอาข้อมูลจาก itemPic ไปเก็บไว้ในตัวแปร rowID ด้วย เพื่อในส่วนของการทำงานที่เราจะทำต่อไป
            labelColorOfItem.Text = mainTable.Rows[e.RowIndex][2].ToString(); // คอมลัมน์ 2 จะเป็นสีของผ้า
            labelPriceOfItem.Text = $"{mainTable.Rows[e.RowIndex][3]}.00 บาท"; //ส่วนตรงนี้จะเป็นคอลัมน์ของราคา
            priceItem = (int)mainTable.Rows[e.RowIndex][3]; 
            //เราจะเอาราคาที่มี Type เป็นๅ string แปลงเป็น int และนำไปเก็บไว้ในตัวแปร priceItem เพื่อที่ว่าจะนำไปใช้ในส่วนของการคำนวณราคา
            showPic.Image = new Bitmap(string.Format(@"{0}", mainTable.Rows[e.RowIndex][5]));// คอลัมน์ที่ 5 จะเป็นที่อยู่ของ path รูปภาพของสืนค้า
        }
    }
}
