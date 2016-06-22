﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace WorkTimeManager
{
   public class user
    {
        public string name { get; private set; }      // Pola przechowywujące informacje o użytkowniku (nic w nich nie zmieniaj tylko z nich pobieraj wszystkoi ci tam wpisze co trzeba)
        public string surname { get; private set; }
        public int userID { get; private set; }
        public int departmentID { get; private set; }
        public bool isAdmin { get; private set; }

        public string login;     // tego nie tykaj xd nie będzie Ci potrzebne

        public MySqlConnection conn;  //Database connection handler

        public user(string login, string password, LoginForm loginForm)  //Konstruktor który loguje użytkownika i odpala Twój albo mój interfejs w zależności czy jest logowany user adminem
        {
           // isAdmin = true ;  // Tymczaowe zmień se na false jak chcesz zeby wyświetliło Twoje okno

            string stringResult="";
         
  //////////////////////////////////////Database operations//////////////////////////////////////////////////////////
            try
            {
                conn = DataBaseControl.CreateConnection("time_manager");  //Nazwa Bazy danych 
                DataBaseControl.OpenConnection(conn);

                string queryText = string.Format("Select count(*) from users where login='{0}' and password='{1}'", login, CryptPassword(password));
                List<string> result = DataBaseControl.Select(conn, queryText);
                stringResult = DataBaseControl.ResultToString(result);
             

            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }     

//////////////////////////////////////////////////////////////////////////////////////////////////////
                
             if (Convert.ToInt16(stringResult) > 0)
             {
                 this.login = login;
                 this.setUserDetail(this.getUserID(this));

                    if (this.isAdmin == true)
                    {
                        AdminForm adminForm = new AdminForm(this);
                        adminForm.Show();
                        loginForm.Hide();
                    }
                    else
                    {
                        WorkTimeRaport workRapot = new WorkTimeRaport(this);
                        workRapot.Show();
                        loginForm.Hide();
                    }
             }
             else
             {
                 MessageBox.Show("Nie prawidłowy Login/Hasło");
            }   
        }


        private string CryptPassword(string newpassword)
        {


            return newpassword;
        }
        
        private int getUserID(user user)
        {
            int ID=0;

            try
            {            
                DataBaseControl.OpenConnection(conn);
                string queryText = string.Format("Select ID from users where login='{0}'", user.login);
           
                List<string> result = DataBaseControl.Select(conn, queryText);
                string stringResult = DataBaseControl.ResultToString(result);

                ID=Convert.ToInt16(stringResult);
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }

            return ID;
        }

        private void setUserDetail(int userID)
        {
            try
            {
                DataBaseControl.OpenConnection(conn);
                string queryText = string.Format("Select * from users where ID='{0}'", userID);
                DataTable userDetails = new DataTable();
                userDetails = DataBaseControl.SelecTest(conn, queryText);

                foreach (DataRow row in userDetails.Rows)
                {
                    this.userID = Convert.ToInt16(row[0]);
                     this.name = row[3].ToString();
                     this.surname = row[4].ToString();
                     this.departmentID = Convert.ToInt16(row[5]);
                     this.isAdmin = Convert.ToBoolean(row[6]);
                }
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
