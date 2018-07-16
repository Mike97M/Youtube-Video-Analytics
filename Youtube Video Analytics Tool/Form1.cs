using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using Youtube_video_analytics;
namespace Youtube_Video_Analytics_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheckVideo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxVideoLink.Text))
                MessageBox.Show("Please enter a video url");

            dataGridViewYTStats.Rows.Clear();
            var yt = new YoutubeVideoAnalytics();
            string response = yt.GetVideoAnalytics(textBoxVideoLink.Text);

            var youtubeAnalytics = JsonConvert.DeserializeObject<YoutubeData>(response); ;
            for (int i = 0; i < youtubeAnalytics.Day.Data.Count; i++)
            {
                var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddMilliseconds(youtubeAnalytics.Day.Data[i]);
                dataGridViewYTStats.Rows.Add(
                    dateTime.ToString("MM/dd/yyyy"),
                    youtubeAnalytics.Views.Daily.Data[i],
                    youtubeAnalytics.Views.Cumulative.Data[i],
                    youtubeAnalytics.WatchTime.Daily.Data[i],
                    youtubeAnalytics.WatchTime.Cumulative.Data[i],
                    youtubeAnalytics.Subscribers.Daily.Data[i],
                    youtubeAnalytics.Subscribers.Cumulative.Data[i],
                    youtubeAnalytics.Shares.Daily.Data[i],
                    youtubeAnalytics.Shares.Cumulative.Data[i]
                    );
            }
        }
    }
}
