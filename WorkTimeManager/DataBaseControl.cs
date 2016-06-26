using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace WorkTimeManager
{
    static class DataBaseControl
    {


        public static string Server { get; set; }
        public static string User { get; set; }
        public static string Passwd { private get; set; }


        public static uint Port { get; set; }
        static DataBaseControl() //Dane do bazy danych bez tego nawet nie odpalisz 
        {
            Server = "127.0.0.1";
            User = "root";
            Passwd = "";
            Port = 3306;

        }

        public static MySqlConnection CreateConnection(string DataBaseName)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = Server;
            builder.UserID = User;
            builder.Password = Passwd;
            builder.Port = Port;
            builder.Database = DataBaseName;
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            return conn;

        }

        public static void OpenConnection(MySqlConnection conn)
        {

            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
                        
        }

        public static void CloseConnection(MySqlConnection conn)
        {
                conn.Close();
        }

        public static List<string> Select(MySqlConnection conn,string query)
        {
            List<string> result = new List<string>();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader dr = command.ExecuteReader();
   
                    
            while (dr.Read())
            { 
                result.Add(dr[0].ToString());

                foreach (var item in dr)
                {
                    MessageBox.Show(item.ToString());
                }
               
            }
            dr.Close();

            return result;
        }

        public static DataTable SelecTest(MySqlConnection conn, string query)
        {        
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = new MySqlCommand(query, conn);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                return table;
                 
        }

        public static void delete(MySqlConnection conn, string query)
        {
            MySqlCommand command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
        }

        public static void insertData(MySqlConnection conn, string query)
        {
            /*MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = query;
      
            comm.ExecuteNonQuery();
            MessageBox.Show(query);*/



            MySqlCommand command = new MySqlCommand(query, conn);
     
            command.ExecuteNonQuery();

        }

        public static string ResultToString(List<string> result)
        {
            string tmp = "";

            foreach (var item in result)
            {
                tmp += item;
                tmp += " ";
            }

            return tmp;
        }



        public static string[] ResultToArrayString(List<string> result)
        {
            return result.ToArray();
        }

    }
}
