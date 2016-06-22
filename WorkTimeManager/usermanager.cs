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
    class usermanager
    {
        public MySqlConnection conn = DataBaseControl.CreateConnection("time_manager");   

        private bool testLogin(string login)
        {
            try
            {
                DataBaseControl.OpenConnection(conn);

                string queryText = string.Format("Select count(*) from users where login='{0}'", login);  //zabezpieczyć
                List<string> result = DataBaseControl.Select(conn, queryText);

               if(Convert.ToInt16(result[0])==0)
               {
                   return true;
               }
               else
               {
                   return false;
               }

            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
                DataBaseControl.CloseConnection(conn);
                return false;

            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
                
            }
        }


        private bool nameTester(string name, string surname)
        {
            try
            {
                DataBaseControl.OpenConnection(conn);

                string queryText = string.Format("Select count(*) from users where name='{0}' and surname='{1}'",name,surname ); 
                List<string> result = DataBaseControl.Select(conn, queryText);

                if (Convert.ToInt16(result[0]) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (MySqlException myexc)
            {
                DataBaseControl.CloseConnection(conn);
                MessageBox.Show(myexc.Message);
                return false;
            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }

        }

        public void registerNewUser(string login, string password,string name, string surname,int depatrment_id,bool admin)
        {
            try
            {
       

                DataBaseControl.OpenConnection(conn);

                if(testLogin(login))
                {
                    if(nameTester(name,surname))
                    {
                        DataBaseControl.OpenConnection(conn); // W metodach sprawdzających warunki zamykam sobie połaczenie wiec przed insertem tak czy siak musze je na nowo utworzyć
                        string queryText = string.Format("insert into users (login,password,name,surname,department_ID,admin) values ('{0}','{1}','{2}','{3}','{4}','{5}')", login, CryptPassword(password), name, surname, depatrment_id, admin);
                        DataBaseControl.insertData(conn, queryText);
                        MessageBox.Show("Użytkownik został dodany!");
                    }
                    else
                    {
                        MessageBox.Show("Ta kombinacja Imienia i Nazwiska jest już w użyciu. Pro TIP możesz dodać po ostatniej literze nazwiska numer.");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Ten login jest już zajęty!");
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

        public DataTable searchUser(string text)
        {
            try
            {

                DataBaseControl.OpenConnection(conn);
                string queryText = string.Format("Select * from users where name LIKE'%{0}%' or surname LIKE '%{1}%'", text,text);
                DataTable userDetails = new DataTable();
                userDetails = DataBaseControl.SelecTest(conn, queryText);

                return userDetails;             
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

        public DataTable getUserDetails(string name, string surname)
        {
            try
            {
                DataBaseControl.OpenConnection(conn);
            
                DataTable userDetails = new DataTable();
                string queryText = string.Format("Select * from users where name='{0}' or surname='{1}'", name, surname);
                userDetails = DataBaseControl.SelecTest(conn, queryText);

                return userDetails;
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
                DataBaseControl.CloseConnection(conn);
                return null;
            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }
        }

        public string CryptPassword(string newpassword)
        {


            return newpassword;
        }

        private List<string> getNameByID(string id)
        {
            try
            {
                DataBaseControl.OpenConnection(conn);

                List<string> NameSurname = new List<string>();

                string queryText = string.Format("Select name,surname from users where ID='{0}'", id);
                 NameSurname=DataBaseControl.Select(conn,queryText);

                 return NameSurname;
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
                DataBaseControl.CloseConnection(conn);
                return null;
            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }

        }

        public bool changeUser(string id,string login,string password, string name, string surname,string depatrment_id,string admin )  //poprawić bo sie sypie
        {

             try
            {


                bool can = true;   // True if we can change name/surname  false if is arleady used

                 if(nameTester(name,surname))
                 {
                     can = false;
                     List<string> tmpNameSurname = new List<string>();

                     tmpNameSurname = getNameByID(id);
                                
                    if(tmpNameSurname[0]==name && tmpNameSurname[1]==surname)
                    {
                        can = true;
                    }              
                 }
 
                    DataBaseControl.OpenConnection(conn);  
           
                 if(string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))  // Sprawdza czy pole hasło nie jest puste
                 {
                     string queryText = "update users set name='" + name + "',surname='" + surname + "',department_ID='" + depatrment_id + "',admin='" + admin + "' where ID='" + id + "'";
                     DataBaseControl.insertData(conn, queryText);
                     MessageBox.Show("Dane zostały zmienione!");
                 }
                 else
                 {
                     string queryText = "update users set password='" + CryptPassword(password) + "',name='" + name + "',surname='" + surname + "',department_ID='" + depatrment_id + "',admin='" + admin + "' where ID='" + id + "'";
                     DataBaseControl.insertData(conn, queryText);
                     MessageBox.Show("Dane zostały zmienione!");
                 }
                                           
                    return true;
        
            }
            catch (MySqlException myexc)
            {
                MessageBox.Show(myexc.Message);
                DataBaseControl.CloseConnection(conn);
                return false;
            }
            finally
            {
                DataBaseControl.CloseConnection(conn);
            }
        }



    }


 
}
