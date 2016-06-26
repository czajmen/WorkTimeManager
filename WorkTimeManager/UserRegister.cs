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
    public partial class UserRegister1 : UserControl
    {

        private bool canRegister = true;

       private departments departments = new departments();
       private usermanager registerHandler = new usermanager();
    
        public UserRegister1()
        {
            InitializeComponent();
         
            Role_Register.Items.Add("Pracownik");
            Role_Register.Items.Add("Kierownik");
            Role_Register.SelectedIndex = 0;

           for (int i = 0; i < departments.ilosc;i++ )
            {
                string[] tmp = departments[i];
                Department_Register.Items.Add(tmp[1]);
            }

            Department_Register.SelectedIndex = 0;


         //   this.comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;

            Role_Register.DropDownStyle = ComboBoxStyle.DropDownList;
            Department_Register.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void clear()
        {
            foreach (Control x in this.Controls)
            {
                if(x is TextBox)
                {
                    x.Text = " ";
                }         
            }
        }

        private void Add_Register_Click(object sender, EventArgs e)
        {
            canRegister = true;

            foreach (Control x in this.Controls)
            {
                if (string.IsNullOrEmpty(x.Text) || string.IsNullOrWhiteSpace(x.Text))
                {
                    errorProvider1.SetError(x, "To pole nie może zostać puste!");
                    canRegister = false;
                   
                }
            }

            if(canRegister)
            {
                bool tmp = false;

                if (Department_Register.SelectedIndex != 0)
                    tmp = true;

                registerHandler.registerNewUser(this.Login_register.Text, this.Password_register.Text, this.Name_Register.Text, this.Surname_Register.Text, this.Department_Register.SelectedIndex+1, tmp);
             
                clear();
            }
            else
            {
                MessageBox.Show("Aby zarejestrować użytkownika wypełnij wszystkie pola!");
            }
            
        }

        private void Clear_register_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void UserRegister1_Load(object sender, EventArgs e)
        {

        }
    }
}
