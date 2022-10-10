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
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        private MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project");
        DataTable mainTable = new DataTable();

        private void database(string sql)
        {
            con.Open();
            var cmd = new MySqlCommand(sql,con);
            DataTable dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            mainTable = dt;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            //เช็กว่ากรอกทุกช่องครบหรือยัง หากยัง ก็จะไปทำในส่วนของ else 
            if (getUser.Text.Trim() != "" && getPass.Text.Trim() != "" && confirmPass.Text.Trim() != "" && getEmail.Text.Trim() != "")
            {
                if (getUser.Text.Trim().Length >= 8 && getUser.Text.Trim().Length <= 20) //เช็กตัวอักษรของช่อง username ว่ามีมากกว่า 8 และ น้อยกว่า 20 หรือไม่ หากไม่ ก็จะไปทำในส่วนของ else 
                {
                    if (getPass.Text.Trim().Length >= 6 && getPass.Text.Trim().Length <= 8) //เช็กว่าช่องของ password นั้นมีมากกว่า 6 และ น้อยกว่า 8 หรือไม่ หากไม่ ก็จะไปทำในส่วนของ else
                    {
                        if (confirmPass.Text.Trim() == getPass.Text.Trim()) //เช็กว่าช่องของ password นั้นตรงกันกับข่อง confirm password หรือไม่ หากไม่ ก็จะไปทำในส่วนของ else 
                        {
                            if (getEmail.Text.Trim().Contains("@gmail.com"))// เช็กว่า email นั้นมีในส่วนของ @gmail.com อยู่ในนั้นหรือลงท้ายหรือไม่ หากไม่ ก็จะไปทำในส่วนของๅ else  
                            {
                                var cmd = new MySqlCommand($"SELECT * FROM account1 WHERE email = '{getEmail.Text}'",con); // ทำการดึงข้อมูลบัญชีทั้งหมดมาเก็บไว้ใน DataTable ที่มีชื่อว่า dt
                                DataTable dt = new DataTable();
                                new MySqlDataAdapter(cmd).Fill(dt);
                                if (dt.Rows.Count > 0) //เช็กข้อมูลที่กรอกมานั้นว่ามี DataBase แล้วหรือยัง หากมีแล้วค่าที่ได้จะเป็น 1 พร้อมกับแสดงข้อความบอก แต่หากยังไม่มีค่าที่ได้จะเป็น 0 ก็จะไปทำในส่วนของ else  
                                {
                                    MessageBox.Show("อีเมลนี้ถูกใช้ไปแล้ว");
                                }
                                else
                                {
                                    //จะทำการ insert ข้อมูลลงใน DataBase พร้อมกับแสดงข้อความว่า สมัครใช้งานแล้ว
                                    var cmd2 = new MySqlCommand($"INSERT INTO account1 (username,pw,email) VALUES ('{getUser.Text.Trim()}'," +
                                $"'{getPass.Text.Trim()}','{getEmail.Text.Trim()}')", con);
                                    if (cmd2.ExecuteNonQuery() >= 0)
                                    {
                                        MessageBox.Show("สมัครใช้งานเรียบร้อยแล้ว");
                                        this.Close();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("อีเมลไม่ถูกต้อง");
                            }
                        }
                        else
                        {
                            MessageBox.Show("กรุณากรอกให้ตรงกัน");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ตัวอังษรต้องมี 6 - 8 ตัวเท่านั้น");
                    }
                }
                else
                {
                    MessageBox.Show("ตัวอังษรต้องมี 8 - 20 ตัวเท่านั้น");
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกให้ครบทุกช่อง");
            }
            con.Close();
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {

        }
    }
}
