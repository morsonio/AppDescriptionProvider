using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.ResponceModels
{
    public class SuccesJsonModel
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
