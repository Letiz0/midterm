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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnectionStringBuilder scsb;
        string connect;

        
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
            }

            Sql.con.Close();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

        }
    }
}
