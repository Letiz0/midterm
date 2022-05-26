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

namespace midterm_project
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            Sql.Connect();
            string sql = "select location, phone, nickname from member where id = @id";
            SqlCommand cmd = new SqlCommand(sql, Sql.con);
            cmd.Parameters.AddWithValue("@id", Account.Id);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtLocation.Text = reader[0].ToString();
                txtPhone.Text = reader[1].ToString();
                txtNickname.Text = reader[2].ToString();
            }

            reader.Close();
            Sql.con.Close();
        }

        private void Member_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
            GlobalVar.formMain.Show();
        }

        private void btn更改密碼_Click(object sender, EventArgs e)
        {
            panel更改密碼.Visible = true;
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            Sql.Connect();
            SqlCommand cmd = new SqlCommand("", Sql.con);
            cmd.CommandText = "update member set location = @location, phone = @phone, nickname = @nickname where id = @id";
            cmd.Parameters.AddWithValue("@location", txtLocation.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@nickname", txtNickname.Text);
            cmd.Parameters.AddWithValue("@id", Account.Id);

            cmd.ExecuteNonQuery();

            if (panel更改密碼.Visible == true)
            {
                bool pwConfirm = (txt新密碼.Text != "") && (txt新密碼.Text == txt確認新密碼.Text);

                cmd.CommandText = "select password from member where id = @id";
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                
                if ((reader[0].ToString() == txt舊密碼.Text) && pwConfirm )
                {
                    reader.Close();
                    cmd.CommandText = "update member set password = @password where id = @id";
                    cmd.Parameters.AddWithValue("@password", txt新密碼.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("會員資料&密碼修改成功");

                    txt舊密碼.Text = "";
                    txt新密碼.Text = "";
                    txt確認新密碼.Text = "";
                }
                else if(reader[0].ToString() != txt舊密碼.Text)
                {
                    MessageBox.Show("舊密碼輸入錯誤");
                    txt舊密碼.Text = "";
                    txt新密碼.Text = "";
                    txt確認新密碼.Text = "";
                }
                else if (pwConfirm == false)
                {
                    MessageBox.Show("新密碼不可為空或輸入不相符");
                    txt舊密碼.Text = "";
                    txt新密碼.Text = "";
                    txt確認新密碼.Text = "";
                }                
            }
            else
            {
                MessageBox.Show("會員資料修改成功");
                txt舊密碼.Text = "";
                txt新密碼.Text = "";
                txt確認新密碼.Text = "";
            }

            Sql.con.Close();
        }

        private void btn會員資料變更_Click(object sender, EventArgs e)
        {
            panel資料變更.Visible = true;
            panel歷史交易紀錄.Visible = false;
        }

        private void btn交易邀請管理_Click(object sender, EventArgs e)
        {
            panel資料變更.Visible = false;
            panel更改密碼.Visible = false;
            panel歷史交易紀錄.Visible = false;
        }

        private void btn歷史交易紀錄_Click(object sender, EventArgs e)
        {
            panel資料變更.Visible = false;
            panel更改密碼.Visible = false;
            panel歷史交易紀錄.Visible = true;
        }
    }
}
