using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INews24RESTService" in both code and config file together.
    [ServiceContract]
    public interface INews24RESTService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetTweets/")]
        List<Tweet> GetTweets();
    }
}
