namespace WorkTimeManager
{
    partial class CompanyReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mraport = new System.Windows.Forms.RadioButton();
            this.Draport = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Themostactiveworker = new System.Windows.Forms.Label();
            this.workTimeSum = new System.Windows.Forms.Label();
            this.Themostactiveworkertime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TheMostActiveDepartment = new System.Windows.Forms.Label();
            this.TheMostActiveDepartmentTime = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Miesięczny";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Roczny";
            // 
            // Mraport
            // 
            this.Mraport.AutoSize = true;
            this.Mraport.Location = new System.Drawing.Point(71, 25);
            this.Mraport.Name = "Mraport";
            this.Mraport.Size = new System.Drawing.Size(14, 13);
            this.Mraport.TabIndex = 14;
            this.Mraport.TabStop = true;
            this.Mraport.UseVisualStyleBackColor = true;
            // 
            // Draport
            // 
            this.Draport.AutoSize = true;
            this.Draport.Location = new System.Drawing.Point(71, 61);
            this.Draport.Name = "Draport";
            this.Draport.Size = new System.Drawing.Size(14, 13);
            this.Draport.TabIndex = 13;
            this.Draport.TabStop = true;
            this.Draport.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(91, 61);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Generuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(91, 292);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 211);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(635, 192);
            this.dataGridView2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Najaktywniejszy pracownik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Łączny czas pracy:";
            // 
            // Themostactiveworker
            // 
            this.Themostactiveworker.AutoSize = true;
            this.Themostactiveworker.Location = new System.Drawing.Point(452, 31);
            this.Themostactiveworker.Name = "Themostactiveworker";
            this.Themostactiveworker.Size = new System.Drawing.Size(35, 13);
            this.Themostactiveworker.TabIndex = 21;
            this.Themostactiveworker.Text = "label5";
            // 
            // workTimeSum
            // 
            this.workTimeSum.AutoSize = true;
            this.workTimeSum.Location = new System.Drawing.Point(452, 90);
            this.workTimeSum.Name = "workTimeSum";
            this.workTimeSum.Size = new System.Drawing.Size(35, 13);
            this.workTimeSum.TabIndex = 22;
            this.workTimeSum.Text = "label5";
            // 
            // Themostactiveworkertime
            // 
            this.Themostactiveworkertime.AutoSize = true;
            this.Themostactiveworkertime.Location = new System.Drawing.Point(518, 32);
            this.Themostactiveworkertime.Name = "Themostactiveworkertime";
            this.Themostactiveworkertime.Size = new System.Drawing.Size(35, 13);
            this.Themostactiveworkertime.TabIndex = 23;
            this.Themostactiveworkertime.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Najaktywniejszy dział:";
            // 
            // TheMostActiveDepartment
            // 
            this.TheMostActiveDepartment.AutoSize = true;
            this.TheMostActiveDepartment.Location = new System.Drawing.Point(452, 61);
            this.TheMostActiveDepartment.Name = "TheMostActiveDepartment";
            this.TheMostActiveDepartment.Size = new System.Drawing.Size(35, 13);
            this.TheMostActiveDepartment.TabIndex = 25;
            this.TheMostActiveDepartment.Text = "label5";
            // 
            // TheMostActiveDepartmentTime
            // 
            this.TheMostActiveDepartmentTime.AutoSize = true;
            this.TheMostActiveDepartmentTime.Location = new System.Drawing.Point(518, 61);
            this.TheMostActiveDepartmentTime.Name = "TheMostActiveDepartmentTime";
            this.TheMostActiveDepartmentTime.Size = new System.Drawing.Size(35, 13);
            this.TheMostActiveDepartmentTime.TabIndex = 26;
            this.TheMostActiveDepartmentTime.Text = "label6";
            // 
            // CompanyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TheMostActiveDepartmentTime);
            this.Controls.Add(this.TheMostActiveDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Themostactiveworkertime);
            this.Controls.Add(this.workTimeSum);
            this.Controls.Add(this.Themostactiveworker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mraport);
            this.Controls.Add(this.Draport);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "CompanyReport";
            this.Size = new System.Drawing.Size(829, 519);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Mraport;
        private System.Windows.Forms.RadioButton Draport;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Themostactiveworker;
        private System.Windows.Forms.Label workTimeSum;
        private System.Windows.Forms.Label Themostactiveworkertime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TheMostActiveDepartment;
        private System.Windows.Forms.Label TheMostActiveDepartmentTime;
    }
}
