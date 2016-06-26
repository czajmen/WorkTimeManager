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
    public partial class WorkerRaport : UserControl
    {

        private usermanager usermanager = new usermanager();
        public WorkerRaport()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM yyyy";
            dayWorkerRaportResult1.Visible = false;
        }

        private void searchuser_workerraport_TextChanged(object sender, EventArgs e)
        {
            DataTable tmp = usermanager.searchUser(searchuser_workerraport.Text);
            SearchedUsers.Items.Clear();

            foreach (DataRow row in tmp.Rows)
            {
                string info = "";
                info += row[3].ToString();
                info += " ";
                info += row[4].ToString();

                SearchedUsers.Items.Add(info);
            }
        }

        private void SearchedUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchedUsers.SelectedIndex >= 0)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SearchedUsers.SelectedIndex >= 0 && Mraport.Checked)
            {
                dayWorkerRaportResult1.Visible = true;
                dayWorkerRaportResult1.generate(SearchedUsers.SelectedItem.ToString(), dateTimePicker2.Text, 1);

            }
            else if(SearchedUsers.SelectedIndex >= 0 && Draport.Checked)
            {
                dayWorkerRaportResult1.Visible = true;
                dayWorkerRaportResult1.generate(SearchedUsers.SelectedItem.ToString(),dateTimePicker2.Text,2);
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

        private void dayWorkerRaportResult1_Load(object sender, EventArgs e)
        {

        }
    }
}
