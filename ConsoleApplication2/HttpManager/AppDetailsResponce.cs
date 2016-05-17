using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.HttpManager
{
    public class AppDetailsResponce
    {
        private readonly string url = "http://store.steampowered.com/api/appdetails?appids=";

        public ResponceManager rm { get; set; }

        public AppDetailsResponce(int appId)
        {
            this.rm = new ResponceManager(url+appId.ToString());
        }
    }
}
