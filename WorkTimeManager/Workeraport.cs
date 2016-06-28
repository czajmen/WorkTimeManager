using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace WorkTimeManager
{
    class Workeraport
    {

        private MySqlConnection conn = DataBaseControl.CreateConnection("time_manager"); 


        public List<string> generate(string UserForRaport,string date,int which)
        {
            string[] tmpdate = date.Split(' ');
            string[] tmpworker = UserForRaport.Split(' ');

            List<string> result = new List<string>();


            if (which == 2)  //Dzienny
            {
                result.Add(GetAllWordHours(tmpdate[0], tmpdate[1], tmpdate[2], tmpworker[0], tmpworker[1]));
                result.Add(mostWorkedDepartment(tmpdate[0], tmpdate[1], tmpdate[2], tmpworker[0], tmpworker[1]));             

            }
            else if (which == 1) //Miesięczny
            {
                result.Add(GetAllWordHours(null, tmpdate[0], tmpdate[1], tmpworker[0], tmpworker[1]));
                result.Add(mostWorkedDepartment(null, tmpdate[0], tmpdate[1], tmpworker[0], tmpworker[1]));           
                result.AddRange(GetMostWorkedDay(null, tmpdate[0], tmpdate[1], tmpworker[0], tmpworker[1]));
            }
            else
            { return null; }

 
            return result;
        }

        public DataTable GetDataGridAdapter(string UserForRaport, string date, int which)
        {
            string[] tmpdate = date.Split(' ');
            string[] tmpworker = UserForRaport.Split(' ');

            if (which == 2)  //Dzienny
            {
                return GetDataGrid(tmpworker[0], tmpworker[1], tmpdate[2], tmpdate[1], tmpdate[0]);
            }
            else if (which == 1) //Miesięczny
            {
                return GetDataGrid(tmpworker[0], tmpworker[1], tmpdate[1], tmpdate[0], null);
            }
            else
            { return null; }
        }


        private List<string> GetMostWorkedDay(string day, string month, string year, string name, string surname)  //Poprawić
        {
            string DateMostWorkedDay;
            string hoursCount;
            List<string> result = new List<string>();

            try
            {
                string month_converted = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();
                string queryText = string.Format("select CAST(w.data AS char) as data from worklist w join users u on w.userID = u.ID where  month(w.data)='{0}' and year(w.data)='{1}' and u.name='{2}' and u.surname='{3}' order by sum(w.how_long) limit 1", month_converted, year, name, surname);

                DataBaseControl.OpenConnection(conn);

                List<string> tmpresult = DataBaseControl.Select(conn, queryText);
                DateMostWorkedDay = DataBaseControl.ResultToString(tmpresult);

                string[] tmp_date = DateMostWorkedDay.Split('-');


                hoursCount = GetAllWordHours(tmp_date[2], month, tmp_date[0], name, surname);


                if (string.IsNullOrEmpty(DateMostWorkedDay) || string.IsNullOrWhiteSpace(DateMostWorkedDay))
                {
                    DateMostWorkedDay = "Brak Danych";
                }

                result.Add(DateMostWorkedDay);
                result.Add(hoursCount);

                return result;
            }
            catch (MySqlException myexc)
            {

                MessageBox.Show(myexc.Message);
                return null;
            }
            catch
            {
                result.Add("Brak Danych");
                result.Add("Brak Danych");
                return result;

            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }

        }


        private string mostWorkedDepartment(string day, string month, string year, string name, string surname) //Poprawić źle pobiera nazwe działu firmy
        {
            try
            {
                string queryText;

               month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();
                DataBaseControl.OpenConnection(conn);
                if (string.IsNullOrEmpty(day))
                {
                    queryText = string.Format("Select d.name from worklist w join users u on w.userID=u.ID join departments d on d.ID=w.departamentID where u.name='{0}' and  u.surname='{1}' and year(w.data)='{2}' and month(w.data)='{3}' group by 1 order by sum(w.how_long) desc limit 1", name, surname, year, month);

                }
                else
                {
                    queryText = string.Format("Select d.name from worklist w join users u on w.userID=u.ID join departments d on d.ID=w.departamentID where u.name='{0}' and  u.surname='{1}' and year(w.data)='{2}' and month(w.data)='{3}' and day(w.data)='{4}' group by 1 order by sum(w.how_long) desc limit 1", name, surname, year, month, day);
                }

                List<string> time = new List<string>();
                time = DataBaseControl.Select(conn, queryText);


                if (string.IsNullOrEmpty(time[0]) || string.IsNullOrWhiteSpace(time[0]))
                {
                    time[0] = "Brak Danych";
                }

                return time[0];
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

        private string GetAllWordHours(string day, string month, string year, string name, string surname)
        {

            try
            {
                int tmpresult;
                string queryText;
                month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();
                DataBaseControl.OpenConnection(conn);


                if (!string.IsNullOrEmpty(day))
                {
                    queryText = string.Format("Select sum(w.how_long) from worklist w join users u on w.userID=u.ID where u.name='{0}' and  u.surname='{1}' and year(w.data)='{2}' and month(w.data)='{3}' and day(w.data)='{4}' ", name, surname, year, month, day);
                }
                else
                {
                    queryText = string.Format("Select sum(w.how_long) from worklist w join users u on w.userID=u.ID where u.name='{0}' and  u.surname='{1}' and year(w.data)='{2}' and month(w.data)='{3}'", name, surname, year, month);
                }

                List<string> time = new List<string>();
                time = DataBaseControl.Select(conn, queryText);


                if (string.IsNullOrEmpty(time[0]) || string.IsNullOrWhiteSpace(time[0]))
                {
                    time[0] = "0";
                }
                else
                {
                    tmpresult = Convert.ToInt16(time[0]) / 60;
                    time[0] = tmpresult.ToString();
                }

                return time[0];
            }
            catch (MySqlException myexc)
            {

                MessageBox.Show(myexc.Message);
                return null;
            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }
        }

        private DataTable GetDataGrid(string name, string surname, string year, string month, string day)
        {
            try
            {

                string queryText;
                month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();  //Konwersja miesiaca pisanego na liczbę  "Czerwiec" -> "6"
                if (string.IsNullOrEmpty(day))
                {
                    queryText = string.Format("Select w.title Tytuł , w.data Data, w.how_long CzasWminutach, d.name Dział from worklist w join departments d on w.departamentID=d.ID  join users u on w.userID =u.ID where u.name='{0}' and u.surname='{1}' and year(w.data)='{2}' and month(w.data)='{3}' ", name, surname, year, month);
                }
                else
                {
                    queryText = string.Format("Select w.title Tytuł , w.data Data, w.how_long CzasWminutach, d.name Dział from worklist w join departments d on w.departamentID=d.ID  join users u on w.userID =u.ID where u.name='{0}' and u.surname='{1}' and year(w.data)='{2}' and month(w.data)='{3}' and day(w.data)='{4}'  ", name, surname, year, month, day);
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
