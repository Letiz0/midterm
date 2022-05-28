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
using Microsoft.VisualBasic;

namespace midterm_project
{
    public partial class btn提交申請 : Form
    {
        public btn提交申請()
        {
            InitializeComponent();
        }

        Dictionary<int, string> game = new Dictionary<int, string>();
        List<int> opGameIn = new List<int>();
        List<int> opGameOut = new List<int>();

        enum radio
        {
            郵寄 = 1,
            面交 = 2,
            不限 = 3
        }

        radio radioBtn
        {
            get
            {
                if (radioButton面交.Checked == true)
                {
                    return radio.面交;
                }
                else if (radioButton郵寄.Checked == true)
                {
                    return radio.郵寄;
                }
                else
                {
                    return radio.不限;
                }
            }
        }

        string Search
        {
            get
            {
                if (txt搜尋.Text == "依地區搜尋")
                {
                    return "";
                }
                else
                {
                    return txt搜尋.Text;
                }
            }
        }
        void DataFilter()
        {
            DataView view = new DataView(dataTable);

            switch (radioBtn)
            {
                case radio.郵寄:                    
                    view.RowFilter = string.Format("可郵寄 = 1 and 地區 like '%{0}%'", Search);                    
                    break;
                case radio.面交:
                    view.RowFilter = string.Format("可面交 = 1 and 地區 like '%{0}%'", Search);
                    break;
                case radio.不限:
                    view.RowFilter = string.Format("(可郵寄 = 1 or 可面交 = 1) and 地區 like '%{0}%'", Search);
                    break;
            }

            dataGridView1.DataSource = view;

            listView自己.Clear();
            listView對方.Clear();
            dataGridView1.ClearSelection();
        }

        void GetOpGameIn()
        {
            opGameIn.Clear();

            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            Sql.Connect();
            SqlCommand cmd = new SqlCommand("", Sql.con);
            cmd.CommandText += "select in_0, in_1, in_2, in_3, in_4 from exchange_in where member_id = @id;";
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                for (int i = 0; i < 5; i++)
                {
                    if (reader[i] != DBNull.Value)
                    {
                        opGameIn.Add((int)reader[i]);
                    }
                }
            }

            reader.Close();
            Sql.con.Close();
        }

        void GetOpGameOut()
        {
            opGameOut.Clear();

            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            Sql.Connect();
            SqlCommand cmd = new SqlCommand("", Sql.con);
            cmd.CommandText += "select out_0, out_1, out_2, out_3, out_4 from exchange_out where member_id = @id;";
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                for (int i = 0; i < 5; i++)
                {
                    if (reader[i] != DBNull.Value)
                    {
                        opGameOut.Add((int)reader[i]);
                    }
                }
            }

            reader.Close();
            Sql.con.Close();
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

        DataTable dataTable;

