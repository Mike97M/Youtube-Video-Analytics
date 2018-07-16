using RestSharp;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Youtube_video_analytics
{
    public class YoutubeVideoAnalytics
    {
        private RestClient _client;
        private RestRequest _request;
        private IRestResponse _response;
        public YoutubeVideoAnalytics()
        {
            _client = new RestClient("https://www.youtube.com/")
            {
                CookieContainer = new System.Net.CookieContainer()
            };
        }
        public string GetVideoAnalytics(string link)
        {
            string videoId = extractVideoID(link);
            _request = new RestRequest($"watch?v={videoId}", Method.GET);
            _response = _client.Execute(_request);

            if (!IsVideoStatsAvailable(_response.Content))
                throw new Exception("Video stats not available to public");

            _request = new RestRequest($"insight_ajax?action_get_statistics_and_data=1&v={videoId}", Method.POST);

            string token = ExtractToken(_response.Content);
            _request.AddParameter("session_token", token);

            _response = _client.Execute(_request); ;
            return ExtractStatistics(_response.Content);
        }

        public string extractVideoID(string link)
        {
            var uri = new UriBuilder(link).Uri;

            var query = HttpUtility.ParseQueryString(uri.Query);

            if (query.AllKeys.Contains("v"))
            {
                return query["v"];
            }
            else
            {
                return uri.Segments.Last();
            }

        }

        private string ExtractToken(string respons)
        {
            string pattern = @"\'XSRF_TOKEN\'\s*\n*:\s*\n*""(.*)""";

            var match = Regex.Match(respons, pattern, RegexOptions.Multiline);

            if (!match.Success)
                throw new Exception("Token can't be extreacted");

            string token = match.Value;
            token = token.Replace("\'XSRF_TOKEN\': \"", "").Replace("\"", "");
            return token;
        }

        private string ExtractStatistics(string response)
        {
            string pattern = @"<graph_data><!\[CDATA(.*)]><\/graph_data>";
            var match = Regex.Match(response, pattern);

            if (!match.Success)
            {
                Console.WriteLine(response);
                throw new Exception("Error while extracting data");
            }

            string statistics = match.Value;
            statistics = statistics.Replace("<graph_data><![CDATA[", "");
            statistics = statistics.Replace("]]></graph_data>", "");
            return statistics;
        }
        private bool IsVideoStatsAvailable(string response)
        {
            return response.Contains("action-panel-trigger-stats");
        }
    }
}
