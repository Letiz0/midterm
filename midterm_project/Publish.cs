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

        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            PicMode(txt搜尋.Text);
        }
    }
}
