using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ConsoleApplication2.ResponceModels;
using ConsoleApplication2.HttpManager;

namespace ConsoleApplication2.SteamApiServices
{
    public class AppListService
    {    
        public AppListModel model = JsonConvert.DeserializeObject<AppListModel>(new AppListResponce().rm.GetResponce());
    }
}
