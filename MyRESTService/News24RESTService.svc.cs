using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "News24RESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select News24RESTService.svc or ProductRESTService.svc.cs at the Solution Explorer and start debugging.
    public class News24RESTService : INews24RESTService
    {
        public List<Tweet> GetTweets()
        {
            return Tweets.Instance.TweetList;
        }
    }
}
