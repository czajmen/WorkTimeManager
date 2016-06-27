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
    public partial class UserModify : UserControl
    {

        private departments departments = new departments();
        private usermanager registerHandler = new usermanager();

        public UserModify()
        {
            InitializeComponent();

            Role_modify.Items.Add("Pracownik");
            Role_modify.Items.Add("Kierownik");
            Role_modify.SelectedIndex = 0;

           for (int i = 0; i < departments.ilosc; i++)
            {
                string[] tmp = departments[i];
                Department_modify.Items.Add(tmp[1]);
            }

            Department_modify.SelectedIndex = 0;

            Role_modify.DropDownStyle = ComboBoxStyle.DropDownList;
            Department_modify.DropDownStyle = ComboBoxStyle.DropDownList;

            Password_modify.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          DataTable tmp =  registerHandler.searchUser(textBox1.Text);

          listBox1_modify.Items.Clear();

          foreach (DataRow row in tmp.Rows)
          {
              string info = "";
              info+= row[3].ToString();
              info += " ";
              info+= row[4].ToString();

              listBox1_modify.Items.Add(info);
          }
        }

        private void listBox1_modify_SelectedIndexChanged(object sender, EventArgs e)
        {       
            if(listBox1_modify.SelectedIndex >= 0)
            {
                string searched_user = this.listBox1_modify.SelectedItem.ToString();
                string[] searched_user_info = searched_user.Split(' ');

                DataTable user_details = registerHandler.getUserDetails(searched_user_info[0], searched_user_info[1]);

                foreach (DataRow row in user_details.Rows)
                {
                    ID.Text = row[0].ToString();
                    Login_modify.Text = row[1].ToString();
                    Name_modify.Text = row[3].ToString();
                    Surname_modify.Text = row[4].ToString();
                    Department_modify.SelectedIndex = Convert.ToInt16(row[5]) - 1;
                    Role_modify.SelectedIndex = Convert.ToInt16(row[6]);
                }       
            }         
        }

        private void Add_Register_Click(object sender, EventArgs e)
        {         
                int tmp = 0;
                bool canchange = true;

            foreach (Control x in this.Controls)
                {
                    if (string.IsNullOrEmpty(x.Text) || string.IsNullOrWhiteSpace(x.Text))
                    {
                        if (x.Name != Password_modify.Name  && x!=textBox1)
                        {
                            errorProvider1.SetError(x, "To pole nie może zostać puste!");
                            canchange = false;
                        }                                        
                    }
                }

            if(canchange)
            {
                if (Role_modify.SelectedIndex != 0)    // Ustalam czy jest zaznaczone pole admin
                    tmp = 1;
                int tmp2 = Department_modify.SelectedIndex + 1;   //Ustalam ID działu firmy

                if (registerHandler.changeUser(ID.Text.Replace(" ", string.Empty), Login_modify.Text.Replace(" ", string.Empty), Password_modify.Text.Replace(" ", string.Empty), Name_modify.Text.Replace(" ", string.Empty), Surname_modify.Text.Replace(" ", string.Empty), tmp2.ToString().Replace(" ", string.Empty), tmp.ToString().Replace(" ", string.Empty)))
                {
                    Clear_register_Click(this, e);
                    errorProvider1.Clear();
                }   
            }
            else
            {
                MessageBox.Show("Aby zmodyfikować użytkownika wypełnij wszystkie wymagane pola!  Pole Hasło jest opcjonalne");
            }
        }

        private void Clear_register_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }
            }
            listBox1_modify.Items.Clear();
        }

        private void UserModify_Load(object sender, EventArgs e)
        {

        }

        private void Delete_User_Click(object sender, EventArgs e)
        {

            bool candelete = true;

            foreach (Control x in this.Controls)
            {
                if (string.IsNullOrEmpty(x.Text) || string.IsNullOrWhiteSpace(x.Text))
                {
                    if (x.Name != Password_modify.Name)
                    {
                        errorProvider1.SetError(x, "To pole nie może zostać puste!");
                        candelete = false;
                    }
                }
            }
          
            if(candelete)
            {

                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunać: " + Name_modify.Text + " " + Surname_modify.Text+" ?","Kasowanie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (registerHandler.DeleteUser(Name_modify.Text, Surname_modify.Text))
                    {
                        MessageBox.Show("Pracownik został usunięty z bazy!");
                        Clear_register_Click(this, e);
                    }
                    else
                    {
                        MessageBox.Show("Usuwanie nie powiodło się!");
                    }
                }
                     
            }      
        }
    }
}
