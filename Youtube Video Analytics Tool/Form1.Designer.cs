namespace Youtube_Video_Analytics_Tool
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyViews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalViews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyWatchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWatchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailySubs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSubs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(695, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.DailyViews,
            this.TotalViews,
            this.DailyWatchTime,
            this.TotalWatchTime,
            this.DailySubs,
            this.TotalSubs,
            this.DailyShares,
            this.TotalShares});
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(990, 397);
            this.dataGridView1.TabIndex = 2;
            // 
            // Day
            // 
            this.Day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // DailyViews
            // 
            this.DailyViews.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DailyViews.HeaderText = "Daily Views";
            this.DailyViews.Name = "DailyViews";
            this.DailyViews.ReadOnly = true;
            // 
            // TotalViews
            // 
            this.TotalViews.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalViews.HeaderText = "Total Views";
            this.TotalViews.Name = "TotalViews";
            this.TotalViews.ReadOnly = true;
            // 
            // DailyWatchTime
            // 
            this.DailyWatchTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DailyWatchTime.HeaderText = "Daily WatchTime";
            this.DailyWatchTime.Name = "DailyWatchTime";
            this.DailyWatchTime.ReadOnly = true;
            // 
            // TotalWatchTime
            // 
            this.TotalWatchTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalWatchTime.HeaderText = "Total WatchTime";
            this.TotalWatchTime.Name = "TotalWatchTime";
            this.TotalWatchTime.ReadOnly = true;
            // 
            // DailySubs
            // 
            this.DailySubs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DailySubs.HeaderText = "Daily subs";
            this.DailySubs.Name = "DailySubs";
            this.DailySubs.ReadOnly = true;
            // 
            // TotalSubs
            // 
            this.TotalSubs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalSubs.HeaderText = "Total Subs";
            this.TotalSubs.Name = "TotalSubs";
            this.TotalSubs.ReadOnly = true;
            // 
            // DailyShares
            // 
            this.DailyShares.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DailyShares.HeaderText = "Daily Shares";
            this.DailyShares.Name = "DailyShares";
            this.DailyShares.ReadOnly = true;
            // 
            // TotalShares
            // 
            this.TotalShares.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalShares.HeaderText = "Total Shares";
            this.TotalShares.Name = "TotalShares";
            this.TotalShares.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyViews;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalViews;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyWatchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWatchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailySubs;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSubs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyShares;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalShares;
    }
}

