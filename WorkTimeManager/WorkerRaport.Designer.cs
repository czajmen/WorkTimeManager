namespace WorkTimeManager
{
    partial class WorkerRaport
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searchuser_workerraport = new System.Windows.Forms.TextBox();
            this.Wyszukaj = new System.Windows.Forms.Label();
            this.SearchedUsers = new System.Windows.Forms.ListBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Draport = new System.Windows.Forms.RadioButton();
            this.Mraport = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dayWorkerRaportResult1 = new WorkTimeManager.DayWorkerRaportResult();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 598);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 31);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // searchuser_workerraport
            // 
            this.searchuser_workerraport.Location = new System.Drawing.Point(160, 65);
            this.searchuser_workerraport.Margin = new System.Windows.Forms.Padding(6);
            this.searchuser_workerraport.Name = "searchuser_workerraport";
            this.searchuser_workerraport.Size = new System.Drawing.Size(336, 31);
            this.searchuser_workerraport.TabIndex = 1;
            this.searchuser_workerraport.TextChanged += new System.EventHandler(this.searchuser_workerraport_TextChanged);
            // 
            // Wyszukaj
            // 
            this.Wyszukaj.AutoSize = true;
            this.Wyszukaj.Location = new System.Drawing.Point(42, 71);
            this.Wyszukaj.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Wyszukaj.Name = "Wyszukaj";
            this.Wyszukaj.Size = new System.Drawing.Size(105, 25);
            this.Wyszukaj.TabIndex = 2;
            this.Wyszukaj.Text = "Wyszukaj";
            // 
            // SearchedUsers
            // 
            this.SearchedUsers.FormattingEnabled = true;
            this.SearchedUsers.ItemHeight = 25;
            this.SearchedUsers.Location = new System.Drawing.Point(160, 115);
            this.SearchedUsers.Margin = new System.Windows.Forms.Padding(6);
            this.SearchedUsers.Name = "SearchedUsers";
            this.SearchedUsers.Size = new System.Drawing.Size(336, 429);
            this.SearchedUsers.TabIndex = 3;
            this.SearchedUsers.SelectedIndexChanged += new System.EventHandler(this.SearchedUsers_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(208, 667);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker2.Size = new System.Drawing.Size(288, 31);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // Draport
            // 
            this.Draport.AutoSize = true;
            this.Draport.Location = new System.Drawing.Point(168, 667);
            this.Draport.Margin = new System.Windows.Forms.Padding(6);
            this.Draport.Name = "Draport";
            this.Draport.Size = new System.Drawing.Size(27, 26);
            this.Draport.TabIndex = 7;
            this.Draport.TabStop = true;
            this.Draport.UseVisualStyleBackColor = true;
            // 
            // Mraport
            // 
            this.Mraport.AutoSize = true;
            this.Mraport.Location = new System.Drawing.Point(168, 598);
            this.Mraport.Margin = new System.Windows.Forms.Padding(6);
            this.Mraport.Name = "Mraport";
            this.Mraport.Size = new System.Drawing.Size(27, 26);
            this.Mraport.TabIndex = 8;
            this.Mraport.TabStop = true;
            this.Mraport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 612);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Miesięczny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 681);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dzienny";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 762);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Generuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dayWorkerRaportResult1
            // 
            this.dayWorkerRaportResult1.Location = new System.Drawing.Point(554, 31);
            this.dayWorkerRaportResult1.Margin = new System.Windows.Forms.Padding(12);
            this.dayWorkerRaportResult1.Name = "dayWorkerRaportResult1";
            this.dayWorkerRaportResult1.Size = new System.Drawing.Size(1326, 888);
            this.dayWorkerRaportResult1.TabIndex = 12;
            this.dayWorkerRaportResult1.Load += new System.EventHandler(this.dayWorkerRaportResult1_Load);
            // 
            // WorkerRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dayWorkerRaportResult1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mraport);
            this.Controls.Add(this.Draport);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.SearchedUsers);
            this.Controls.Add(this.Wyszukaj);
            this.Controls.Add(this.searchuser_workerraport);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WorkerRaport";
            this.Size = new System.Drawing.Size(1950, 1035);
            this.Load += new System.EventHandler(this.WorkerRaport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox searchuser_workerraport;
        private System.Windows.Forms.Label Wyszukaj;
        private System.Windows.Forms.ListBox SearchedUsers;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton Draport;
        private System.Windows.Forms.RadioButton Mraport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private DayWorkerRaportResult dayWorkerRaportResult1;
    }
}
