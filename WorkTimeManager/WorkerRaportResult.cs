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
       private Workeraport raport = new Workeraport();

        public DayWorkerRaportResult()
        {
            InitializeComponent();


        }

        public void generate(string UserForRaport,string date,int which)
        {
          
            List<string> GeneratedRaportResult = new List<string>();  //Elementy wygenerowengo raportu

            Hide_ShowLabels(which);
            worker.Text = UserForRaport;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            data.Text = date;

            dataGridView1.DataSource = raport.GetDataGridAdapter(UserForRaport, date, which);
            GeneratedRaportResult = raport.generate(UserForRaport, date, which);


            TotalWork.Text = GeneratedRaportResult[0];
            mostdep.Text = GeneratedRaportResult[1];

            if(which==1)
            {
                mostDayDate.Text = GeneratedRaportResult[2];
                MostDayTime.Text = GeneratedRaportResult[3];
            }
            
        }

        private void Hide_ShowLabels(int which)
        {
            if (which == 2)  //Dzienny
            {
                label4.Hide();
                label6.Hide();
                mostDayDate.Hide();
                MostDayTime.Hide();

            }
            else if (which == 1) //Miesięczny
            {
                label4.Show();
                label6.Show();
                mostDayDate.Show();
                MostDayTime.Show();
            }
        }

     private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
