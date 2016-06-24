using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace WorkTimeManager
{
    class CompanyRaport
    {

        private departments departments = new departments();
        private MySqlConnection conn = DataBaseControl.CreateConnection("time_manager"); 

        public List<string> generateRaport()
        {

            return new List<string>();
        }


        public DataTable getWorkersGrid(string month, string year)
        {
       
            try
            {
                string queryText;
           
                if (string.IsNullOrEmpty(month))
                {
                     queryText = string.Format("Select u.name imie, u.surname nazwisko, sum(w.how_long) Czas_Pracy, d.name Dział  from worklist w join departments d on w.departamentID=d.ID  join users u on w.userID =u.ID where year(w.data)='{0}' group by u.id",year);
                }
                else
                {
                    month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();  //Konwersja miesiaca pisanego na liczbę  "Czerwiec" -> "6"
                    queryText = string.Format("Select u.name imie, u.surname nazwisko, sum(w.how_long) Czas_Pracy, d.name Dział  from worklist w join departments d on w.departamentID=d.ID  join users u on w.userID =u.ID where year(w.data)='{0}' and month(w.data)='{1}' group by u.id ", year, month);
                }
                DataTable Data = new DataTable();
                Data = DataBaseControl.SelecTest(conn, queryText);

                return Data;
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
                return new DataTable();
            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }
        }

        public DataTable getDepartmensGrid(string month, string year)
        {
            try
            {
                string queryText;

                if (string.IsNullOrEmpty(month))
                {
                    queryText = string.Format("Select d.name nazwa, sum(w.how_long) Czas_Pracy from worklist w join departments d on w.departamentID=d.ID  join users u on w.userID =u.ID where year(w.data)='{0}' group by 1 order by 2", year);
                }
                else
                {
                    month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();  //Konwersja miesiaca pisanego na liczbę  "Czerwiec" -> "6"
                    queryText = string.Format("Select d.name nazwa, sum(w.how_long) Czas_Pracy from worklist w join departments d on w.departamentID=d.ID  join users u on w.userID =u.ID where year(w.data)='{0}' and month(w.data)='{1}' group by u.id order by 2 ", year, month);
                }
                DataTable Data = new DataTable();
                Data = DataBaseControl.SelecTest(conn, queryText);

                return Data;
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
                return new DataTable();
            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }



        }

    }
}
