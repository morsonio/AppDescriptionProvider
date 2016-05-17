using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace test
{
    class Program
    {

        public static HttpResponseMessage Request(string url)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage responce = client.GetAsync(new Uri(url)).Result;
                return responce;
            }
        }
        static void Main(string[] args)
        {


            Console.WriteLine(Request("https://www.origin.com/pl-pl/store/browse/pc-download"));
            Console.ReadKey();

        }



    }
}
