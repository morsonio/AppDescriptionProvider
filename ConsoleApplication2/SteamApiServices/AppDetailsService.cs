using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.ResponceModels;
using ConsoleApplication2.HttpManager;
using Newtonsoft.Json;

namespace ConsoleApplication2.SteamApiServices
{
    public class AppDetailsService
    {
        public Dictionary<string, AppDetailsModel> model;
        public AppDetailsService(int appId)
        {
            model = JsonConvert.DeserializeObject<Dictionary<string, AppDetailsModel>>(new AppDetailsResponce(appId).rm.GetResponce());
        }
    }
}
