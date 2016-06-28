using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;



namespace WorkTimeManager
{
     
    public partial class WorkTimeRaport : Form
    {
        public MySqlConnection conn = DataBaseControl.CreateConnection("time_manager");  
        private  user _test;
        private departments departments = new departments();

        public WorkTimeRaport(user test)
        {
            _test = test;
            
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
           

            for (int i = 0; i < departments.ilosc;i++ )
            {
                string[] tmp = departments[i];
                Departments_Box.Items.Add(tmp[1]);
            }

           Departments_Box.SelectedIndex = 0;

           try
           {
               string queryText;
               string day;
               string month;
               string years;
               string fulldata;

               if(monthCalendar.SelectionStart.Day>9)
               {
                   day = monthCalendar.SelectionStart.Day.ToString();
               }
               else
               {
                   day ="0"+ monthCalendar.SelectionStart.Day.ToString();
               }
               
               if(monthCalendar.SelectionStart.Month>9)
               {
                   month = monthCalendar.SelectionStart.Month.ToString();
               }

               else
               {
                   month = "0" + monthCalendar.SelectionStart.Month.ToString();
                   day = "0" + monthCalendar.SelectionStart.Day.ToString();
               }
               
               years = monthCalendar.SelectionStart.Year.ToString();
               fulldata = years + month + day;



             //  queryText = string.Format("SELECT CAST(w.data AS char) as data, w.title, how_long, ID FROM time_manager.worklist w");
               queryText = string.Format("select CAST(w.data AS char) as data,ID, title,how_long from worklist w where  day(w.data)='{0}' and month(w.data)='{1}' and year(w.data)='{2}' ", day, month, years);

               DataTable Data = new DataTable();
               Data = DataBaseControl.SelecTest(conn, queryText);
               dataGridView1.DataSource = Data;

           }
           finally
           {
               DataBaseControl.CloseConnection(conn);
           }


        }



        private void Insert_Click(object sender, EventArgs e)
        {
          //  string insert;
            string rok;
            
            string title;
            string minutes;
            string department;
            string day;
            string month;
            string years;
            string fulldata;
            string queryText;
            day = monthCalendar.SelectionStart.Day.ToString();
            
            years = monthCalendar.SelectionStart.Year.ToString();
            
            title = Topic.Text.ToString();
            minutes= TextBoxMinutes.Text.ToString();
          // // MessageBox.Show(minutes);
            if (monthCalendar.SelectionStart.Day > 9)
            {
                day = monthCalendar.SelectionStart.Day.ToString();
            }
            else
            {
                day = "0" + monthCalendar.SelectionStart.Day.ToString();
            }

            if (monthCalendar.SelectionStart.Month > 9)
            {
                rok = monthCalendar.SelectionStart.Year.ToString()+ monthCalendar.SelectionStart.Month.ToString() + day;
                month = monthCalendar.SelectionStart.Month.ToString();
                day = monthCalendar.SelectionStart.Day.ToString();
            }
            else
            {
            rok = monthCalendar.SelectionStart.Year.ToString() + "0" + monthCalendar.SelectionStart.Month.ToString() + day;
            month = "0" + monthCalendar.SelectionStart.Month.ToString();
           //day = "0" + monthCalendar.SelectionStart.Day.ToString();
            }

            fulldata = years + month + day;
      //      MessageBox.Show(rok);
                
                //MessageBox.Show(rok);
   
            //insert= "insert into worklist values(null,1,"+title+","+rok+",2,34)";
        //   insert= "insert into worklist values(null,1,temat,"+rok+",2,"+minutes+")";
          //  raport test22 = new raport(insert);
          department = (this.Departments_Box.SelectedIndex + 1).ToString();

           try
           {
               DataBaseControl.OpenConnection(conn);

             bool  canRegister = true;

               foreach (Control x in this.Controls)
               {


                   if (x.Name != dataGridView1.Name  &&  x.Name!=monthCalendar.Name)
                   {
                       if (string.IsNullOrEmpty(x.Text) || string.IsNullOrWhiteSpace(x.Text))
                       {
                           errorProvider1.SetError(x, "To pole nie może zostać puste!");
                           canRegister = false;

                       }
                   }
                 
               }

               if (canRegister)
               {
                    queryText = string.Format("insert into worklist values(null,{0},'{1}',{2},{3},{4})", _test.userID, title, rok, department, minutes);
                   DataBaseControl.insertData(conn, queryText);

                   errorProvider1.Clear();
                  
               }
               else
               {
                   MessageBox.Show("Aby zarejestrować użytkownika wypełnij wszystkie pola!");
               }





               queryText = string.Format("select CAST(w.data AS char) as data,w.ID ID, title,how_long minuty,d.name dział from worklist w join departments d on w.departamentID=d.ID where  day(w.data)='{0}' and month(w.data)='{1}' and year(w.data)='{2}' ", day, month, years);

               DataTable Data = new DataTable();
               Data = DataBaseControl.SelecTest(conn, queryText);
               dataGridView1.DataSource = Data;
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

        private void Topic_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkTimeRaport_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                DataBaseControl.OpenConnection(conn);
                string month;
                string day;

                if (monthCalendar.SelectionStart.Day > 9)
                {
                    day = monthCalendar.SelectionStart.Day.ToString();
                }
                else
                {
                    day = "0" + monthCalendar.SelectionStart.Day.ToString();
                }

                if (monthCalendar.SelectionStart.Month >9)
                {
                    month = monthCalendar.SelectionStart.Month.ToString();
                }

                else
                {
                    month = "0" + monthCalendar.SelectionStart.Month.ToString();
                   // day = "0" + monthCalendar.SelectionStart.Day.ToString();
                }
                string queryText = string.Format("select CAST(w.data AS char) as data,w.ID, title,how_long,d.name from worklist w join departments d on w.departamentID=d.ID join users u on w.userID=u.ID where  day(w.data)='{0}' and month(w.data)='{1}' and year(w.data)='{2}' and w.userID='{3}'", day, month, monthCalendar.SelectionStart.Year.ToString(),_test.userID);

                DataTable Data = new DataTable();
                Data = DataBaseControl.SelecTest(conn, queryText);
                dataGridView1.DataSource = Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
           
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxMinutes_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch)&& ch!=8)
            {
                e.Handled = true;
                MessageBox.Show("Wpisz tylko liczbę");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
