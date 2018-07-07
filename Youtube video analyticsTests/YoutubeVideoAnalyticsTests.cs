using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;

namespace Youtube_video_analytics.Tests
{
    [TestClass()]
    public class YoutubeVideoAnalyticsTests
    {
        [TestMethod()]
        public void YoutubeVideoAnalyticsTest()
        {
            var yt = new YoutubeVideoAnalytics();
            string response = yt.GetVideoAnalytics("kSoO2KjVVG4");
            Console.WriteLine(response);
            var youtubeAnalytics = JsonConvert.DeserializeObject<YoutubeData>(response); ;
            for (int i = 0; i < youtubeAnalytics.Day.Data.Count; i++)
            {
                Console.WriteLine("Daily:" + youtubeAnalytics.Subscribers.Daily.Data[i]);
                Console.WriteLine("Cumulative:" + youtubeAnalytics.Subscribers.Cumulative.Data[i]);
            }
            Assert.Fail();
        }
    }
}