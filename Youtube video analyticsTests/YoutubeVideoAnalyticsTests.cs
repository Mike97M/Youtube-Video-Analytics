using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Console.WriteLine(yt.GetVideoAnalytics("kSoO2KjVVG4"));
            Assert.Fail();
        }
    }
}