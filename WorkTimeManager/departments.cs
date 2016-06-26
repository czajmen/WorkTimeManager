using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace WorkTimeManager
{
   public class departments
    {
        public List<string> name  { get; private set; }
        public List<string> managersID { get; private set; }
        public List<string> departmentID { get; private set; }

        public int ilosc;
        public MySqlConnection conn=DataBaseControl.CreateConnection("time_manager");  //Database connection handler

        public departments()
        {
            try
            {
              
                int iterator=0;
                this.name = new List<string>();
                this.managersID = new List<string>();
                this.departmentID = new List<string>();
                DataBaseControl.OpenConnection(conn);

                string queryText = string.Format("select count(*) from departments");

                ilosc = Convert.ToInt16(DataBaseControl.Select(conn, queryText)[0]);


              //  MessageBox.Show(ilosc.ToString());

      

                DataBaseControl.OpenConnection(conn);
                 queryText = string.Format("Select * from departments ");
                DataTable userDetails = new DataTable();
                userDetails = DataBaseControl.SelecTest(conn, queryText);

                foreach (DataRow row in userDetails.Rows)   //Nie działa nie wiem czemu
                {
                    this.name.Add(row[1].ToString());
                    this.departmentID.Add(row[0].ToString());
                    this.managersID.Add(row[2].ToString());

                }

            }
            catch (MySqlException myexc)
            {
                DataBaseControl.CloseConnection(conn);
                MessageBox.Show(myexc.Message);
            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }
        }

        public string[] this[int index]    
        {
            get
            {
                try
                {
                    return new String[] { departmentID[index] ,name[index] , managersID[index] };
                }
                catch
                {
                   return new String[]{"null"};
                }
            }
        }
    }
}
