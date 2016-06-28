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

namespace WorkTimeManager
{
     partial class AdminForm : Form
    {

        private user currentylyLoggedUser;
        public MySqlConnection conn; 

        public  AdminForm(user loggeduser) // Przekasuje sobie obiekt klasy user między formami w konstruktorze i dopisuje go pod pole prywatne aktualnego forma
        {
            conn = DataBaseControl.CreateConnection("time_manager");  //Nazwa Bazy danych 
       
           currentylyLoggedUser = loggeduser; //user przekazywany z login form do konstruktora admin form
           InitializeComponent();
           userRegister1.Visible = false;   //Kontrolka do rejestracji użytkownika jest dodana od początku do formy ale ukryta (hide) po kliknieciu w toolbar jest pokazywana a ekran powitalny ukrywany
           userModify1.Visible = false;
           workerRaport1.Visible = false;
           companyReport1.Visible = false;

           this.FormBorderStyle = FormBorderStyle.FixedDialog;
           this.MaximizeBox = false;
           this.MinimizeBox = false;
           this.StartPosition = FormStartPosition.CenterScreen;
           
       

        }

        private void rejestracjaNowegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userRegister1.Visible = true; //wyswietla kontrolke rejestracji (patrz konstruktor tej formy)
            helloScreen1.Visible = false; //Ukrywa ekran powitalny 
            workerRaport1.Visible = false;
            userModify1.Visible = false;
            companyReport1.Visible = false;

        }

        private void usuńObecnegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helloScreen1.Visible = false; //Ukrywa ekran powitalny 
            userModify1.Visible = true;
            workerRaport1.Visible = false;
            workerRaport1.Visible = false;
            companyReport1.Visible = false;
        }

        private void podsumowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helloScreen1.Visible = false; //Ukrywa ekran powitalny 
            workerRaport1.Visible = true;
            userModify1.Visible = false;
            userRegister1.Visible = false;
            companyReport1.Visible = false;
        }

        private void ogólnoFirmowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helloScreen1.Visible = false; //Ukrywa ekran powitalny 
            workerRaport1.Visible = false;
            userModify1.Visible = false;
            userRegister1.Visible = false;
            companyReport1.Visible = true;
        }

  
    }
}
