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
               day = monthCalendar.SelectionStart.Day.ToString();
               month = "0"+monthCalendar.SelectionStart.Month.ToString();
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
            day = monthCalendar.SelectionStart.Day.ToString();
            month = "0" + monthCalendar.SelectionStart.Month.ToString();
            years = monthCalendar.SelectionStart.Year.ToString();
            fulldata = years + month + day;
            title = Topic.Text.ToString();
            minutes= TextBoxMinutes.Text.ToString();
          // // MessageBox.Show(minutes);

          rok = monthCalendar.SelectionStart.Year.ToString() +"0"+ monthCalendar.SelectionStart.Month.ToString() + monthCalendar.SelectionStart.Day.ToString();
          //MessageBox.Show(rok);
   
            //insert= "insert into worklist values(null,1,"+title+","+rok+",2,34)";
        //   insert= "insert into worklist values(null,1,temat,"+rok+",2,"+minutes+")";
          //  raport test22 = new raport(insert);
          department = (this.Departments_Box.SelectedIndex + 1).ToString();

           try
           {
               DataBaseControl.OpenConnection(conn);
               string queryText = string.Format("insert into worklist values(null,{0},'{1}',{2},{3},{4})",_test.userID,title,rok,department,minutes);
               DataBaseControl.insertData(conn, queryText);
               queryText = string.Format("select CAST(w.data AS char) as data,w.ID, title,how_long,d.name from worklist w join departments d on w.departamentID=d.ID where  day(w.data)='{0}' and month(w.data)='{1}' and year(w.data)='{2}' ", day, month, years);

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

                string queryText = string.Format("select CAST(w.data AS char) as data,w.ID, title,how_long,d.name from worklist w join departments d on w.departamentID=d.ID join users u on w.userID=u.ID where  day(w.data)='{0}' and month(w.data)='{1}' and year(w.data)='{2}' and w.userID='{3}'", monthCalendar.SelectionStart.Day.ToString(), monthCalendar.SelectionStart.Month.ToString(), monthCalendar.SelectionStart.Year.ToString(),_test.userID);

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
