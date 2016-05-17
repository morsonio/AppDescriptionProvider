using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.HttpManager
{
    public class ResponceManager
    {
        private Uri uri;
        
        private RequestManager requestManager;

        public ResponceManager(string url)
        {
            this.uri = new Uri(url);
            MielTomKurwe();
        }

        private void MielTomKurwe()
        {
            requestManager = new RequestManager(this.uri);
        }

        public string GetResponce()
        {
            return this.requestManager.responce;
        }
    }
}
