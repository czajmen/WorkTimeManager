namespace WorkTimeManager
{
    partial class UserModify
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.Clear_register = new System.Windows.Forms.Button();
            this.Add_Register = new System.Windows.Forms.Button();
            this.Role_modify = new System.Windows.Forms.ComboBox();
            this.Department_modify = new System.Windows.Forms.ComboBox();
            this.Surname_modify = new System.Windows.Forms.TextBox();
            this.Name_modify = new System.Windows.Forms.TextBox();
            this.Password_modify = new System.Windows.Forms.TextBox();
            this.Login_modify = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1_modify = new System.Windows.Forms.ListBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Edytuj dane pracownika";
            // 
            // Clear_register
            // 
            this.Clear_register.Location = new System.Drawing.Point(613, 332);
            this.Clear_register.Name = "Clear_register";
            this.Clear_register.Size = new System.Drawing.Size(75, 23);
            this.Clear_register.TabIndex = 28;
            this.Clear_register.Text = "Wyczyść";
            this.Clear_register.UseVisualStyleBackColor = true;
            this.Clear_register.Click += new System.EventHandler(this.Clear_register_Click);
            // 
            // Add_Register
            // 
            this.Add_Register.Location = new System.Drawing.Point(532, 332);
            this.Add_Register.Name = "Add_Register";
            this.Add_Register.Size = new System.Drawing.Size(75, 23);
            this.Add_Register.TabIndex = 27;
            this.Add_Register.Text = "Edytuj";
            this.Add_Register.UseVisualStyleBackColor = true;
            this.Add_Register.Click += new System.EventHandler(this.Add_Register_Click);
            // 
            // Role_modify
            // 
            this.Role_modify.FormattingEnabled = true;
            this.Role_modify.Location = new System.Drawing.Point(455, 275);
            this.Role_modify.Name = "Role_modify";
            this.Role_modify.Size = new System.Drawing.Size(233, 21);
            this.Role_modify.TabIndex = 26;
            // 
            // Department_modify
            // 
            this.Department_modify.FormattingEnabled = true;
            this.Department_modify.Location = new System.Drawing.Point(455, 236);
            this.Department_modify.Name = "Department_modify";
            this.Department_modify.Size = new System.Drawing.Size(233, 21);
            this.Department_modify.TabIndex = 25;
            // 
            // Surname_modify
            // 
            this.Surname_modify.Location = new System.Drawing.Point(476, 197);
            this.Surname_modify.Name = "Surname_modify";
            this.Surname_modify.Size = new System.Drawing.Size(212, 20);
            this.Surname_modify.TabIndex = 24;
            // 
            // Name_modify
            // 
            this.Name_modify.Location = new System.Drawing.Point(476, 152);
            this.Name_modify.Name = "Name_modify";
            this.Name_modify.Size = new System.Drawing.Size(212, 20);
            this.Name_modify.TabIndex = 23;
            // 
            // Password_modify
            // 
            this.Password_modify.Location = new System.Drawing.Point(476, 111);
            this.Password_modify.Name = "Password_modify";
            this.Password_modify.Size = new System.Drawing.Size(212, 20);
            this.Password_modify.TabIndex = 22;
            // 
            // Login_modify
            // 
            this.Login_modify.Location = new System.Drawing.Point(476, 73);
            this.Login_modify.Name = "Login_modify";
            this.Login_modify.ReadOnly = true;
            this.Login_modify.Size = new System.Drawing.Size(212, 20);
            this.Login_modify.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Rola";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Oddział";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Haslo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Login";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Wpisz dane pracownika";
            // 
            // listBox1_modify
            // 
            this.listBox1_modify.FormattingEnabled = true;
            this.listBox1_modify.Location = new System.Drawing.Point(77, 130);
            this.listBox1_modify.Name = "listBox1_modify";
            this.listBox1_modify.Size = new System.Drawing.Size(227, 134);
            this.listBox1_modify.TabIndex = 32;
            this.listBox1_modify.SelectedIndexChanged += new System.EventHandler(this.listBox1_modify_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(263, 306);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 33;
            this.ID.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ID);
            this.Controls.Add(this.listBox1_modify);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Clear_register);
            this.Controls.Add(this.Add_Register);
            this.Controls.Add(this.Role_modify);
            this.Controls.Add(this.Department_modify);
            this.Controls.Add(this.Surname_modify);
            this.Controls.Add(this.Name_modify);
            this.Controls.Add(this.Password_modify);
            this.Controls.Add(this.Login_modify);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserModify";
            this.Size = new System.Drawing.Size(711, 380);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Clear_register;
        private System.Windows.Forms.Button Add_Register;
        private System.Windows.Forms.ComboBox Role_modify;
        private System.Windows.Forms.ComboBox Department_modify;
        private System.Windows.Forms.TextBox Surname_modify;
        private System.Windows.Forms.TextBox Name_modify;
        private System.Windows.Forms.TextBox Password_modify;
        private System.Windows.Forms.TextBox Login_modify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1_modify;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
