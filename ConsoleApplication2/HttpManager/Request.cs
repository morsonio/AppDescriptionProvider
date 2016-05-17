using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.HttpManager
{
    /*public abstract class Request
    {
        protected internal abstract string EndpointUrl { get; }

        public Uri GetUri()
        {
            if(string.IsNullOrEmpty(this.EndpointUrl))
            {
                throw new ArgumentNullException("Z pustego i Samolon nie naleje!");
            }

            return new Uri(this.EndpointUrl);
           
        }
    }
    */
    /*public static class EndpointBuilder
    {
        public string Build(bool isSecure,ApiNameEnum adres,string method)
        {
            string endpoint="http://";
            if (isSecure)
            {
                endpoint = "https://";
            }
            endpoint += adres + method;

            return endpoint;
        }
    }*/
    /*enum ApiNameEnum
    {
        SteamAPI ="api.steampowered.com/",
        SteamSiteAPI = "store.steampowered.com/"
    }*/
}
