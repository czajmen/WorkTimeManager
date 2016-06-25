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
        private  user _test;

        public WorkTimeRaport(user test)
        {
            _test = test;
            InitializeComponent();
        }

   

        private void Insert_Click(object sender, EventArgs e)
        {
            string insert;
            string rok;
            string title;
            title = Topic.Text.ToString();
            
            rok = monthCalendar.SelectionStart.Year.ToString() +"0"+ monthCalendar.SelectionStart.Month.ToString() + monthCalendar.SelectionStart.Day.ToString();
            
            insert= "insert into worklist values(null,1,"+title+","+rok+",2,34)";
            raport test22 = new raport(insert);
            
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
    }
}
