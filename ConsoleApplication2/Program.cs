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

namespace ConsoleApplication2
{
    class Program
    {


        static void Main(string[] args)
        {


            // Pobieram listę apek
            AppListService test = new AppListService();

            /*using (StreamWriter writer = new StreamWriter("WszystkieApki.txt"))
            {
                foreach (var app in test.model.Data.Apps)
                {
                    if (app.AppID <= 1000)
                    {
                        writer.WriteLine(new AppDetailsResponce(app.AppID).rm.GetResponce());
                    }

                }
            }*/

            //TODO Dokończyć próbę zczytywania z listy JSONÓW
            using (StreamReader reader = new StreamReader("WszystkieApki.txt"))
            {
                List<Dictionary<string, AppDetailsModel>> model = new List<Dictionary<string,AppDetailsModel>>();
                while (!reader.EndOfStream)
                {
                     model.Add(JsonConvert.DeserializeObject<Dictionary<string, AppDetailsModel>>(reader.ReadLine()));
                }

                foreach (var item in model)
                {
                    Console.WriteLine(model.Select(x=> x.Values.Select(y => y.Data.AppName)).ToString());
                }
            }

            



            //Pobieram apke dla konkretnego id... 
            //AppDetailsService test2 = new AppDetailsService(1630);


            // Console.WriteLine(test2.model.Where(x =>x.Key=="1630").FirstOrDefault().Value.Data.AppAbout);
            //Najlepiej wszystko co jest pobierane widać w debuggerze.
            Console.ReadKey();
        }
    }


}

