

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Youtube_video_analytics
{
    public class Day
    {

        [JsonProperty("data")]
        public IList<double> Data { get; set; }
    }





    public class Shares
    {

        [JsonProperty("daily")]
        public Daily Daily { get; set; }

        [JsonProperty("cumulative")]
        public Cumulative Cumulative { get; set; }
    }

    public class Views
    {

        [JsonProperty("daily")]
        public Daily Daily { get; set; }

        [JsonProperty("cumulative")]
        public Cumulative Cumulative { get; set; }
    }

    public class Subscribers
    {

        [JsonProperty("daily")]
        public Daily Daily { get; set; }

        [JsonProperty("cumulative")]
        public Cumulative Cumulative { get; set; }
    }

    public class WatchTime
    {

        [JsonProperty("daily")]
        public Daily Daily { get; set; }

        [JsonProperty("cumulative")]
        public Cumulative Cumulative { get; set; }
    }


    public class Daily
    {

        [JsonProperty("data")]
        public IList<double> Data { get; set; }

    }

    public class Cumulative
    {

        [JsonProperty("data")]
        public IList<double> Data { get; set; }


    }


    public class YoutubeData
    {

        [JsonProperty("day")]
        public Day Day { get; set; }

        [JsonProperty("shares")]
        public Shares Shares { get; set; }

        [JsonProperty("views")]
        public Views Views { get; set; }

        [JsonProperty("subscribers")]
        public Subscribers Subscribers { get; set; }

        [JsonProperty("watch-time")]
        public WatchTime WatchTime { get; set; }
    }


}
