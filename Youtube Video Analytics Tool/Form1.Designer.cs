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
            this.textBoxVideoLink = new System.Windows.Forms.TextBox();
            this.buttonCheckVideo = new System.Windows.Forms.Button();
            this.dataGridViewYTStats = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyViews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalViews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyWatchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWatchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailySubs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSubs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYTStats)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxVideoLink
            // 
            this.textBoxVideoLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVideoLink.Location = new System.Drawing.Point(192, 13);
            this.textBoxVideoLink.Name = "textBoxVideoLink";
            this.textBoxVideoLink.Size = new System.Drawing.Size(810, 22);
            this.textBoxVideoLink.TabIndex = 0;
            // 
            // buttonCheckVideo
            // 
            this.buttonCheckVideo.Location = new System.Drawing.Point(12, 12);
            this.buttonCheckVideo.Name = "buttonCheckVideo";
            this.buttonCheckVideo.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckVideo.TabIndex = 1;
            this.buttonCheckVideo.Text = "Check";
            this.buttonCheckVideo.UseVisualStyleBackColor = true;
            this.buttonCheckVideo.Click += new System.EventHandler(this.buttonCheckVideo_Click);
            // 
            // dataGridViewYTStats
            // 
            this.dataGridViewYTStats.AllowUserToAddRows = false;
            this.dataGridViewYTStats.AllowUserToDeleteRows = false;
            this.dataGridViewYTStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewYTStats.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewYTStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYTStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.DailyViews,
            this.TotalViews,
            this.DailyWatchTime,
            this.TotalWatchTime,
            this.DailySubs,
            this.TotalSubs,
            this.DailyShares,
            this.TotalShares});
            this.dataGridViewYTStats.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewYTStats.Name = "dataGridViewYTStats";
            this.dataGridViewYTStats.ReadOnly = true;
            this.dataGridViewYTStats.RowHeadersVisible = false;
            this.dataGridViewYTStats.RowTemplate.Height = 24;
            this.dataGridViewYTStats.Size = new System.Drawing.Size(990, 397);
            this.dataGridViewYTStats.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "YT video link:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewYTStats);
            this.Controls.Add(this.buttonCheckVideo);
            this.Controls.Add(this.textBoxVideoLink);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYTStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVideoLink;
        private System.Windows.Forms.Button buttonCheckVideo;
        private System.Windows.Forms.DataGridView dataGridViewYTStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyViews;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalViews;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyWatchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWatchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailySubs;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSubs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyShares;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalShares;
        private System.Windows.Forms.Label label1;
    }
}

