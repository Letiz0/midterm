using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace midterm_project
{
    class Filter
    {
        public static List<int> listIn = new List<int>(); //自己的換入名單
        public static List<int> listOut = new List<int>(); //自己的換出名單
        public static List<int> listOpidOut = new List<int>(); //自己換入符合對方換出的名單
        public static List<int> listOpidIn = new List<int>(); //自己換出符合對方換入的名單

        public static List<int> listResultId = new List<int>(); // match的名單

        public static void GetListIn()
        {
            listIn.Clear();

            Sql.Connect();
            string sql = "select in_0, in_1, in_2, in_3, in_4 from exchange_in where member_id = @id;";
            SqlCommand cmd = new SqlCommand(sql, Sql.con);
            cmd.Parameters.AddWithValue("@id", Account.Id);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader[i] != DBNull.Value)
                    {
                        listIn.Add((int)reader[i]);
                    }
                }
            }

            reader.Close();
            Sql.con.Close();
        }

        public static void GetListOut()
        {
            listOut.Clear();

            Sql.Connect();
            string sql = "select out_0, out_1, out_2, out_3, out_4 from exchange_out where member_id = @id;";
            SqlCommand cmd = new SqlCommand(sql, Sql.con);
            cmd.Parameters.AddWithValue("@id", Account.Id);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader[i] != DBNull.Value)
                    {
                        listOut.Add((int)reader[i]);
                    }
                }
            }

            reader.Close();
            Sql.con.Close();
        }

        public static void GetListOpidOut()
        {
            listOpidOut.Clear();

            if (listIn.Count > 0)
            {
                Sql.Connect();

                var parameters = new string[listIn.Count];
                var cmd = new SqlCommand("", Sql.con);

                for (int i = 0; i < listIn.Count; i++)
                {
                    parameters[i] = string.Format("@in{0}", i);
                    cmd.Parameters.AddWithValue(parameters[i], listIn[i]);
                }

                cmd.CommandText += string.Format("select member_id from exchange_out where out_0 in ({0}) or out_1 in ({0}) or out_2 in ({0}) or out_3 in ({0}) or out_4 in ({0});", string.Join(", ", parameters));

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listOpidOut.Add((int)reader["member_id"]);
                }

                reader.Close();
                Sql.con.Close();
            }
        }

        public static void GetListOpidIn()
        {
            listOpidIn.Clear();

            if (listOut.Count > 0)
            {
                Sql.Connect();

                var parameters = new string[listOut.Count];
                var cmd = new SqlCommand("", Sql.con);

                for (int i = 0; i < listOut.Count; i++)
                {
                    parameters[i] = string.Format("@out{0}", i);
                    cmd.Parameters.AddWithValue(parameters[i], listOut[i]);
                }

                cmd.CommandText += string.Format("select member_id from exchange_in where in_0 in ({0}) or in_1 in ({0}) or in_2 in ({0}) or in_3 in ({0}) or in_4 in ({0});", string.Join(", ", parameters));

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listOpidIn.Add((int)reader["member_id"]);
                }


                reader.Close();
                Sql.con.Close(); 
            }
        }

        public static void GetResuldId()
        {
            listResultId.Clear();

            var temp = listOpidIn.Intersect(listOpidOut);

            foreach (var item in temp)
            {
                listResultId.Add(item);
            }
        }
    }
}
