using ConsoleApplication2.HttpManager;
using ConsoleApplication2.ResponceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplication2.SteamApiServices
{
    public class SteamAppsService
    {
        private AppListModel appTemp { get; set; }
        private List<AppDetailsDataModel> appList { get; set; }

        public void getTitles()
        {
            this.appTemp = JsonConvert.DeserializeObject<AppListModel>(AppRequest.GetAppList());
        }

        public void FilterFakeApps()
        {
            appList = new List<AppDetailsDataModel>();

            foreach (AppModel app in appTemp.Data.Apps)
            {
                AppDetailsModel appDetails = 
                    JsonConvert.DeserializeObject<Dictionary<string, AppDetailsModel>>(AppRequest.GetAppDetails(app.AppID))
                    .FirstOrDefault().Value;

                if (appDetails.IsExist)
                { 
                    appList.Add(appDetails.Data);
                }
            }
        }
    }
}

