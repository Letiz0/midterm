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
using System.Collections;

namespace midterm_project
{
    public partial class Publish : Form
    {
        public Publish()
        {
            InitializeComponent();
        }

        Dictionary<int, string> game = new Dictionary<int, string>();

        List<int> exchangeIn = new List<int>();
        List<int> exchangeOut = new List<int>();

        void SetProgress()
        {
            if (listBox借入.Visible)
            {
                progressBar1.Value = exchangeIn.Count;
            }
            else if (listBox借出.Visible)
            {
                progressBar1.Value = exchangeOut.Count;
            }
            
        }
        void LoadPic()
        {
            Sql.Connect();

            string sql = "select * from game;";
            SqlCommand cmd = new SqlCommand(sql, Sql.con);
            SqlDataReader reader = cmd.ExecuteReader();

            string fileName;

            while (reader.Read())
            {
                fileName = @"images\" + (string)reader["pic"];
                game.Add((int)reader["id"], (string)reader["name"]);
                imageList1.Images.Add(Image.FromFile(fileName));
            }

            reader.Close();
            Sql.con.Close();
        }

        void PicMode(string search)
        { 
            if (search == "")
            {
                listView1.Clear();
                listView1.View = View.LargeIcon;
                listView1.LargeImageList = imageList1;

                for (int i = 0; i < imageList1.Images.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    item.Text = game.ElementAt(i).Value;
                    item.Tag = game.ElementAt(i).Key;

                    listView1.Items.Add(item);
                }
            }
            else
            {
                List<int> que = new List<int>();
                
                for (int i = 0; i < game.Count; i++)
                {
                    if (game.ElementAt(i).Value.Contains(search))
                    {
                        que.Add(game.ElementAt(i).Key);
                    }
                }

                listView1.Clear();
                listView1.View = View.LargeIcon;
                listView1.LargeImageList = imageList1;

                for (int i = 0; i < que.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = que[i];
                    item.Text = game.ElementAt(que[i]).Value;
                    item.Tag = game.ElementAt(que[i]).Key;

                    listView1.Items.Add(item);
                }
            }            
        }


        private void Publish_Load(object sender, EventArgs e)
        {
            LoadPic();
            PicMode("");            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox借入.Visible == true && exchangeIn.Count < 5)
            {
                int id = (int)listView1.SelectedItems[0].Tag;                

                if (!exchangeIn.Contains(id) && !exchangeOut.Contains(id))
                {
                    exchangeIn.Add(id);
                    listBox借入.Items.Add(game.ElementAt(id).Value);
                }
                else if (exchangeIn.Contains(id))
                {
                    MessageBox.Show("選取內容已存在");
                }
                else if (exchangeOut.Contains(id))
                {
                    MessageBox.Show("換出名單中已有此項目");
                }
            }
            else if (listBox借出.Visible == true && exchangeOut.Count < 5)
            {
                int id = (int)listView1.SelectedItems[0].Tag;                

                if (!exchangeIn.Contains(id) && !exchangeOut.Contains(id))
                {
                    exchangeOut.Add(id);
                    listBox借出.Items.Add(game.ElementAt(id).Value);
                }
                else if (exchangeOut.Contains(id))
                {
                    MessageBox.Show("選取內容已存在");
                }
                else if (exchangeIn.Contains(id))
                {
                    MessageBox.Show("換入名單中已有此項目");
                }
            }
            else if (exchangeIn.Count == 5 || exchangeOut.Count == 5)
            {
                MessageBox.Show("已達可選上限");
            }

            SetProgress();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            PicMode(txt搜尋.Text);
        }

        private void txt搜尋_TextChanged(object sender, EventArgs e)
        {
            if (txt搜尋.Text == "")
            {
                PicMode("");
            }
        }

        private void txt搜尋_Click(object sender, EventArgs e)
        {
            if (txt搜尋.Text == "搜尋")
            {
                txt搜尋.Text = "";
                txt搜尋.ForeColor = Color.Black;
                txt搜尋.TextAlign = HorizontalAlignment.Left;
            }                            
        }

        private void btn借出_Click(object sender, EventArgs e)
        {
            panelBtn.Visible = true;
            listBox借出.Visible = true;
            listBox借入.Visible = false;

            exchangeOut.Clear();
            listBox借出.Items.Clear();
            pictureBox1.Image = null;

            Sql.Connect();
            string sql = "select * from exchange_out where member_id = @id";
            SqlCommand cmd = new SqlCommand(sql, Sql.con);
            cmd.Parameters.AddWithValue("@id", Account.Id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                for (int i = 1; i <= reader.FieldCount - 1; i++)
                {
                    if (reader.IsDBNull(i) == false)
                    {
                        exchangeOut.Add((int)reader[i]);
                    }
                }
            }           
            reader.Close();            

            for (int i = 0; i < exchangeOut.Count; i++)
            {
                listBox借出.Items.Add(game.ElementAt(exchangeOut[i]).Value);
            }

            progressBar1.Visible = true;
            SetProgress();

            sql = "select face, mail from member where id = @id;";
            cmd = new SqlCommand(sql, Sql.con);
            cmd.Parameters.AddWithValue("@id", Account.Id);

            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                chk郵寄.Checked = (bool)reader["mail"];
                chk面交.Checked = (bool)reader["face"];
            }

