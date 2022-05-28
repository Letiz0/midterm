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
using System.Reflection;

namespace midterm_project
{
    public partial class Member : Form
    {
        public Member()
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
                Image image = Image.FromFile(fileName);
                image.Tag = (int)reader["id"];
                imageList1.Images.Add(image);
            }

            reader.Close();
            Sql.con.Close();
        }
        private void Member_Load(object sender, EventArgs e)
        {
            LoadPic();

            PropertyInfo info = this.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            info.SetValue(panel歷史交易紀錄, true, null);
            info.SetValue(panel資料變更, true, null);
            info.SetValue(panel交易邀請管理, true, null);
            info.SetValue(panel交換中的訂單, true, null);
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
            bool pwConfirm = (txt新密碼.Text != "") && (txt新密碼.Text == txt確認新密碼.Text);

            Sql.Connect();
            SqlCommand cmd = new SqlCommand("", Sql.con);

            cmd.CommandText = "select password from member where id = @id";
            cmd.Parameters.AddWithValue("@id", Account.Id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if ((reader[0].ToString() == txt舊密碼.Text) && pwConfirm)
            {
                reader.Close();
                cmd.CommandText = "update member set password = @password where id = @id";
                cmd.Parameters.AddWithValue("@password", txt新密碼.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("密碼修改成功");
            }
            else if (reader[0].ToString() != txt舊密碼.Text)
            {
                MessageBox.Show("舊密碼輸入錯誤");
            }
            else if (pwConfirm == false)
            {
                MessageBox.Show("新密碼不可為空或輸入不相符");
            }

            txt舊密碼.Text = "";
            txt新密碼.Text = "";
            txt確認新密碼.Text = "";
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
            
            MessageBox.Show("會員資料修改成功");           

            Sql.con.Close();
        }

        private void btn會員資料變更_Click(object sender, EventArgs e)
        {
            panel資料變更.Visible = true;
            panel歷史交易紀錄.Visible = false;
            panel交易邀請管理.Visible = false;
            panel交換中的訂單.Visible = false;

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

        private void btn交易邀請管理_Click(object sender, EventArgs e)
        {
            listBox收.Items.Clear();
            listView對方.Items.Clear();
            listView自己.Items.Clear();
            btn對方資訊.Enabled = false;
            btn查看備註.Enabled = false;
            btn拒絕.Enabled = false;
            btn接受邀請.Enabled = false;

            panel資料變更.Visible = false;
            panel歷史交易紀錄.Visible = false;
            panel交易邀請管理.Visible = true;
            panel交換中的訂單.Visible = false;

            Sql.Connect();
            string sql = "select order_id from [order] where id_received = @id and status = 0";
            SqlCommand cmd = new SqlCommand(sql, Sql.con);
            cmd.Parameters.AddWithValue("@id", Account.Id);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listBox收.Items.Add(reader[0]);
                listBox收.SelectedIndex = 0;
            }
        }

        private void btn歷史交易紀錄_Click(object sender, EventArgs e)
        {
            panel資料變更.Visible = false;
            panel歷史交易紀錄.Visible = true;
            panel交易邀請管理.Visible = false;
            panel交換中的訂單.Visible = false;

            cb類型.SelectedIndex = 0;
            dtp開始.Value = DateTime.Now.AddMonths(-1);
            dtp結束.Value = DateTime.Now;

            txt訂單狀態.Text = "";
            txt時間.Text = "";
            listBox自己.Items.Clear();
            listBox對方.Items.Clear();
            listBox訂單編號.Items.Clear();
            btn查看對方.Enabled = false;
        }


        string[] Status
        {
            get 
            {
                if (cb類型.SelectedIndex == 0)
                {
                    return new string[] { "@value2", "@value3", "@value4", "@value5" };
                }
                else if (cb類型.SelectedIndex == 1)
                {
                    return new string[] { "@value2" };
                }
                else if (cb類型.SelectedIndex == 2)
                {
                    return new string[] { "@value3" };
                }
                else if (cb類型.SelectedIndex == 3)
                {
                    return new string[] { "@value4" };
                }
                else
                {
                    return new string[] { "@value5" };
                }
            }
        }  
       

        private void btn查詢_Click(object sender, EventArgs e)
        {
            listBox訂單編號.Items.Clear();    
            
            Sql.Connect();
            SqlCommand cmd = new SqlCommand("", Sql.con);
            cmd.CommandText = string.Format("select order_id from [order] where id_invite = @id and (date between @date1 and @date2) and status in ({0}) union select order_id from [order] where id_received = @id and (date between @date1 and @date2) and status in ({0})", string.Join(",", Status));
            cmd.Parameters.AddWithValue("@id", Account.Id);
            cmd.Parameters.AddWithValue("@date1", dtp開始.Value);
            cmd.Parameters.AddWithValue("@date2", dtp結束.Value);
            
            for (int i = 2; i < 6; i++)
            {
                cmd.Parameters.AddWithValue("@value" + i, i);
            }

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox訂單編號.Items.Add((int)reader["order_id"]);
            }

            reader.Close();
            Sql.con.Close();
        }

        string nickname;
        string phone;
        string email;
        string location;

        private void listBox訂單編號_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox自己.Items.Clear();
            listBox對方.Items.Clear();

            if (listBox訂單編號.SelectedIndex != -1)
            {
                bool isInvite;
                int orderId = (int)listBox訂單編號.SelectedItem;
                DateTime date = new DateTime();
                int orderStatus;
                int opid;

                Sql.Connect();

                string sql = "select id_invite, id_received, [date], [status] from [order] where order_id = @order_id";
                SqlCommand cmd = new SqlCommand(sql, Sql.con);
                cmd.Parameters.AddWithValue("@order_id", orderId);

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                if ((int)reader["id_invite"] == Account.Id)
                {
                    isInvite = true;
                    opid = (int)reader["id_received"];
                    date = (DateTime)reader["date"];
                    orderStatus = (int)reader["status"];
                }
                else
                {
                    isInvite = false;
                    opid = (int)reader["id_invite"];
                    date = (DateTime)reader["date"];
                    orderStatus = (int)reader["status"];
                }

                txt時間.Text = date.ToString("g");
                txt訂單狀態.Text = Enum.GetName(typeof(GlobalVar.orderStatus), orderStatus);

                reader.Close();

                sql = "select id, email, location, phone, nickname from member where id = @opid";
                cmd = new SqlCommand(sql, Sql.con);
                cmd.Parameters.AddWithValue("@opid", opid);

                reader = cmd.ExecuteReader();
                reader.Read();

                email = (string)reader["email"];
                location = (string)reader["location"];
                phone = (string)reader["phone"];
                nickname = (string)reader["nickname"];

                reader.Close();

                sql = "select invite_0, invite_1, invite_2, invite_3, invite_4, received_0, received_1, received_2, received_3, received_4 from [order] where order_id = @order_id";
                cmd = new SqlCommand(sql, Sql.con);
                cmd.Parameters.AddWithValue("@order_id", orderId);

                reader = cmd.ExecuteReader();
                reader.Read();

                int i = 0;
                string gameName;

                if (isInvite == true)
                {
                    while (reader[i] != DBNull.Value)
                    {
                        gameName = game[(int)reader[i]];
                        listBox自己.Items.Add(gameName);
                        i++;
                    }

                    i = 5;

                    while (i < 10 && reader[i] != DBNull.Value)
                    {
                        gameName = game[(int)reader[i]];
                        listBox對方.Items.Add(gameName);
                        i++;
                    }
                }
                else
                {
                    while (reader[i] != DBNull.Value)
                    {
                        gameName = game[(int)reader[i]];
                        listBox對方.Items.Add(gameName);
                        i++;
                    }

                    i = 5;

                    while (i < 10 && reader[i] != DBNull.Value)
                    {
                        gameName = game[(int)reader[i]];
                        listBox自己.Items.Add(gameName);
                        i++;
                    }
                }

                reader.Close();
                Sql.con.Close(); 
            }
        }

        private void txt訂單狀態_TextChanged(object sender, EventArgs e)
        {
            if (txt訂單狀態.Text == "完成" || txt訂單狀態.Text == "取消交易")
            {
                btn查看對方.Enabled = true;
            }
            else
            {
                btn查看對方.Enabled = false;
            }
        }

        private void btn查看對方_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"信箱: {email}\n居住地區: {location}\n暱稱: {nickname}\n手機號碼: {phone}");
        }

        private void btn交換中_Click(object sender, EventArgs e)
        {
            panel資料變更.Visible = false;
            panel歷史交易紀錄.Visible = false;
            panel交易邀請管理.Visible = false;
            panel交換中的訂單.Visible = true;
        }

        private void btn接受邀請_Click(object sender, EventArgs e)
        {
            Sql.Connect();

            SqlCommand cmd;      

            //對方invite
            string[] parameters = new string[opGameID.Count];
            cmd = new SqlCommand("", Sql.con);
            cmd.Parameters.AddWithValue("@status", GlobalVar.orderStatus.取消申請);
            cmd.Parameters.AddWithValue("@opid", opid);

            for (int i = 0; i < opGameID.Count; i++)
            {
                parameters[i] = string.Format("@gameid{0}", i);
                cmd.Parameters.AddWithValue(parameters[i], opGameID[i]);
            }

            cmd.CommandText = string.Format("update [order] set status = @status where id_invite = @opid and (invite_0 in ({0}) or invite_1 in ({0}) or invite_2 in ({0}) or invite_3 in ({0}) or invite_4 in ({0}))", string.Join(", ", parameters));
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            //對方received
            parameters = new string[opGameID.Count];
            cmd = new SqlCommand("", Sql.con);
            cmd.Parameters.AddWithValue("@status", GlobalVar.orderStatus.取消申請);
            cmd.Parameters.AddWithValue("@opid", opid);

            for (int i = 0; i < opGameID.Count; i++)
            {
                parameters[i] = string.Format("@gameid{0}", i);
                cmd.Parameters.AddWithValue(parameters[i], opGameID[i]);
            }

            cmd.CommandText = string.Format("update [order] set status = @status where id_received = @opid and (received_0 in ({0}) or received_1 in ({0}) or received_2 in ({0}) or received_3 in ({0}) or received_4 in ({0}))", string.Join(", ", parameters));
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            //自己invite
            parameters = new string[selfGameID.Count];
            cmd = new SqlCommand("", Sql.con);
            cmd.Parameters.AddWithValue("@status", GlobalVar.orderStatus.取消申請);
            cmd.Parameters.AddWithValue("@id", Account.Id);

            for (int i = 0; i < selfGameID.Count; i++)
            {
                parameters[i] = string.Format("@gameid{0}", i);
                cmd.Parameters.AddWithValue(parameters[i], selfGameID[i]);
            }

            cmd.CommandText = string.Format("update [order] set status = @status where id_invite = @id and (invite_0 in ({0}) or invite_1 in ({0}) or invite_2 in ({0}) or invite_3 in ({0}) or invite_4 in ({0}))", string.Join(", ", parameters));
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            //自己received
            parameters = new string[selfGameID.Count];
            cmd = new SqlCommand("", Sql.con);
            cmd.Parameters.AddWithValue("@status", GlobalVar.orderStatus.取消申請);
            cmd.Parameters.AddWithValue("@id", Account.Id);

            for (int i = 0; i < selfGameID.Count; i++)
            {
                parameters[i] = string.Format("@gameid{0}", i);
                cmd.Parameters.AddWithValue(parameters[i], selfGameID[i]);
            }

            cmd.CommandText = string.Format("update [order] set status = @status where id_received = @id and (received_0 in ({0}) or received_1 in ({0}) or received_2 in ({0}) or received_3 in ({0}) or received_4 in ({0}))", string.Join(", ", parameters));
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            //修改此訂單狀態
            cmd = new SqlCommand("", Sql.con);
            cmd.CommandText = "update [order] set status = @status where order_id = @order_id";
            cmd.Parameters.AddWithValue("@status", GlobalVar.orderStatus.交易中);
            cmd.Parameters.AddWithValue("@order_id", orderID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            //修改對方換出名單
            List<int> gameid = new List<int>();

            cmd = new SqlCommand("", Sql.con);
            cmd.CommandText = "select out_0, out_1, out_2, out_3, out_4 from exchange_out where member_id = @id";
            cmd.Parameters.AddWithValue("@id", opid);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            for (int i = 0; i < 5; i++)
            {
                if (reader[i] != DBNull.Value)
                {
                    gameid.Add((int)reader[i]);
                }                
            }

            reader.Close();
            gameid = gameid.Except(opGameID).ToList();
            gameid.Sort();

            cmd = new SqlCommand("", Sql.con);
            cmd.CommandText = "update exchange_out set out_0 = @gameid0, out_1 = @gameid1, out_2 = @gameid2, out_3 = @gameid3, out_4 = @gameid4 where member_id = @id";
            cmd.Parameters.AddWithValue("@id", opid);

            for (int i = 0; i < 5; i++)
            {
                if (i < gameid.Count)
                {
                    cmd.Parameters.AddWithValue(string.Format("@gameid{0}", i), gameid[i]);
                }
                else
                {
                    cmd.Parameters.AddWithValue(string.Format("@gameid{0}", i), DBNull.Value);
                }                
            }
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            gameid.Clear();

            //修改對方換入名單
            cmd = new SqlCommand("", Sql.con);
            cmd.CommandText = "select in_0, in_1, in_2, in_3, in_4 from exchange_in where member_id = @id";
            cmd.Parameters.AddWithValue("@id", opid);
            reader = cmd.ExecuteReader();
            reader.Read();

            for (int i = 0; i < 5; i++)
            {
                if (reader[i] != DBNull.Value)
                {
                    gameid.Add((int)reader[i]);
                }
            }

            reader.Close();
            gameid = gameid.Except(selfGameID).ToList();
            gameid.Sort();

            cmd = new SqlCommand("", Sql.con);
            cmd.CommandText = "update exchange_in set in_0 = @gameid0, in_1 = @gameid1, in_2 = @gameid2, in_3 = @gameid3, in_4 = @gameid4 where member_id = @id";
            cmd.Parameters.AddWithValue("@id", opid);

            for (int i = 0; i < 5; i++)
            {
                if (i < gameid.Count)
                {
                    cmd.Parameters.AddWithValue(string.Format("@gameid{0}", i), gameid[i]);
                }
                else
                {
                    cmd.Parameters.AddWithValue(string.Format("@gameid{0}", i), DBNull.Value);
                }
            }
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            gameid.Clear();

            //修改自己換出名單
            cmd = new SqlCommand("", Sql.con);
            cmd.CommandText = "select out_0, out_1, out_2, out_3, out_4 from exchange_out where member_id = @id";
            cmd.Parameters.AddWithValue("@id", Account.Id);
            reader = cmd.ExecuteReader();
            reader.Read();

            for (int i = 0; i < 5; i++)
            {
                if (reader[i] != DBNull.Value)
                {
                    gameid.Add((int)reader[i]);
                }
            }

            reader.Close();
            gameid = gameid.Except(selfGameID).ToList();
            gameid.Sort();

            cmd = new SqlCommand("", Sql.con);
            cmd.CommandText = "update exchange_out set out_0 = @gameid0, out_1 = @gameid1, out_2 = @gameid2, out_3 = @gameid3, out_4 = @gameid4 where member_id = @id";
            cmd.Parameters.AddWithValue("@id", Account.Id);

            for (int i = 0; i < 5; i++)
            {
                if (i < gameid.Count)
                {
                    cmd.Parameters.AddWithValue(string.Format("@gameid{0}", i), gameid[i]);
                }
                else
                {
                    cmd.Parameters.AddWithValue(string.Format("@gameid{0}", i), DBNull.Value);
                }
            }
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            gameid.Clear();

            //修改自己換入名單
            cmd = new SqlCommand("", Sql.con);
            cmd.CommandText = "select in_0, in_1, in_2, in_3, in_4 from exchange_in where member_id = @id";
            cmd.Parameters.AddWithValue("@id", Account.Id);
            reader = cmd.ExecuteReader();
            reader.Read();

            for (int i = 0; i < 5; i++)
            {
                if (reader[i] != DBNull.Value)
                {
                    gameid.Add((int)reader[i]);
                }
            }

            reader.Close();
            gameid = gameid.Except(opGameID).ToList();
            gameid.Sort();

            cmd = new SqlCommand("", Sql.con);
            cmd.CommandText = "update exchange_in set in_0 = @gameid0, in_1 = @gameid1, in_2 = @gameid2, in_3 = @gameid3, in_4 = @gameid4 where member_id = @id";
            cmd.Parameters.AddWithValue("@id", Account.Id);

            for (int i = 0; i < 5; i++)
            {
                if (i < gameid.Count)
                {
                    cmd.Parameters.AddWithValue(string.Format("@gameid{0}", i), gameid[i]);
                }
                else
                {
                    cmd.Parameters.AddWithValue(string.Format("@gameid{0}", i), DBNull.Value);
                }
            }
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            gameid.Clear();
            
            MessageBox.Show("已接受邀請，請至「交換中的訂單查看」");
            listView對方.Clear();
            listView自己.Clear();

            btn查看備註.Enabled = false;
            btn對方資訊.Enabled = false;
            btn拒絕.Enabled = false;
            btn接受邀請.Enabled = false;

            Sql.Connect();
            string sql = "select order_id from [order] where id_received = @id and status = 0";
            cmd = new SqlCommand(sql, Sql.con);
            cmd.Parameters.AddWithValue("@id", Account.Id);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listBox收.Items.Add(reader[0]);
                listBox收.SelectedIndex = 0;
            }

            reader.Close();
            Sql.con.Close();
        }

        string note;
        int opid;
        int orderID;
        List<int> opGameID = new List<int>();
        List<int> selfGameID = new List<int>();

        private void listBox收_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (listBox收.SelectedIndex != -1)
            {
                listView對方.Items.Clear();
                listView自己.Items.Clear();
                opGameID.Clear();
                selfGameID.Clear();
                btn查看備註.Enabled = true;
                btn對方資訊.Enabled = true;
                btn拒絕.Enabled = true;
                btn接受邀請.Enabled = true;

                orderID = (int)listBox收.SelectedItem;

                Sql.Connect();
                string sql = "select invite_0, invite_1, invite_2, invite_3, invite_4, received_0, received_1, received_2, received_3, received_4, note, id_invite from [order] where order_id = @order_id";
                SqlCommand cmd = new SqlCommand(sql, Sql.con);
                cmd.Parameters.AddWithValue("@order_id", orderID);

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                int i = 0;
                
                while (reader[i] != DBNull.Value)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = game[(int)reader[i]];
                    item.ImageIndex = (int)reader[i];
                    listView對方.Items.Add(item);
                    opGameID.Add((int)reader[i]);

                    i++;
                }

                i = 5;

                while (i < 10 && reader[i] != DBNull.Value)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = game[(int)reader[i]];
                    item.ImageIndex = (int)reader[i];
                    listView自己.Items.Add(item);
                    selfGameID.Add((int)reader[i]);

                    i++;
                }

                if (!reader["note"].ToString().Contains("(無)"))
                {
                    btn查看備註.Enabled = true;
                    note = reader["note"].ToString();
                }
                else
                {
                    btn查看備註.Enabled = false;
                }

                opid = (int)reader["id_invite"];

                reader.Close();
                Sql.con.Close();
            }
        }
        
        private void btn查看備註_Click(object sender, EventArgs e)
        {
            MessageBox.Show(note.TrimEnd(' '));
        }

        private void btn拒絕_Click(object sender, EventArgs e)
        {

        }

        private void btn對方資訊_Click(object sender, EventArgs e)
        {    
            Sql.Connect();
            string sql = "select location, mail, face, nickname from member where id = @opid";
            SqlCommand cmd = new SqlCommand(sql, Sql.con);
            cmd.Parameters.AddWithValue("@opid", opid);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            string location = (string)reader["location"];
            string nickname = (string)reader["nickname"];
            string tradeVia;

            if ((bool)reader["mail"] == true && (bool)reader["face"] == true)
            {
                tradeVia = "郵寄或面交皆可";
            }
            else if ((bool)reader["mail"] == false && (bool)reader["face"] == true)
            {
                tradeVia = "只限面交";
            }
            else
            {
                tradeVia = "只限郵寄";
            }

            MessageBox.Show($"暱稱: {nickname}\n居住地區: {location}\n交易方式: {tradeVia}");

            reader.Close();
            Sql.con.Close();
        }
    }
}
