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
                exchangeIn.Add(id);
                listBox借入.Items.Add(game.ElementAt(id).Value);
            }
            else if (listBox借出.Visible == true && exchangeOut.Count < 5)
            {
                int id = (int)listView1.SelectedItems[0].Tag;
                exchangeOut.Add(id);
                listBox借出.Items.Add(game.ElementAt(id).Value);
            }
            else if (exchangeIn.Count == 5 || exchangeOut.Count == 5)
            {
                MessageBox.Show("已達可選上限");
            }
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
        }

        private void btn借入_Click(object sender, EventArgs e)
        {
            panelBtn.Visible = true;
            listBox借入.Visible = true;
            listBox借出.Visible = false;
        }

        private void btn清除全部_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("確定要全部清除?", "", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {

            }
        }
    }
}
