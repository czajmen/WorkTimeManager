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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(1441, 825);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(221, 115);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Send";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Topic
            // 
            this.Topic.Location = new System.Drawing.Point(872, 330);
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
            this.label1.Location = new System.Drawing.Point(1088, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Topic";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxMinutes
            // 
            this.TextBoxMinutes.Location = new System.Drawing.Point(1498, 330);
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
            this.LabelMinutes.Location = new System.Drawing.Point(1498, 285);
            this.LabelMinutes.Name = "LabelMinutes";
            this.LabelMinutes.Size = new System.Drawing.Size(97, 29);
            this.LabelMinutes.TabIndex = 5;
            this.LabelMinutes.Text = "Minules";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 825);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 115);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(597, 328);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 33);
            this.comboBox1.TabIndex = 7;
            // 
            // WorkTimeRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 1119);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}