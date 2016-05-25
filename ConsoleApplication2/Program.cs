using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Net.Http;
using ConsoleApplication2.HttpManager;
using ConsoleApplication2.ResponceModels;
using ConsoleApplication2.SteamApiServices;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ConsoleApplication2.Menu;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region zapisDoPliku
            /*using (StreamWriter writer = new StreamWriter("WszystkieApki.txt"))
            {
                foreach (var app in test.model.Data.Apps)
                {
                    if (app.AppID <= 1000)
                    {
                        writer.WriteLine(new AppDetailsResponce(app.AppID).rm.GetResponce());
                    }

                }
            }

         
            
            using (StreamReader reader = new StreamReader("WszystkieApki.txt"))
            {
                
                while (!reader.EndOfStream)
                {
                     model.Add(JsonConvert.DeserializeObject<Dictionary<string, AppDetailsModel>>(reader.ReadLine()));
                }

                
            }


            foreach (var element in model)
            {
                foreach (var item in element)
                {
                    if (item.Value.Data!=null)
                    {
                        Console.WriteLine(item.Value.Data.AppName); 
                    }
                    
                }
            }


          
            */

            #endregion

            /*SteamAppsService dupa = new SteamAppsService();

            dupa.getTitles();
            dupa.FilterFakeApps();

            Console.ReadKey();*/

            new MenuService();
        }
    }
}

