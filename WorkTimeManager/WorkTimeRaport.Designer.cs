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
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(1275, 497);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(135, 45);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Topic
            // 
            this.Topic.Location = new System.Drawing.Point(678, 511);
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
            // WorkTimeRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 1119);
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

    }
}