            reader.Close();
            Sql.con.Close();
        }

        private void btn借入_Click(object sender, EventArgs e)
        {
            panelBtn.Visible = true;
            listBox借入.Visible = true;
            listBox借出.Visible = false;

            exchangeIn.Clear();
            listBox借入.Items.Clear();
            pictureBox1.Image = null;

            Sql.Connect();
            string sql = "select * from exchange_in where member_id = @id";
            SqlCommand cmd = new SqlCommand(sql, Sql.con);
            cmd.Parameters.AddWithValue("@id", Account.Id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                for (int i = 1; i <= reader.FieldCount - 1; i++)
                {
                    if (reader.IsDBNull(i) == false)
                    {
                        exchangeIn.Add((int)reader[i]);
                    }
                }
            }

            reader.Close();

            for (int i = 0; i < exchangeIn.Count; i++)
            {
                listBox借入.Items.Add(game.ElementAt(exchangeIn[i]).Value);
            }

            progressBar1.Visible = true;
            SetProgress();

            sql = "select face, mail from member where id = @id;";
            cmd = new SqlCommand(sql, Sql.con);
            cmd.Parameters.AddWithValue("@id", Account.Id);

            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                chk郵寄.Checked = (bool)reader["mail"];
                chk面交.Checked = (bool)reader["face"];
            }

            reader.Close();
            Sql.con.Close();
        }

        private void btn清除全部_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("確定要全部清除?", "", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                if (listBox借入.Visible)
                {
                    exchangeIn.Clear();
                    listBox借入.Items.Clear();
                    pictureBox1.Image = null;
                }

                else if (listBox借出.Visible)
                {
                    exchangeOut.Clear();
                    listBox借出.Items.Clear();
                    pictureBox1.Image = null;
                }
            }

            SetProgress(); 
        }

        private void btn套用_Click(object sender, EventArgs e)
        {
            Sql.Connect();
            string sql;
            SqlCommand cmd;
            bool face = chk面交.Checked;
            bool mail = chk郵寄.Checked;

            if (listBox借入.Visible)
            {
                for (int i = 0; i < 5;)
                {
                    if (i < exchangeIn.Count)
                    {
                        sql = string.Format("update exchange_in set {0} = {1} where member_id = {2}", "in_" + i, exchangeIn[i], Account.Id);
                        cmd = new SqlCommand(sql, Sql.con);

                        cmd.ExecuteNonQuery();

                        i++;
                    }
                    else
                    {
                        sql = string.Format("update exchange_in set {0} = @null where member_id = {1}", "in_" + i, Account.Id);
                        cmd = new SqlCommand(sql, Sql.con);
                        cmd.Parameters.AddWithValue("@null", DBNull.Value);

                        cmd.ExecuteNonQuery();

                        i++;
                    }                    
                }
            }
            else if (listBox借出.Visible)
            {
                for (int i = 0; i < 5;)
                {
                    if (i < exchangeOut.Count)
                    {
                        sql = string.Format("update exchange_out set {0} = {1} where member_id = {2}", "out_" + i, exchangeOut[i], Account.Id);
                        cmd = new SqlCommand(sql, Sql.con);

                        cmd.ExecuteNonQuery();

                        i++;
                    }
                    else
                    {
                        sql = string.Format("update exchange_Out set {0} = @null where member_id = {1}", "out_" + i, Account.Id);
                        cmd = new SqlCommand(sql, Sql.con);
                        cmd.Parameters.AddWithValue("@null", DBNull.Value);

                        cmd.ExecuteNonQuery();

                        i++;
                    }
                }                
            }

            sql = "update member set face = @face, mail = @mail where id = @id;";
            cmd = new SqlCommand(sql, Sql.con);
            cmd.Parameters.AddWithValue("@face", face);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@id", Account.Id);

            cmd.ExecuteNonQuery();

            Sql.con.Close();
            MessageBox.Show("套用變更成功");
        }

        private void btn移除所選_Click(object sender, EventArgs e)
        {
            int indexIn = listBox借入.SelectedIndex;
            int indexOut = listBox借出.SelectedIndex;

            if (listBox借入.Visible && indexIn != -1)
            {
                exchangeIn.RemoveAt(indexIn);
                listBox借入.Items.RemoveAt(indexIn);
                pictureBox1.Image = null;
            }

            else if (listBox借出.Visible && indexOut != -1)
            {
                exchangeOut.RemoveAt(indexOut);
                listBox借出.Items.RemoveAt(indexOut);
                pictureBox1.Image = null;
            }

            else if (indexIn == -1 || indexOut == -1)
            {
                MessageBox.Show("請選取項目");
            }            

            SetProgress(); 
        }

        private void listBox借入_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox借入.SelectedIndex != -1)
            {
                pictureBox1.Image = imageList1.Images[exchangeIn[listBox借入.SelectedIndex]];
            }            
        }

        private void listBox借出_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox借出.SelectedIndex != -1)
            {
                pictureBox1.Image = imageList1.Images[exchangeOut[listBox借出.SelectedIndex]];
            }            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
            GlobalVar.formMain.Show();
        }

        private void Publish_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void chk郵寄_CheckedChanged(object sender, EventArgs e)
        {
            if (chk郵寄.Checked == false && chk面交.Checked == false)
            {
                chk郵寄.Checked = true;
                MessageBox.Show("請至少勾選一項");
            }
        }

        private void chk面交_CheckedChanged(object sender, EventArgs e)
        {
            if (chk郵寄.Checked == false && chk面交.Checked == false)
            {
                chk面交.Checked = true;
                MessageBox.Show("請至少勾選一項");
            }
        }

    }
}
