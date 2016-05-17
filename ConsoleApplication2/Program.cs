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

namespace ConsoleApplication2
{
    class Program
    {
        

        static void Main(string[] args)
        {

           

          

            // Pobieram listę apek
            AppListService test = new AppListService();


            //Pobieram apke dla konkretnego id... 
            AppDetailsService test2 = new AppDetailsService(1630);

            //Console.WriteLine(test.model.Data.Apps);
            Console.WriteLine(test2.model.Where(x =>x.Key=="1630").FirstOrDefault().Value.Data.AppAbout);
            //Najlepiej wszystko co jest pobierane widać w debuggerze.
            Console.ReadKey();
        }
    }

    
}

