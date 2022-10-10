using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Nik
{
    public partial class cart : Form
    {
        public cart()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project");
        DataTable mainTable = new DataTable();

        private void database(string sql)
        {

            DataTable dt = new DataTable();
            var cmd = new MySqlCommand(sql, con);
            new MySqlDataAdapter(cmd).Fill(dt);
            con.Close();
            mainTable = dt;
            cartDt.DataSource = dt; 
        }
        private int cartSumPrice = 0;

        // วนหลูบรวมราคาจำนวนสินค้าทั้งหมด
        private void loadPrice()
        {
            for (int i = 0; i < mainTable.Rows.Count; i++)
            {
                cartSumPrice += Convert.ToInt32(mainTable.Rows[i][4]);
            }

        }
        private void cart_Load(object sender, EventArgs e)
        {
            con.Close();
            database($"SELECT * FROM cart WHERE email = '{Login.globalEmail}'"); //ดึงข้อมูลทั้งหมดของผู้ใช้คนนั้นจาก Table cart  
            loadPrice(); // แสดงราคารวมสินค้าทั้งหมด
        }

        private void btnBackToPd_Click(object sender, EventArgs e)
        {
            product pd = new product();
            pd.Show();
            this.Close(); 
        }
        DataTable visaTable = new DataTable();

        // ส่วนของการเช็ก visa 
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (getRealName.Text.Trim() != ""  && getAdress.Text.Trim() != "" && getPhone.Text.Trim() != "") // เช็กช่องที่ให้กรอกว่าไม่เท่ากับช่องว่างใช่มั้ย หากยังกรอกไม่ครบ ก็จะไปทำในส่วนของ else
            {
                var cmd = new MySqlCommand($"SELECT * FROM visa_card WHERE visaNum = '{visaNum.Text.Trim()}' AND holderName = '{holderName.Text.Trim()}'", con);
                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                visaTable = dt;
                if (dt.Rows.Count > 0) //เช็กว่ามีเลข visa ของคนนั้นหรือไม่ หากไม่มีก็จะไปทำในส่วนของ else 
                {
                    if (Convert.ToInt32(dt.Rows[0][2]) >= cartSumPrice) //เช็กเงินของบัตร visa คนนั้นว่า เงินใน visa นั้นมีมากกว่าราคารวมของสินค้าหรือไม่ หากไม่มากพอก็จะไปทำในส่วนของ else 
                    {
                        printPreviewDialog1.Document = printDocument1;
                        printPreviewDialog1.ShowDialog();
                        // และจะเอาข้อมูลของคนๆนั้น ไปใส่ใน Table data_user
                        cmd = new MySqlCommand($"INSERT INTO data_user (realname,my_product,my_adress,my_phone,email) VALUES ('{getRealName.Text.Trim()}'," +
                            $"'In My Product','{getAdress.Text.Trim()}','{getPhone.Text.Trim()}','{Login.globalEmail}')", con);

                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0) //หลังจากเอาข้อมูลไปใส่ใน table เรียบร้อย 
                                                       // ก็จะวนหลูบและเอาข้อมูลสินค้าทั้งหมดไปใส่ในส่วนของ table my_product และเก็บประวัติการซื้อขายลงใน table history
                        {
                            for (int i = 0; i < mainTable.Rows.Count; i++)
                            {
                                cmd = new MySqlCommand($"INSERT INTO my_product (id,product,color,count,price,email) VALUES " +
                                    $"('{mainTable.Rows[i][0]}','{mainTable.Rows[i][1]}','{mainTable.Rows[i][2]}','{mainTable.Rows[i][3]}','{mainTable.Rows[i][4]}','{Login.globalEmail}')", con);
                                cmd.ExecuteNonQuery();
                                cmd = new MySqlCommand($"INSERT INTO history (id,product,color,count,price,dateTime,email) VALUES " +
                                    $"('{mainTable.Rows[i][0]}','{mainTable.Rows[i][1]}','{mainTable.Rows[i][2]}','{mainTable.Rows[i][3]}','{mainTable.Rows[i][4]}','{DateTime.Now.ToString("dd-MM-yyyy , hh:mm:ss tt")}','{Login.globalEmail}')", con);
                                cmd.ExecuteNonQuery();
                            }
                            //และหลังจากนำข้อมูลทั้งหมดไปใส่ใน table ต่างๆเรียบร้อยแล้ว ก็จะลบสินค้าของจากตะกร้าทั้งหมด
                            cmd = new MySqlCommand($"DELETE FROM cart WHERE email = '{Login.globalEmail}'", con);
                            cmd.ExecuteNonQuery();

                            // อัพเดทเงินใน visa 
                            cmd = new MySqlCommand($"UPDATE visa_card SET money = '{Convert.ToInt32(dt.Rows[0][2]) - cartSumPrice}' WHERE money = '{dt.Rows[0][2]}'", con);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("จ่ายแล้ว");
                            con.Close();
                            database($"SELECT * FROM cart WHERE email = '{Login.globalEmail}'"); 
                         
                            product pd = new product();
                            pd.Show(); //เสร็จแล้วก็จะกลับไปที่หน้า product 
                            this.Close();
                        }
                        

                    }
                    else
                    {
                        MessageBox.Show("ยอดเงินของคุณไม่เพียงพอ");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Visa Number or Visa Holder Name");
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกให้ครบทุกช่อง");
            }
        }
        private string idOfItem = "";
        private string nameOfItem = "";
        private string colorOfItem = "";
        private string countOfItem = "";
        private string priceOfItem = "";

        // ตรงนี้จะเป็นข้อมูลตามแถวที่เราโดยสร้างตัวแปรมาเก็บของข้อมูลในแต่ละคอลัมน์
        private void cartDt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idOfItem = mainTable.Rows[e.RowIndex][0].ToString();
            nameOfItem = mainTable.Rows[e.RowIndex][1].ToString();
            colorOfItem = mainTable.Rows[e.RowIndex][2].ToString();
            countOfItem = mainTable.Rows[e.RowIndex][3].ToString();
            priceOfItem = mainTable.Rows[e.RowIndex][4].ToString();
        }
        //เช็คจำนวนของสิยค้าในสต๊อกปัจจุบัน
        private int checkQuantity (string product, string color)
        {
            int quantity = 0;
            var cmd = new MySqlCommand($"SELECT * FROM stock WHERE product = '{product}' AND color = '{color}'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                quantity = reader.GetInt32("quantity");
            }
            
            con.Close();
            return quantity;
        }

        // ในส่วนของบรรทัดนี้จะเป็นการลบข้อมูลที่ตามแถวที่เลือกแต่ลบเฉพาะของบัญชีนั้น
        private void btnDelItem_Click(object sender, EventArgs e)
        {
            var cmd = new MySqlCommand($"DELETE FROM cart WHERE id = '{idOfItem}' AND product = '{nameOfItem}' AND color = '{colorOfItem}' AND" +
                $" count = '{countOfItem}' AND price = '{priceOfItem}' AND email = '{Login.globalEmail}'", con);
            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("ลบเรียบร้อย"); // พอลบเรียบร้อยแล้วจะแสดงข้อความบอก
            }
            con.Close();

            //ตรงส่วนนี้ 164 - 174 จะเป็นการอัพเดทข้อมูลใน stock นำสินค้ากลับคืน stock
            int selectedRow = cartDt.CurrentCell.RowIndex;
            int cur_quantity = Convert.ToInt32(cartDt.Rows[selectedRow].Cells["count"].FormattedValue.ToString());
            string product = cartDt.Rows[selectedRow].Cells["product"].FormattedValue.ToString();
            string color = cartDt.Rows[selectedRow].Cells["color"].FormattedValue.ToString();
            cmd = new MySqlCommand($"UPDATE stock SET quantity = '{cur_quantity + checkQuantity(product, color)}' WHERE product = '{product}' AND color = '{color}'", con);
            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                database($"SELECT * FROM cart WHERE email = '{Login.globalEmail}'");
            }
            con.Close();
        }
        // ปริ้นใบเสร็จสลิบ
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Ratchada ผ้าไหม", new Font("TH SarabunPSK", 20, FontStyle.Bold), Brushes.Black, new Point(268, 40));
            e.Graphics.DrawString("วันที่   " + System.DateTime.Now.ToString("dd/MM/yyyy "), new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(570, 128));
            e.Graphics.DrawString("เวลา   " + System.DateTime.Now.ToString("HH : mm : ss น."), new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(571, 145));
            e.Graphics.DrawString("     68/2 บ้านเเดง ต.ยาง อ.บรบือ จ.มหาสารคาม ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(45, 80));
            e.Graphics.DrawString("    เบอร์ติดต่อ 0935627565  ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(45, 110));
            e.Graphics.DrawString("     พร้อมเพย์ 0935627565 ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(45, 140));

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(0, 150));
            e.Graphics.DrawString("ชื่อสินค้า", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(30, 170));
            e.Graphics.DrawString("จำนวน", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(650, 170));
            e.Graphics.DrawString("ราคา", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(740, 170));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(0, 200));
            string sql6 = $"SELECT * FROM `cart`  WHERE email = '{Login.globalEmail}' ";
            //ดึงข้อมูลมาจากดาต้าเบส
            MySqlConnection conn6 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
            MySqlCommand cmd6 = new MySqlCommand(sql6, conn6);
            conn6.Open();
            MySqlDataReader reader6 = cmd6.ExecuteReader();
            int y = 250, จำนวน = 0, ราคา = 0;
            while (reader6.Read())
            {
                e.Graphics.DrawString(reader6.GetString(1), new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(30, y));
                e.Graphics.DrawString(reader6.GetString(3), new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(650, y));
                e.Graphics.DrawString(reader6.GetString(4), new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(740, y));
                y += 25;
                จำนวน += reader6.GetInt32(3);
                ราคา += reader6.GetInt32(4);
            }
            conn6.Close();


            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(0, y + 20));
            e.Graphics.DrawString("รวมทั้งสิ้น    " + จำนวน + "   ชิ้น", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(312, y +45));
            e.Graphics.DrawString("จ่ายเงิน      " + ราคา + "    บาท", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(312, ((y - 10) + 45) + 45));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(0, ((((y - 10) + 45) + 45) + 45) + 10));
            e.Graphics.DrawString(" ****ขอบคุณที่อุดหนุนค่ะ**** ", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(275, ((((y + 10) + 45) + 45) + 45) + 10));
 
        }
    }
}
