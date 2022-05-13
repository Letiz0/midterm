using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace midterm_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account member = new Account();
            member.Email = txtEmail.Text;
            member.Password = txtPW.Text;

            Sql.Connect();
            string sql = "select count(*) from member where email = @email and password = @pw;";
            SqlCommand cmd = new SqlCommand(sql, Sql.con);
            cmd.Parameters.AddWithValue("@email", member.Email);
            cmd.Parameters.AddWithValue("@pw", member.Password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count != 0)
            {
                GlobalVar.form1 = this;
                this.Hide();
                GlobalVar.formMain = new FormMain();
                GlobalVar.formMain.Show();
            }
            else
            {
                MessageBox.Show("使用者信箱或密碼錯誤");
                member = null;
            }

            Sql.con.Close();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            btnSignup.Visible = false;
            btnForget.Visible = false;
            btnLogin.Visible = false;
            groupBoxLogin.Visible = false;
            groupBoxSignup.Visible = true;
            btnSendEmail.Visible = true;
            btnConfirmSign.Visible = true;
        }
        
        Random random = new Random();
        string verify;
        private void btnConfirmSign_Click(object sender, EventArgs e)
        {
            if (txtVerify.Text == verify)
            {
                MessageBox.Show("註冊成功");
            }
            else
            {
                MessageBox.Show("驗證碼錯誤");
            }
        }        

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            verify = random.Next(1000, 9999).ToString();

            MailMessage msg = new MailMessage();
            msg.To.Add(txtSignEmail.Text);
            msg.From = new MailAddress("a80679271@gmail.com", "switch遊戲交換平台", Encoding.UTF8);
            msg.Subject = "註冊通知";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = "您的驗證碼是 : " + verify; 
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("a80679271@gmail.com", "sopp5731"); 
            client.Host = "smtp.gmail.com"; 
            client.Port = 25; 
            client.EnableSsl = true; 
            client.Send(msg); 
            client.Dispose();
            msg.Dispose();
            MessageBox.Show("已發送郵件，請於確認後輸入驗證碼");
        }
    }
}
