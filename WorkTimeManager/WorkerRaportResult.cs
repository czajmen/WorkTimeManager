using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace WorkTimeManager
{
    public partial class DayWorkerRaportResult : UserControl
    {
        public MySqlConnection conn = DataBaseControl.CreateConnection("time_manager"); 
     
        public DayWorkerRaportResult()
        {
            InitializeComponent();


        }

        public void generate(string UserForRaport,string date,int which)
        {
            string[] tmpdate = date.Split(' ');
            string[] tmpworker = UserForRaport.Split(' ');

            data.Text = date;        
            worker.Text = UserForRaport;


            if(which==2)
            {

                MessageBox.Show(tmpdate[0] + tmpdate[2]);
                dataGridView1.DataSource = GetDataGrid(tmpworker[0], tmpworker[1], tmpdate[2], tmpdate[1], tmpdate[0]);
            }
            else if (which==1)
            {
                dataGridView1.DataSource = GetDataGrid(tmpworker[0], tmpworker[1], tmpdate[2], tmpdate[1], null);
            }
            
        }

   

        public DataTable GetDataGrid(string name, string surname, string year, string month, string day)
        {
            try
            {

                string queryText;
                month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();  //Konwersja miesiaca pisanego na liczbę  "Czerwiec" -> "6"
                if(string.IsNullOrEmpty(day))
                {
                    queryText = string.Format("Select w.title Tytuł , w.data Data, w.how_long CzasWminutach, d.name Dział from worklist w join departments d on w.departamentID=d.ID  join users u on w.userID =u.ID where u.name='{0}' and u.surname='{1}' and year(w.data)='{2}' and month(w.data)='{3}' ", name, surname, year, month);
                }
                else
                {
                    queryText = string.Format("Select w.title Tytuł , w.data Data, w.how_long CzasWminutach, d.name Dział from worklist w join departments d on w.departamentID=d.ID  join users u on w.userID =u.ID where u.name='{0}' and u.surname='{1}' and year(w.data)='{2}' and month(w.data)='{3}' and day(w.data)='{4}'  ", name, surname, year, month,day);
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
