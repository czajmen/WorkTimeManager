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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Login_Password.PasswordChar = '*' ;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
          user CurrentlyLoggedUser = new user(this.Login_Login.Text, this.Login_Password.Text,this);

            //user CurrentlyLoggedUser = new user("czajmen", "test", this);
          // user CurrentlyLoggedUser = new user("czajmen", "test", this);

        }
    }
}
