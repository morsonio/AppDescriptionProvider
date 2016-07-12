using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleApplication2.HttpManager
{
    public static class AppRequest
    {
        private static string appList = "http://api.steampowered.com/ISteamApps/GetAppList/v2/";
        private static string appDetails = "http://store.steampowered.com/api/appdetails?appids=";

        public static string GetAppList()
        {
            return Request.Get(appList);
        }
        
        public static string GetAppDetails(int appID)
        {
            return Request.Get(appDetails + appID);
        }
    }
    
    public static class Request
    {
        
        public static string Get(string url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    return client.GetStringAsync(new Uri(url)).Result;
                }
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
