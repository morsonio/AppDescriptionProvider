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
using ConsoleApplication2.DAL.Context;
using ConsoleApplication2.DAL.Models;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region zapisDoPliku
            /*
            using (StreamWriter writer = new StreamWriter("WszystkieApki.txt"))
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

            #region dodanie nazw i idkow apek do bazy
            /*
            using (var ctx = new ApplicationContext())
			{
				foreach (var item in AppsObject.appList)
				{
					ctx.Applications.Add(new Application(item.Data.Name, item.Data.SteamAppid));
				}
				ctx.SaveChanges();
			}*/
            #endregion

            #region dodawanie opisów do bazy do każdej apki ze steama
            /*
            using (var ctx = new ApplicationContext())
            {

                foreach (var app in ctx.Applications)
                {
                        string appDetailsInString = AppRequest.GetAppDetails(app.ApplicationSteamAppId);
                        var appDetails = JsonConvert.DeserializeObject<Dictionary<string, AppDetailsContainer>>(appDetailsInString);
                        if (appDetails.FirstOrDefault().Value.Success)
                        {
                            app.ApplicationDescription = appDetails.FirstOrDefault().Value.Data.DetailedDescription;
                            
                        }
                    
                    System.Threading.Thread.Sleep(2000);
                }
                ctx.SaveChanges();
            }
            Console.Write("Done");
            Console.ReadKey();
            */
            #endregion


            #region zapis do pliku txt szczegółowych danych apki ( na podstawie wszystkich appIdeków z dejtbejza ) 
            /*
            using (var ctx = new ApplicationContext())
            using (StreamWriter writer = new StreamWriter(@"C:\dupa\SteamApps2.txt"))
            {
                foreach (var app in ctx.Applications)
                {
                        string appDetailsInString = AppRequest.GetAppDetails(app.ApplicationSteamAppId);
                        writer.WriteLine(appDetailsInString);
                        System.Threading.Thread.Sleep(2000);
                    
                }
            }
            */
            #endregion

            #region pobieranie całego pliku txt i wrzucanie przefiltrowanych danych do kolejnego pliku
            /*
            using (StreamReader reader = new StreamReader(@"C:\dupa\SteamApps.txt"))
            using (StreamWriter writer = new StreamWriter(@"C:\dupa\SteamAppsBeta.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string actualLine=reader.ReadLine();
                    if(JsonConvert.DeserializeObject<Dictionary<string, SuccesJsonModel>>(actualLine).FirstOrDefault().Value.Success)
                    {
                        writer.WriteLine(actualLine);
                    }
                }
            }
            */
            #endregion


        }
    }
}

