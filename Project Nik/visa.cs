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
    public partial class visa : Form
    {
        public visa()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project");
        DataTable visaTable = new DataTable();

        private void database(string email)
        {
            con.Open();
            var cmd = new MySqlCommand($"SELECT * FROM visa_card WHERE email = '{visaEmail.Text}'", con);
            DataTable dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt); //ดึงข้อมูลมาเก็บใน DataTable ที่มีชื่อว่า dt
            visaTable = dt;
            con.Close();
            if (visaTable.Rows.Count > 0) // เช็กว่า email ของคนนั้นได้ทำการสมัคร visa ไว้หรือยัง ถ้าสมัครแล้วค่าที่ได้จะเป็น 1 แต่ถ้ายังไม่สมัคร ค่าที่ได้จะเป็น 0 และจะทำในส่วนของ else
            {
                panelCreateVisa.Visible = false; // panel สร้าง visa จะถูกซ่อนไว้
                panelVisa.Visible = true; // panel แสดงข้อมูล Detail จะถูกแสดงขึ้น
                holdername.Text = visaTable.Rows[0][1].ToString(); 
                visaNumber.Text = visaTable.Rows[0][0].ToString();
                visaMoney.Text = String.Format(new CultureInfo("TH"), "{0:C}", visaTable.Rows[0][2]); // แสดงจำนวนเงินในบัญชี
            }
            else
            {
                panelCreateVisa.Visible = true; // panel สร้าง visa จะถูกแสดง
                panelVisa.Visible = false; // panel แสดงข้อมูล Detail จะถูกซ่อนไว้
            }
        }
        private void visa_Load(object sender, EventArgs e)
        {
            visaEmail.Text = Login.globalEmail;
            database(visaEmail.Text); // โยน email ไปให้ function database เช็กว่ามีการสมัคร visa หรือยัง
        }

        private void btn_cancel_visa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // ปุ่ม refill จะทำการอัพเดทเงิน
        private void btn_refill_Click(object sender, EventArgs e)
        {
            con.Open();
            var cmd = new MySqlCommand($"UPDATE visa_card SET money = '5000000' WHERE money = '{visaTable.Rows[0][2]}' AND email = '{visaEmail.Text}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            database(visaEmail.Text);
        }

        private void btn_OK_visa_Click(object sender, EventArgs e)
        {
            if (tbxVisaHolderName.Text.Trim() != "") //เช็กว่าได้กรอกชื่อบัตรหรือยัง หากยัง จะไปทำในส่วนของ else 
            {
                // เช็กว่าตัวอักษรของช่องกรอกชื่อนั้นมีมากกว่า 5 หริอน้อยกว่า 10 หรือไม่ หากไม่ ก็จะไปทำในส่วนของ else 
                if (tbxVisaHolderName.Text.Length >= 5 && tbxVisaHolderName.Text.Length <=10)
                {
                    string newHoldername = $"4000{new Random().Next(0, 999999999)}10";// ทำการ random เลขบัตร visa 
                    visaMoney.Text = "0";
                    con.Open();
                    //ทำการ insert ข้อมูลทั้งหมดลงใน DataBase
                    var cmd = new MySqlCommand($"INSERT INTO visa_card (visaNum,holderName,money,email) VALUES ('{newHoldername}'," +
                        $"'{tbxVisaHolderName.Text.Trim()}','0','{visaEmail.Text}')",con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("สมัคร VISA เสร็จเรียบร้อย");
                    panelCreateVisa.Visible = false;  // panel สร้าง visa จะถูกซ่อนไว้
                    database(visaEmail.Text); // ทำการโหลดข้อมูลมาแสดง
                    panelVisa.Visible = true; // panel แสดงข้อมูล Detail จะถูกแสดงขึ้น

                }
                else
                {
                    MessageBox.Show("ตัวอักษรควรมีตั้งแต่ 5 - 10 ตัว");
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกชื่อ VISA ของคุณ");
            }
        }

        private void tbxVisaHolderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) //ให้กรอกได้เฉพาะตัวอักษรเท่านั้น
            {
                e.Handled = true;
            }
        }
    }
}
