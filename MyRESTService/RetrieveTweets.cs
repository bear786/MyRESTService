using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace MyRESTService
{
    public class RetrieveTweets
    {
        public List<Tweet> ProcessRequest()
        {
            List<Tweet> tweetList = new List<Tweet>();

            // get these from somewhere nice and secure...
            var key = ConfigurationManager.AppSettings["twitterConsumerKey"];
            var secret = ConfigurationManager.AppSettings["twitterConsumerSecret"];
            //var bearerToken = HttpUtility.UrlEncode(key) + ":" + HttpUtility.UrlEncode(secret);
            var bearerToken = key + ":" + secret;
            var b64Bearer = Convert.ToBase64String(Encoding.Default.GetBytes(bearerToken));
            using (var wc = new WebClient())
            {
                var useProxy = ConfigurationManager.AppSettings["UseProxy"];
                if (useProxy == "true")
                {
                    var proxyUser = ConfigurationManager.AppSettings["ProxyUser"];
                    var proxyPassword = ConfigurationManager.AppSettings["ProxyPassword"];

                    wc.Proxy.Credentials = new NetworkCredential(proxyUser, proxyPassword, "capetown");
                }

                wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded;charset=UTF-8");
                wc.Headers.Add("Authorization", "Basic " + b64Bearer);
                var tokenPayload = wc.UploadString("https://api.twitter.com/oauth2/token", "grant_type=client_credentials");
                var rgx = new Regex("\"access_token\"\\s*:\\s*\"([^\"]*)\"");
                // you can store this accessToken and just do the next bit if you want
                var accessToken = rgx.Match(tokenPayload).Groups[1].Value;
                wc.Headers.Clear();
                wc.Headers.Add("Authorization", "Bearer " + accessToken);

                string twitterUrl = string.Format("{0}?screen_name={1}&count={2}",
                    ConfigurationManager.AppSettings["twitterAPI"].ToString(),
                    ConfigurationManager.AppSettings["twitterScreenName"].ToString(),
                    ConfigurationManager.AppSettings["twitterCount"].ToString());
                var tweets = wc.DownloadString(twitterUrl);

                dynamic results = JsonConvert.DeserializeObject<dynamic>(tweets);
                foreach (var item in results)
                {
                    var d = DateTimeOffset.ParseExact((string)item.created_at, "ddd MMM dd HH:mm:ss +0000 yyyy", CultureInfo.InvariantCulture);

                    dynamic user = JsonConvert.DeserializeObject<dynamic>(Convert.ToString(item.user));
                    dynamic entities = JsonConvert.DeserializeObject<dynamic>(Convert.ToString(item.entities));
                    dynamic media = JsonConvert.DeserializeObject<dynamic>(Convert.ToString(entities.urls));
                    string text = Convert.ToString(item.text);
                    var arr = text.Split("|".ToArray(), StringSplitOptions.RemoveEmptyEntries);

                    tweetList.Add(new Tweet
                    {
                        Id = item.id,
                        Name = user.name,
                        ScreenName = user.screen_name,
                        Icon = ((string)user.profile_image_url).Replace("_normal", "_mini"),
                        Text = HTMLParser.ParseURL(arr.Length > 1 ? arr[1] : arr[0]).ParseUsername().ParseHashtag(),
                        CreatedAt = d,
                        RelativeTime = RelativeTime.RelativeDate(d.Ticks)
                    });
                }

                return tweetList;
            }
        }
    }
}