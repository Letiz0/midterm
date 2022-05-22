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
            Sql.Connect();

            string sql = "select count(*) from member where email = @email and password = @pw;";
            SqlCommand cmd = new SqlCommand(sql, Sql.con);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@pw", txtPW.Text);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count != 0)
            {
                sql = "select id from member where email = @email";
                cmd = new SqlCommand(sql, Sql.con);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                int id = (int)cmd.ExecuteScalar();

                Hide();
                GlobalVar.formMain = new FormMain();
                GlobalVar.formMain.Show();
                
                Account.Email = txtEmail.Text;
                Account.Password = txtPW.Text;
                Account.Id = id;
            }
            else
            {
                MessageBox.Show("使用者信箱或密碼錯誤");
                txtPW.Text = "";
            }

            Sql.con.Close();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            groupBoxForget.Visible = true;
            btnSendEmail.Visible = true;
            btnForgetChange.Visible = true;
            btnSignup.Visible = false;
            btnLogin.Visible = false;
            groupBoxLogin.Visible = false;
            btnForget.Visible = false;
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
            Sql.Connect();
            string emailRepeat = "select count(*) from member where email = @email;";
            SqlCommand command = new SqlCommand(emailRepeat, Sql.con);
            command.Parameters.AddWithValue("@email", txtSignEmail.Text);
            int count = (int)command.ExecuteScalar();

            if (txtVerify.Text == verify && txtSignPW.Text == txtSignCheckPW.Text && count == 0)
            {
                string sign = "insert into member (email, password, location, phone, face, mail, success, nickname) values (@email, @password, @location, @phone, 1, 1, 0, @nickname);";
                SqlCommand cmd = new SqlCommand(sign, Sql.con);

                cmd.Parameters.AddWithValue("@email", txtSignEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtSignPW.Text);
                cmd.Parameters.AddWithValue("@location", txtSignLocation.Text);
                cmd.Parameters.AddWithValue("@phone", txtSignPhone.Text);
                cmd.Parameters.AddWithValue("@nickname", txt暱稱.Text);

                cmd.ExecuteNonQuery();

                

                sign = "insert into exchange_in (member_id) values ((select id from member where email = @email));";
                cmd = new SqlCommand(sign, Sql.con);
                cmd.Parameters.AddWithValue("@email", txtSignEmail.Text);

                cmd.ExecuteNonQuery();

                sign = "insert into exchange_out (member_id) values ((select id from member where email = @email));";
                cmd = new SqlCommand(sign, Sql.con);
                cmd.Parameters.AddWithValue("@email", txtSignEmail.Text);

                cmd.ExecuteNonQuery();


                Sql.con.Close();

                MessageBox.Show("註冊成功");

                btnSignup.Visible = true;
                btnForget.Visible = true;
                btnLogin.Visible = true;
                groupBoxLogin.Visible = true;
                groupBoxSignup.Visible = false;
                btnSendEmail.Visible = false;
                btnConfirmSign.Visible = false;
            }
            else
            {
                if (txtVerify.Text != verify)
                {
                    MessageBox.Show("驗證碼錯誤");
                    txtVerify.Text = "";
                }
                if (txtSignPW.Text != txtSignCheckPW.Text)
                {
                    MessageBox.Show("請再次確認密碼");
                    txtSignPW.Text = "";
                    txtSignCheckPW.Text = "";
                }
                if (count != 0)
                {
                    txtSignEmail.Text = "";
                    MessageBox.Show("此信箱已註冊");
                }
            }

            Sql.con.Close();
        }        

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            verify = random.Next(1000, 9999).ToString();

            if (txtSignEmail.Text != "" || txtForgetEmail.Text != "")
            {
                if (groupBoxSignup.Visible == true)
                {
                    Sql.Connect();
                    string isEmailRepeat = "select count(*) from member where email = @email;";
                    SqlCommand command = new SqlCommand(isEmailRepeat, Sql.con);
                    command.Parameters.AddWithValue("@email", txtSignEmail.Text);
                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
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
                    else
                    {
                        MessageBox.Show("此信箱已註冊");
                        txtSignEmail.Text = "";

                    }

                    Sql.con.Close();
                }
                else
                {
                    MailMessage msg = new MailMessage();
                    msg.To.Add(txtForgetEmail.Text);
                    msg.From = new MailAddress("a80679271@gmail.com", "switch遊戲交換平台", Encoding.UTF8);
                    msg.Subject = "重設密碼通知";
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
            else
            {
                MessageBox.Show("請輸入Email");
            }
        }

        private void btnForgetChange_Click(object sender, EventArgs e)
        {
            if (verify == txtForgetVerify.Text && txtForgetNewPW.Text == txtForgetConfirmPW.Text)
            {
                Sql.Connect();
                string sql = "update member set password = @newPW where email = @email";
                SqlCommand cmd = new SqlCommand(sql, Sql.con);
                cmd.Parameters.AddWithValue("@newPW", txtForgetNewPW.Text);
                cmd.Parameters.AddWithValue("@email", txtForgetEmail.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("密碼變更完成");
                
                groupBoxForget.Visible = false;
                btnForgetChange.Visible = false;
                btnSendEmail.Visible = false;
                btnSignup.Visible = true;
                btnForget.Visible = true;
                btnLogin.Visible = true;
                groupBoxLogin.Visible = true;

                Sql.con.Close();
            }
            else
            {
                if (txtForgetVerify.Text != verify)
                {
                    MessageBox.Show("驗證碼錯誤");
                    txtForgetVerify.Text = "";
                }
                if (txtForgetNewPW.Text != txtForgetConfirmPW.Text)
                {
                    MessageBox.Show("請再次確認密碼");
                    txtForgetNewPW.Text = "";
                    txtForgetConfirmPW.Text = "";
                }
            }
        }
    }
}
