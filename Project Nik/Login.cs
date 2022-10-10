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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project");
        DataTable mainTable = new DataTable();

        private void database(string sql)
        {
            con.Open();
            var cmd = new MySqlCommand(sql, con);
            DataTable dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            con.Close();
            mainTable = dt;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //เปิดหน้า register ขึ้นมา
            Form_Register form_Register = new Form_Register();
            form_Register.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home back2 = new Home();
            back2.Show();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            database("SELECT * FROM account1");//ดึงข้อมูลทั้งหมดมาเก็บไว้ใน DataTable เพื่อเตรียมความพร้อมที่จะนำข้อมูลไปเช็ก
        }

        public static string globalEmail = "yourEmail@gmail.com";
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (logEmail.Text.Trim() == "ratchadaphon.s@kkumail.com") //เช็กว่า ที่กรอกมานั้นตรงกับรหัสของแอดมินหรือไม่ หากไม่ตรง ก็จะไปทำในส่วนของ else
            {
                if (logEmail.Text.Trim() == "ratchadaphon.s@kkumail.com" && logPass.Text.Trim() == "1440601319511nik") //เช็กในส่วนของ email and password ว่าตรงกันหรือไม่ หากไม่ จะทำในส่วนของ else
                {
                    //หาก email and password ตรงกัน ก็จะเข้าสู่หน้าแอดมิน
                    Astock astck = new Astock();
                    astck.Show();
                    MessageBox.Show("ยินดีต้อนรับ Admin นิกกี้");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("รหัสผ่านไม่ถูกต้อง");
                }
            }
            else
            {
                if (logEmail.Text.Trim() != "" && logPass.Text.Trim() != "") //เช็กว่าทุกช่องนั้น จะต้องไม่เท่ากับ ช่องว่าง หรือเช็กว่ากรอกครบทุกช่องหรือยัง 
                {
                    DataTable dt = new DataTable();
                    var cmd = new MySqlCommand($"SELECT * FROM account1 WHERE email = '{logEmail.Text.Trim()}' AND pw = '{logPass.Text.Trim()}'", con);
                    new MySqlDataAdapter(cmd).Fill(dt);
                    if (dt.Rows.Count > 0) //เช็กว่ามีรหัสบัญชีของผู้ใช้คนนั้นอยู่หรือไม่ หากมีข้อมูล ค่าที่ได้จะเป็น 1 แต่ถ้าไม่มีค่าจะเป็น 0
                    {
                        globalEmail = logEmail.Text;
                        MessageBox.Show("ยินดีต้อนรับ"); 
                        

                        Home f1 = new Home();
                        Home.visa_visible = true; //ในส่วนของตรงนี้ จะเป็นการเปิด visible ของปุ่ม visa ในส่วนของหน้า Home จากเดิมที่เคยมีค่า false ก็จะกลายเป็น true 
                        f1.Show();
                        con.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("อีเมลหรือรหัสผ่านไม่ถูกต้อง");
                    }
                }
                else
                {
                    MessageBox.Show("กรุณากรอกให้ครบทุกช่อง");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
 
        }

        private void logPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
