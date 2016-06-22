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
            insert= "insert into worklist values(null,1,'twew',2000-12-08,2000-09-13)";
            raport test22 = new raport(insert); 
          
        }

        private void Topic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
