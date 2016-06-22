namespace WorkTimeManager
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podsumowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogólnoFirmowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejestracjaNowegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńObecnegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerRaport1 = new WorkTimeManager.WorkerRaport();
            this.userModify1 = new WorkTimeManager.UserModify();
            this.helloScreen1 = new WorkTimeManager.HelloScreen();
            this.userRegister1 = new WorkTimeManager.UserRegister1();
            this.companyReport1 = new WorkTimeManager.CompanyReport();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raportToolStripMenuItem,
            this.pracownicyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // raportToolStripMenuItem
            // 
            this.raportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podsumowanieToolStripMenuItem,
            this.ogólnoFirmowyToolStripMenuItem});
            this.raportToolStripMenuItem.Name = "raportToolStripMenuItem";
            this.raportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.raportToolStripMenuItem.Text = "Raport";
            // 
            // podsumowanieToolStripMenuItem
            // 
            this.podsumowanieToolStripMenuItem.Name = "podsumowanieToolStripMenuItem";
            this.podsumowanieToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.podsumowanieToolStripMenuItem.Text = "Pracowniczy";
            this.podsumowanieToolStripMenuItem.Click += new System.EventHandler(this.podsumowanieToolStripMenuItem_Click);
            // 
            // ogólnoFirmowyToolStripMenuItem
            // 
            this.ogólnoFirmowyToolStripMenuItem.Name = "ogólnoFirmowyToolStripMenuItem";
            this.ogólnoFirmowyToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ogólnoFirmowyToolStripMenuItem.Text = "Ogólno firmowy";
            this.ogólnoFirmowyToolStripMenuItem.Click += new System.EventHandler(this.ogólnoFirmowyToolStripMenuItem_Click);
            // 
            // pracownicyToolStripMenuItem
            // 
            this.pracownicyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rejestracjaNowegoToolStripMenuItem,
            this.usuńObecnegoToolStripMenuItem});
            this.pracownicyToolStripMenuItem.Name = "pracownicyToolStripMenuItem";
            this.pracownicyToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.pracownicyToolStripMenuItem.Text = "Pracownicy";
            // 
            // rejestracjaNowegoToolStripMenuItem
            // 
            this.rejestracjaNowegoToolStripMenuItem.Name = "rejestracjaNowegoToolStripMenuItem";
            this.rejestracjaNowegoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.rejestracjaNowegoToolStripMenuItem.Text = "Rejestracja Nowego";
            this.rejestracjaNowegoToolStripMenuItem.Click += new System.EventHandler(this.rejestracjaNowegoToolStripMenuItem_Click);
            // 
            // usuńObecnegoToolStripMenuItem
            // 
            this.usuńObecnegoToolStripMenuItem.Name = "usuńObecnegoToolStripMenuItem";
            this.usuńObecnegoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.usuńObecnegoToolStripMenuItem.Text = "Modyfikuj";
            this.usuńObecnegoToolStripMenuItem.Click += new System.EventHandler(this.usuńObecnegoToolStripMenuItem_Click);
            // 
            // workerRaport1
            // 
            this.workerRaport1.Location = new System.Drawing.Point(0, 27);
            this.workerRaport1.Name = "workerRaport1";
            this.workerRaport1.Size = new System.Drawing.Size(932, 542);
            this.workerRaport1.TabIndex = 4;
            // 
            // userModify1
            // 
            this.userModify1.Location = new System.Drawing.Point(130, 60);
            this.userModify1.Name = "userModify1";
            this.userModify1.Size = new System.Drawing.Size(711, 380);
            this.userModify1.TabIndex = 3;
            // 
            // helloScreen1
            // 
            this.helloScreen1.Location = new System.Drawing.Point(156, 27);
            this.helloScreen1.Name = "helloScreen1";
            this.helloScreen1.Size = new System.Drawing.Size(644, 456);
            this.helloScreen1.TabIndex = 2;
            // 
            // userRegister1
            // 
            this.userRegister1.Location = new System.Drawing.Point(253, 70);
            this.userRegister1.Name = "userRegister1";
            this.userRegister1.Size = new System.Drawing.Size(393, 370);
            this.userRegister1.TabIndex = 1;
            // 
            // companyReport1
            // 
            this.companyReport1.Location = new System.Drawing.Point(50, 27);
            this.companyReport1.Name = "companyReport1";
            this.companyReport1.Size = new System.Drawing.Size(829, 519);
            this.companyReport1.TabIndex = 5;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 581);
            this.Controls.Add(this.companyReport1);
            this.Controls.Add(this.workerRaport1);
            this.Controls.Add(this.userModify1);
            this.Controls.Add(this.helloScreen1);
            this.Controls.Add(this.userRegister1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "Manager czasu pracy - Administracja , Raporty";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pracownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejestracjaNowegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podsumowanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńObecnegoToolStripMenuItem;
        private UserRegister1 userRegister1;
        private HelloScreen helloScreen1;
        private UserModify userModify1;
        private WorkerRaport workerRaport1;
        private System.Windows.Forms.ToolStripMenuItem ogólnoFirmowyToolStripMenuItem;
        private CompanyReport companyReport1;

    }
}