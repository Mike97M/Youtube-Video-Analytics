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

        [TestMethod()]
        public void extractVideoIDTest()
        {
            var yt = new YoutubeVideoAnalytics();

            string[] urls =
            {
                "http://youtu.be/XsNHs4EvWs4",
                "http://www.youtube.com/embed/watch?feature=player_embedded&v=XsNHs4EvWs4",
                "http://www.youtube.com/embed/watch?v=XsNHs4EvWs4",
                "http://www.youtube.com/watch?feature=player_embedded&v=XsNHs4EvWs4",
                "http://www.youtube.com/watch?v=XsNHs4EvWs4",
                "http://www.youtube.com/v/XsNHs4EvWs4",
                "www.youtu.be/XsNHs4EvWs4",
                "youtu.be/XsNHs4EvWs4",
                "http://www.youtube.com/watch?v=XsNHs4EvWs4&feature=related",                "http://www.youtube.com/v/XsNHs4EvWs4?fs=1&rel=0",
                "http://www.youtube.com/watch/XsNHs4EvWs4",

            };
            foreach (string url in urls)
            {
                string id = yt.extractVideoID(url);
                Assert.AreEqual("XsNHs4EvWs4", id);
            }


        }
    }
}