        private void Search_Load(object sender, EventArgs e)
        {
            LoadPic();

            Filter.GetListIn();
            Filter.GetListOut();
            Filter.GetListOpidOut();
            Filter.GetListOpidIn();
            Filter.GetResuldId();

            if (Filter.listResultId.Count > 0)
            {
                Sql.Connect();

                string[] parameters = new string[Filter.listResultId.Count];

                SqlCommand cmd = new SqlCommand("", Sql.con);

                for (int i = 0; i < parameters.Length; i++)
                {
                    parameters[i] = string.Format("@id{0}", i);
                    cmd.Parameters.AddWithValue(parameters[i], Filter.listResultId[i]);
                }

                cmd.CommandText += string.Format("select id as id, nickname as 暱稱, location as 地區, face as 可面交, mail as 可郵寄, success as 交易次數, lastupdate as 最後更新時間 from member where id in ({0}) order by lastupdate desc", string.Join(",", parameters));

                dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);
                adapter.Dispose();


                dataGridView1.DataSource = dataTable;
                dataGridView1.ClearSelection();

                Sql.con.Close(); 
            }
        }


        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
            GlobalVar.formMain.Show();
        }

        private void txt搜尋_Click(object sender, EventArgs e)
        {
            txt搜尋.Text = "";
            txt搜尋.ForeColor = Color.Black;
            DataFilter();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            DataFilter();
        }

        private void button提交申請_Click(object sender, EventArgs e)
        {
            if (listView自己.SelectedItems.Count > 0 && listView對方.SelectedItems.Count >0)
            {
                Sql.Connect();
                SqlCommand cmd = new SqlCommand("", Sql.con);

                cmd.CommandText = "insert into [order] (id_invite, id_received, invite_0, invite_1, invite_2, invite_3, invite_4, received_0, received_1, received_2, received_3, received_4, status, note) values(@id_invite, @id_received, @invite_0, @invite_1, @invite_2, @invite_3, @invite_4, @received_0, @received_1, @received_2, @received_3, @received_4, @status, @note)";
                cmd.Parameters.AddWithValue("@id_received", dataGridView1.SelectedRows[0].Cells["id"].Value);
                cmd.Parameters.AddWithValue("@status", GlobalVar.orderStatus.等待接受);
                cmd.Parameters.AddWithValue("@id_invite", Account.Id);
                cmd.Parameters.AddWithValue("@note", note);
                for (int i = 0; i < 5;)
                {
                    if (i < listView自己.SelectedItems.Count)
                    {
                        cmd.Parameters.AddWithValue(string.Format("@invite_{0}", i), listView自己.SelectedItems[i].Tag);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue(string.Format("@invite_{0}", i), DBNull.Value);
                    }

                    i++;
                }
                for (int i = 0; i < 5;)
                {
                    if (i < listView對方.SelectedItems.Count)
                    {
                        cmd.Parameters.AddWithValue(string.Format("@received_{0}", i), listView對方.SelectedItems[i].Tag);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue(string.Format("@received_{0}", i), DBNull.Value);
                    }

                    i++;
                }

                note = "(無)";
                cmd.ExecuteNonQuery();
                MessageBox.Show("成功提交邀請");
                Sql.con.Close();             
            }

            else
            {
                MessageBox.Show("請至少各選一項");
            }
        }

        private void txt搜尋_TextChanged(object sender, EventArgs e)
        {
            if (txt搜尋.Text == "")
            {
                dataGridView1.DataSource = dataTable;
            }
        }

        List<int> opResult;
        List<int> selfResult;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            if (e.RowIndex != -1)
            {
                Size = new Size(1374, 581);
                CenterToScreen();

                listView對方.Clear();
                listView自己.Clear();
                GetOpGameIn();
                GetOpGameOut();
                panel交換.Visible = true;

                opResult = new List<int>(opGameOut.Intersect(Filter.listIn));

                for (int i = 0; i < opResult.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = game.ElementAt(opResult[i]).Value;
                    item.ImageIndex = game.ElementAt(opResult[i]).Key;
                    item.Tag = opResult[i];

                    listView對方.Items.Add(item);
                }

                selfResult = new List<int>(opGameIn.Intersect(Filter.listOut));

                for (int i = 0; i < selfResult.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = game.ElementAt(selfResult[i]).Value;
                    item.ImageIndex = game.ElementAt(selfResult[i]).Key;
                    item.Tag = selfResult[i];

                    listView自己.Items.Add(item);
                }
            }            
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            listView自己.Clear();
            listView對方.Clear();
            dataGridView1.ClearSelection();
        }

        private void radioButton面交_CheckedChanged(object sender, EventArgs e)
        {
            DataFilter();
        }

        private void radioButton郵寄_CheckedChanged(object sender, EventArgs e)
        {
            DataFilter();
        }

        private void radioButton不限_CheckedChanged(object sender, EventArgs e)
        {
            DataFilter();
        }

        string note = "(無)";
        private void btn備註_Click(object sender, EventArgs e)
        {
            note = Interaction.InputBox("請輸入備註(限30字)", "備註", note, -1, -1);
            if (note.Length >= 30)
            {
                MessageBox.Show("最多輸入30字");
                note = "(無)";
            }
        }

    }
}
