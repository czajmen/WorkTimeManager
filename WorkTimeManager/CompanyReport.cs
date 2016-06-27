using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeManager
{
    public partial class CompanyReport : UserControl
    {


        private CompanyRaport raport = new CompanyRaport();
        public CompanyReport()
        {
            InitializeComponent();
            tabPage1.Text = "Pracownicy";
            tabPage2.Text = "Działy";

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MMMM yyyy";
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Mraport.Checked)  //raport roczny
            {               
                string year = dateTimePicker1.Text.ToString();

                dataGridView1.DataSource = raport.getWorkersGrid(null, year);
                dataGridView2.DataSource = raport.getDepartmensGrid(null, year);   

            }
            else if (Draport.Checked)  //Raport miesięczny
            {
                string[] date = dateTimePicker2.Text.ToString().Split(' ');

                dataGridView1.DataSource = raport.getWorkersGrid(date[0], date[1]);
                dataGridView2.DataSource = raport.getDepartmensGrid(date[0], date[1]);
                
            }
            else
            {
                MessageBox.Show("Uzupełnij wszyskie pola aby wygenerować raport!");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Mraport.Checked = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Draport.Checked = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
