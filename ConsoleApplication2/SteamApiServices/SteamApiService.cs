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
        public AppListModel appTemp { get; set; }
        public List<AppDetailsContainer> appList;

        public void getTitles()
        {
            this.appTemp = JsonConvert.DeserializeObject<AppListModel>(AppRequest.GetAppList());
        }

        public void mapList()
        {
            appList = new List<AppDetailsContainer>();

            foreach (AppModel application in appTemp.Data.Apps)
            {
                appList.Add(new AppDetailsContainer()
                {
                    Data = new Data()
                    {
                        Name = application.Name,
                        SteamAppid = application.AppID,
                    }
                });
            }
        }

        
       /* public void FilterFakeApps()
        {
            

            foreach (AppModel app in appTemp.Data.Apps)
            {
                AppDetailsContainer appDetails = JsonConvert.DeserializeObject<AppDetailsContainer>(AppRequest.GetAppDetails(app.AppID));
                   /* JsonConvert.DeserializeObject<Dictionary<string, AppDetailsModel>>(AppRequest.GetAppDetails(app.AppID))
                    .FirstOrDefault().Value;*/

                /*if (appDetails.IsExist)
                { 
                    appList.Add(appDetails.Data);
                }

            
            }
        }*/
    }
}

