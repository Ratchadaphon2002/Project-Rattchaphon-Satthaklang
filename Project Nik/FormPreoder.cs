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
    public partial class FormPreoder : Form
    {
        public FormPreoder()
        {
            InitializeComponent();
        }

        private MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project");
        DataTable mainTable = new DataTable();

        private void button4_Click(object sender, EventArgs e)
        {
            Home f1 = new Home();
            f1.Show();
            this.Close();
        }

        DataTable visaTable = new DataTable(); 
        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            if (getRealName.Text.Trim() != "" && getMyProduct.Text.Trim() != "" && 
                //เช็กว่ากรอกข้อมูลครบทุกช่องหรือยัง หากยัง ก็จะไปทำในส่วนของ else 
                getAdress.Text.Trim() != "" && getPhone.Text.Trim() != "")
            {
                var cmd = new MySqlCommand($"SELECT * FROM visa_card WHERE visaNum = '{visaNum.Text.Trim()}' AND holderName = '{holderName.Text.Trim()}'", con);
                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt); // ดึงข้อมูล visa มาเก็บไว้ในตัวแปร DataTable ที่มีชื่อว่า dt เพื่อที่จะเช็กจำนวนเงิน
                visaTable = dt;
                if (dt.Rows.Count > 0) //เช็กว่ามีบัตร visa ของที่กรอกมาว่า มีหรือไม่ หากไม่มีก็จะไปทำในส่วนของ else 
                {
                    if (Convert.ToInt32(dt.Rows[0][2]) >= 4000) //เช็กจำนวนเงินในบัตรว่ามีมากกว่าราคาที่กำหนดไว้หรือไม่ นั่นก็คือ 4000
                    {
                        printPreviewDialog1.Document = printDocument1;
                        printPreviewDialog1.ShowDialog();
                        // จากนั้นก็จะนำข้อมูลทั้งหมดไป insert ใน data_user
                        cmd = new MySqlCommand($"INSERT INTO data_user (realname,my_product,my_adress,my_phone,email) VALUES ('{getRealName.Text.Trim()}'," +
                            $"'{getMyProduct.Text.Trim()}','{getAdress.Text.Trim()}','{getPhone.Text.Trim()}','{Login.globalEmail}')", con);
                        if (cmd.ExecuteNonQuery() > 0) // เสร็จแล้วก็จะอัพเดทเงินใน visa
                        {
                            cmd = new MySqlCommand($"INSERT INTO history (id,product,color,count,price,dateTime,email) VALUES " +
                                $"('0','{getMyProduct.Text}','','1','4000','{DateTime.Now.ToString("dd-MM-yyyy , hh:mm:ss tt")}','{Login.globalEmail}')", con);
                            cmd.ExecuteNonQuery();


                            cmd = new MySqlCommand($"UPDATE visa_card SET money = '{Convert.ToInt32(dt.Rows[0][2]) - 4000}' WHERE money = '{dt.Rows[0][2]}'",con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("เพิ่มช้อมูลสำเร็จ");
                         
                            Home home = new Home();
                            home.Show();
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
            con.Close();
        }

        private void getPhone_TextChanged(object sender, EventArgs e)
        {

        }
        //สลิป
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("Ratchada ผ้าไหม", new Font("TH SarabunPSK", 20, FontStyle.Bold), Brushes.Black, new Point(268, 40));
            e.Graphics.DrawString("วันที่   " + System.DateTime.Now.ToString("dd/MM/yyyy "), new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(570, 128));
            e.Graphics.DrawString("เวลา   " + System.DateTime.Now.ToString("HH : mm : ss น."), new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(571, 145));
            e.Graphics.DrawString("    68/2 บ้านเเดง ต.ยาง อ.บรบือ จ.มหาสารคาม  ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(45, 80));
            e.Graphics.DrawString("    เบอร์ติดต่อ 0935627565  ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(45, 110));
            e.Graphics.DrawString("     พพ 0935627565 ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(45, 140));

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(0, 150));
            e.Graphics.DrawString("ชื่อสินค้า", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(30, 170));
            e.Graphics.DrawString("จำนวน", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(650, 170));
            e.Graphics.DrawString("ราคา", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(740, 170));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(0, 200));
            e.Graphics.DrawString(getMyProduct.Text, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(30, 250));
            e.Graphics.DrawString("1", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(650, 250));
            e.Graphics.DrawString("4000", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(740, 250));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(0, 275 + 20));
            e.Graphics.DrawString("รวมทั้งสิ้น    1   ชิ้น", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(312, 275 + 45));
            e.Graphics.DrawString("จ่ายเงิน      4000    บาท", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(312, ((275 - 10) + 45) + 45));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(0, ((((275 - 10) + 45) + 45) + 45) + 10));
            e.Graphics.DrawString(" ****ขอบคุณที่อุดหนุนค่ะ**** ", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new Point(275, ((((275 + 10) + 45) + 45) + 45) + 10));

        }
    }
}
