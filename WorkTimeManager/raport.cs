using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeManager
{
    class raport
    {

        public MySqlConnection conn;  //Database connection handler

        public raport(string query)
        {
            try
            {
                conn = DataBaseControl.CreateConnection("time_manager");  //Nazwa Bazy danych 
                DataBaseControl.OpenConnection(conn);
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = query;
                
                comm.ExecuteNonQuery();
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }
        }
    }
}
