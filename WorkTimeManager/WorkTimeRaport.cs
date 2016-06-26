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

        public WorkTimeRaport(user test)
        {
            _test = test;
            InitializeComponent();
        }



        private void Insert_Click(object sender, EventArgs e)
        {
          //  string insert;
            string rok;
            
            string title;
            string minutes;

            title = Topic.Text.ToString();
            minutes= TextBoxMinutes.Text.ToString();
          // // MessageBox.Show(minutes);

          rok = monthCalendar.SelectionStart.Year.ToString() +"0"+ monthCalendar.SelectionStart.Month.ToString() + monthCalendar.SelectionStart.Day.ToString();
          //MessageBox.Show(rok);
   
            //insert= "insert into worklist values(null,1,"+title+","+rok+",2,34)";
        //   insert= "insert into worklist values(null,1,temat,"+rok+",2,"+minutes+")";
          //  raport test22 = new raport(insert);
           

           try
           {
               DataBaseControl.OpenConnection(conn);
               string queryText = string.Format("insert into worklist values(null,1,'{0}',{1},2,{2})",title,rok,minutes);
               DataBaseControl.insertData(conn, queryText);  
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
                MessageBox.Show("Please enter valid value");
            }
        }
    }
}
