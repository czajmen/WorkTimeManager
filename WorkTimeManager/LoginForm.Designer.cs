namespace WorkTimeManager
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_Login = new System.Windows.Forms.TextBox();
            this.Login_Label = new System.Windows.Forms.Label();
            this.Hasło_Label = new System.Windows.Forms.Label();
            this.Login_Title = new System.Windows.Forms.Label();
            this.Login_Password = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_Login
            // 
            this.Login_Login.Location = new System.Drawing.Point(125, 69);
            this.Login_Login.Name = "Login_Login";
            this.Login_Login.Size = new System.Drawing.Size(178, 20);
            this.Login_Login.TabIndex = 0;
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Login_Label.Location = new System.Drawing.Point(58, 72);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(47, 17);
            this.Login_Label.TabIndex = 2;
            this.Login_Label.Text = "Login:";
            // 
            // Hasło_Label
            // 
            this.Hasło_Label.AutoSize = true;
            this.Hasło_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Hasło_Label.Location = new System.Drawing.Point(58, 114);
            this.Hasło_Label.Name = "Hasło_Label";
            this.Hasło_Label.Size = new System.Drawing.Size(48, 17);
            this.Hasło_Label.TabIndex = 3;
            this.Hasło_Label.Text = "Hasło:";
            // 
            // Login_Title
            // 
            this.Login_Title.AutoSize = true;
            this.Login_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Login_Title.Location = new System.Drawing.Point(21, 27);
            this.Login_Title.Name = "Login_Title";
            this.Login_Title.Size = new System.Drawing.Size(342, 17);
            this.Login_Title.TabIndex = 4;
            this.Login_Title.Text = "Zaloguj się do swojego konta menagera czasu pracy!";
            // 
            // Login_Password
            // 
            this.Login_Password.Location = new System.Drawing.Point(125, 114);
            this.Login_Password.Name = "Login_Password";
            this.Login_Password.Size = new System.Drawing.Size(178, 20);
            this.Login_Password.TabIndex = 5;
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(228, 166);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Login_Button.TabIndex = 6;
            this.Login_Button.Text = "Zaloguj!";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 283);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Login_Password);
            this.Controls.Add(this.Login_Title);
            this.Controls.Add(this.Hasło_Label);
            this.Controls.Add(this.Login_Label);
            this.Controls.Add(this.Login_Login);
            this.Name = "LoginForm";
            this.Text = "Manager czasu pracy - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_Login;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Label Hasło_Label;
        private System.Windows.Forms.Label Login_Title;
        private System.Windows.Forms.TextBox Login_Password;
        private System.Windows.Forms.Button Login_Button;
    }
}

