using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyRESTService
{
    [DataContract]
    public class Tweet
    {
        [DataMember]
        public Int64 Id { get; set; }

        [DataMember]
        public string Icon { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string ScreenName { get; set; }

        [DataMember]
        public DateTimeOffset CreatedAt { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public string RelativeTime { get; set; }
    }

    public partial class Tweets
    {
        private static readonly Tweets _instance = new Tweets();

        public Tweets()
        {

        }

        public static Tweets Instance
        {
            get { return _instance; }
        }

        public List<Tweet> TweetList
        {
            get {
                RetrieveTweets retrieveTweets = new RetrieveTweets();
                return retrieveTweets.ProcessRequest();
            }
        }
    }
}