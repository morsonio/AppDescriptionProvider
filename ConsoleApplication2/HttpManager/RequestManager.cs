using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleApplication2.HttpManager
{
    public class RequestManager
    {
        public string responce { get; set; }

        public RequestManager(Uri uri)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    this.responce = client.GetStringAsync(uri).Result;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
