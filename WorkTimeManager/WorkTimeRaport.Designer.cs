namespace WorkTimeManager
{
    partial class WorkTimeRaport
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
            this.Insert = new System.Windows.Forms.Button();
            this.Topic = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxMinutes = new System.Windows.Forms.TextBox();
            this.LabelMinutes = new System.Windows.Forms.Label();
            this.Departments_Box = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(1169, 418);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(221, 115);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Wyślij";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Topic
            // 
            this.Topic.Location = new System.Drawing.Point(572, 316);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(550, 31);
            this.Topic.TabIndex = 1;
            this.Topic.TextChanged += new System.EventHandler(this.Topic_TextChanged);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(34, 46);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(576, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxMinutes
            // 
            this.TextBoxMinutes.Location = new System.Drawing.Point(1169, 316);
            this.TextBoxMinutes.Name = "TextBoxMinutes";
            this.TextBoxMinutes.Size = new System.Drawing.Size(100, 31);
            this.TextBoxMinutes.TabIndex = 4;
            this.TextBoxMinutes.TextChanged += new System.EventHandler(this.TextBoxMinutes_TextChanged);
            this.TextBoxMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMinutes_KeyPress);
            // 
            // LabelMinutes
            // 
            this.LabelMinutes.AutoSize = true;
            this.LabelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelMinutes.Location = new System.Drawing.Point(1172, 265);
            this.LabelMinutes.Name = "LabelMinutes";
            this.LabelMinutes.Size = new System.Drawing.Size(82, 29);
            this.LabelMinutes.TabIndex = 5;
            this.LabelMinutes.Text = "Minuty";
            // 
            // Departments_Box
            // 
            this.Departments_Box.FormattingEnabled = true;
            this.Departments_Box.Location = new System.Drawing.Point(572, 112);
            this.Departments_Box.Name = "Departments_Box";
            this.Departments_Box.Size = new System.Drawing.Size(219, 33);
            this.Departments_Box.TabIndex = 7;
            this.Departments_Box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1132, 384);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dział";
            // 
            // WorkTimeRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 863);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Departments_Box);
            this.Controls.Add(this.LabelMinutes);
            this.Controls.Add(this.TextBoxMinutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.Topic);
            this.Controls.Add(this.Insert);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WorkTimeRaport";
            this.Text = "WorkTimeRaport";
            this.Load += new System.EventHandler(this.WorkTimeRaport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox Topic;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxMinutes;
        private System.Windows.Forms.Label LabelMinutes;
        private System.Windows.Forms.ComboBox Departments_Box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;

    }
}