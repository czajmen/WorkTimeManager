﻿using System;
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

            List<string> tmp = new List<string>();  //Lista do dnia w ktorym przepracował najwiecej godzin
                
            worker.Text = UserForRaport;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            if(which==2)  //Dzienny
            {
         
                
                dataGridView1.DataSource = GetDataGrid(tmpworker[0], tmpworker[1], tmpdate[2], tmpdate[1], tmpdate[0]);         
                data.Text = tmpdate[0] + " " + tmpdate[1] + " " + tmpdate[2];
                TotalWork.Text = GetAllWordHours(tmpdate[0], tmpdate[1], tmpdate[2], tmpworker[0], tmpworker[1]);
                mostdep.Text = mostWorkedDepartment(tmpdate[0], tmpdate[1], tmpdate[2], tmpworker[0], tmpworker[1]);
                overhours.Text = GetUserOverHours(tmpdate[0], tmpdate[1], tmpdate[2], tmpworker[0], tmpworker[1]);       
               

                //nie ma sensu wyświetlać najdłużej przepracowanego dnia skoro generujemy raport tylko z jednego dnia
                label4.Hide();
                label6.Hide();

               
        
            }
            else if (which==1)  //Miesięczny 
            {
                dataGridView1.DataSource = GetDataGrid(tmpworker[0], tmpworker[1], tmpdate[2], tmpdate[1], null);
                data.Text = tmpdate[1] +" "+ tmpdate[2];
                TotalWork.Text = GetAllWordHours(null, tmpdate[1], tmpdate[2], tmpworker[0], tmpworker[1]);
                mostdep.Text = mostWorkedDepartment(null, tmpdate[1], tmpdate[2], tmpworker[0], tmpworker[1]);
                overhours.Text = GetUserOverHours(null, tmpdate[1], tmpdate[2], tmpworker[0], tmpworker[1]);

             //   tmp = GetMostWorkedDay(null, tmpdate[1], tmpdate[2], tmpworker[0], tmpworker[1]);

                mostDayDate.Text = "0";
                MostDayTime.Text = "1";
                    
           }         
        }


        private string GetUserOverHours(string day, string month, string year, string name, string surname)
        {

            try
            {         
                string result;

                    month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();         
                    double worktime = Convert.ToInt16(TotalWork.Text);
                    worktime = (worktime/60) - 8;

                    if (worktime > 0)
                    {
                        result = worktime.ToString();
                    }
                    else
                    {
                        result = "0";
                    }

                return result;

            }
            catch
            {
                MessageBox.Show("Wystąpił nieznany bład!");
                return "0";
            }

        
        }

        private List<string> GetMostWorkedDay(string day, string month, string year, string name, string surname)  //Poprawić
        {
            string DateMostWorkedDay;
            string hoursCount;
            List<string> result = new List<string>();

            try
            {
                string queryText = string.Format("select w.data from worklist w join users u on w.userID = u.ID where day(w.data)='{0}' and month(w.data)='{1}' and year(w.data)='{2}' and u.name='{3}' and u.surname='{4}' order by sum(w.how_long) limit 1", day, month, year, name, surname);

                 DataBaseControl.OpenConnection(conn);

                List<string> tmpresult = DataBaseControl.Select(conn, queryText);
                DateMostWorkedDay = DataBaseControl.ResultToString(tmpresult);

                hoursCount = GetAllWordHours(day, month, year, name, surname);

                result.Add(DateMostWorkedDay);
                result.Add(hoursCount);



                return result;
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


        private string mostWorkedDepartment(string day, string month, string year, string name, string surname)
        {
            try
            {
                string queryText;

                month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();
                DataBaseControl.OpenConnection(conn);
                if (string.IsNullOrEmpty(day))
                {
                     queryText = string.Format("Select d.name from worklist w join users u on w.userID=u.ID join departments d on d.ID=w.departamentID where u.name='{0}' and  u.surname='{1}' and year(w.data)='{2}' and month(w.data)='{3}' order by sum(w.how_long) limit 1", name, surname, year, month);
                    
                }
                else
                {
                    queryText = string.Format("Select d.name from worklist w join users u on w.userID=u.ID join departments d on d.ID=w.departamentID where u.name='{0}' and  u.surname='{1}' and year(w.data)='{2}' and month(w.data)='{3}' and day(w.data)='{4}' order by sum(w.how_long) limit 1", name, surname, year, month,day);
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
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }
        }

        private string GetAllWordHours(string day, string month, string year, string name, string surname)
        {

            try
            {
                string queryText;
                month = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();
                DataBaseControl.OpenConnection(conn);

                MessageBox.Show(month + " " + year);

                if(!string.IsNullOrEmpty(day))
                {
                     queryText = string.Format("Select sum(w.how_long) from worklist w join users u on w.userID=u.ID where u.name='{0}' and  u.surname='{1}' and year(w.data)='{2}' and month(w.data)='{3}' and day(w.data)='{4}' ", name, surname, year, month, day); 
                }
                else
                {
                     queryText = string.Format("Select sum(w.how_long) from worklist w join users u on w.userID=u.ID where u.name='{0}' and  u.surname='{1}' and year(w.data)='{2}' and month(w.data)='{3}'", name, surname, year, month);
                }
             
                List <string> time = new List<string>();
                time= DataBaseControl.Select(conn,queryText);

                if (string.IsNullOrEmpty(time[0]) || string.IsNullOrWhiteSpace(time[0]))
                {
                    time[0] = "0";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
