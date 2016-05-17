using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.HttpManager
{
    public class AppListResponce
    {
        private readonly string url = "http://api.steampowered.com/ISteamApps/GetAppList/v2/";

        public ResponceManager rm { get; set; }
        public AppListResponce()
        {
            this.rm = new ResponceManager(url);
        }
    }
}
