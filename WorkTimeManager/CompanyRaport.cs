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

        public string GetWorkTimeSum(string month, string year)
        {
            try
            {
                string queryText;
                DataBaseControl.OpenConnection(conn);

                if (string.IsNullOrEmpty(month))
                {
                    queryText = string.Format("select sum(how_long) from worklist w where year(w.data)='{0}'", year);
                }
                else
                {
                    month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();  //Konwersja miesiaca pisanego na liczbę  "Czerwiec" -> "6"
                    queryText = string.Format("select sum(how_long) from worklist w where year(w.data)='{0}' and month(w.data)='{1}' ", year, month);
                }
                List<string> result = new List<string>();
                result = DataBaseControl.Select(conn, queryText);



                int tmpTime = Convert.ToInt16(result[0]) / 60;

                return tmpTime.ToString();
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
                return null;
            }
            catch
            {
                return "Brak Danych";
            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }
        }


        public string GetMostAAciveWorkerWorkTimeSum(string month, string year)
        {
            try
            {
                string queryText;
                DataBaseControl.OpenConnection(conn);

                string[] mostDep = getMostActivWorker(month, year).Split(' ');

                if (string.IsNullOrEmpty(month))
                {
                    queryText = string.Format("select  sum(w.how_long) from users u join worklist w on u.ID= w.userID where year(w.data)='{0}' and u.name='{1}' and u.surname='{2}'", year, mostDep[0],mostDep[1]);
                }
                else
                {
                    month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();  //Konwersja miesiaca pisanego na liczbę  "Czerwiec" -> "6"
                    queryText = string.Format("select  sum(w.how_long) from users u join worklist w on u.ID= w.userID where year(w.data)='{0}' and month(w.data)='{1}' and u.name='{2}' and u.surname='{3}'", year, month, mostDep[0],mostDep[1]);
                }
                List<string> result = new List<string>();

                DataBaseControl.OpenConnection(conn);
                result = DataBaseControl.Select(conn, queryText);

                int tmpTime = Convert.ToInt16(result[0]) / 60;
                return tmpTime.ToString();
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
                return null;
            }
            catch
            {
                return "Brak Danych";
            }
         

            finally
            {
                DataBaseControl.CloseConnection(conn);
            }
        }

        public string getMostActivWorker(string month, string year)
        {
            try
            {
                string queryText;
                DataBaseControl.OpenConnection(conn);

               if (string.IsNullOrEmpty(month))
               {
                    queryText = string.Format("Select concat(u.name,' ',u.surname) from users u join worklist w on u.ID = w.userID join departments d on w.departamentID=d.ID where year(w.data)='{0}' group by d.name , u.ID order by sum(w.how_long) desc", year);
               }
               else
                {
                    month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();  //Konwersja miesiaca pisanego na liczbę  "Czerwiec" -> "6"
                    queryText = string.Format("Select concat(u.name,' ',u.surname) from users u join worklist w on u.ID = w.userID join departments d on w.departamentID=d.ID where year(w.data)='{0}' and month(w.data)='{1}' group by d.name , u.ID order by sum(w.how_long) desc", year,month);
                }
                List<string> result = new List<string>();
                result = DataBaseControl.Select(conn, queryText);

                return result[0];
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
                return null;
            }
            catch
            {
                return "Brak Danych";
            }
         
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }

        }

        public string getMostActiveDepartment(string month, string year)
        {
            try
            {
                string queryText;
                DataBaseControl.OpenConnection(conn);

                if (string.IsNullOrEmpty(month))
                {
                    queryText = string.Format("select d.name from departments d join worklist w on d.ID= w.departamentID where year(w.data)='{0}' group by 1 order by sum(how_long) desc limit 1", year);
                }
                else
                {
                    month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();  //Konwersja miesiaca pisanego na liczbę  "Czerwiec" -> "6"
                    queryText = string.Format("select d.name from departments d join worklist w on d.ID= w.departamentID where year(w.data)='{0}'  and month(w.data)='{1}' group by 1  order by sum(how_long) desc limit 1", year, month);
                }
                List<string> result = new List<string>();
                result = DataBaseControl.Select(conn, queryText);

                return result[0];
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
                return null;
            }
            catch
            {
                return "Brak Danych";
            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }
        }
        public string getMostActiveDepartmentWorkTime(string month, string year)
        {
            try
            {
                string queryText;
                DataBaseControl.OpenConnection(conn);
                string mostDep = getMostActiveDepartment(month, year);

                if (string.IsNullOrEmpty(month))
                {
                    queryText = string.Format("select sum(w.how_long) from departments d join worklist w on d.ID= w.departamentID where year(w.data)='{0}' and d.name = '{1}' ", year,mostDep);
                }
                else
                {
                    month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();  //Konwersja miesiaca pisanego na liczbę  "Czerwiec" -> "6"
                    queryText = string.Format("select sum(how_long) from departments d join worklist w on d.ID= w.departamentID where year(w.data)='{0}'  and month(w.data)='{1}' group by d.ID order by sum(how_long) desc limit 1", year, month);
                }
                List<string> result = new List<string>();

                DataBaseControl.OpenConnection(conn);
                result = DataBaseControl.Select(conn, queryText);

                int tmpTime = Convert.ToInt16(result[0]) / 60;

                return tmpTime.ToString();
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
                return null;
            }
            catch
            {
                return "Brak Danych";

            }
          
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }
        }


        public DataTable getWorkersGrid(string month, string year)
        {
       
            try
            {
                string queryText;
           
                if (string.IsNullOrEmpty(month))
                {
                    queryText = string.Format("Select u.name imie, u.surname nazwisko, sum(w.how_long) Czas_Pracy, d.name Dział  from users u join worklist w on u.ID = w.userID join departments d on w.departamentID=d.ID where year(w.data)='{0}' group by d.name , u.ID order by u.surname", year);
                }
                else
                {
                    month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();  //Konwersja miesiaca pisanego na liczbę  "Czerwiec" -> "6"
                    queryText = string.Format("Select u.name imie, u.surname nazwisko, sum(w.how_long) Czas_Pracy, d.name Dział  from users u join worklist w on u.ID = w.userID join departments d on w.departamentID=d.ID where year(w.data)='{0}' and month(w.data)='{1}' group by d.name , u.ID order by u.surname", year, month);
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
