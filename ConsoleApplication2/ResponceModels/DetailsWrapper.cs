using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;

namespace ConsoleApplication2.ResponceModels
{
 
    
    public class AppDetailsModel
    {

        [JsonProperty("success")]
        public bool HasFound { get; set; }

        [JsonProperty("data")]
        public AppDetailsDataModel Data { get; set; }
  
    }

    [Serializable]
    public class AppDetailsDataModel
    {

        [JsonProperty("type")]
        public string AppType { get; set; }

        [JsonProperty("name")]
        public object AppName {get;set;}

        [JsonProperty("steam_appid")]
        public object AppID {get;set;}

        [JsonProperty("required_age")]
        public object AppReqAge {get;set;}

        [JsonProperty("is_free")]
        public object AppIsFree {get;set;}

        [JsonProperty("detailed_description")]
        public object AppDescript {get;set;}

        [JsonProperty("about_the_game")]
        public object AppAbout {get;set;}

        [JsonProperty("supported_languages")]
        public object AppLangs {get;set;}

        [JsonProperty("header_image")]
        public object AppHeaderImg {get;set;}

        [JsonProperty("website")]
        public object AppWebsite {get;set;}

        [JsonProperty("pc_requirements")]
        public object AppRequ { get; set; }

        [JsonProperty("platforms")]
        public object AppPlatforms { get; set; }

        [JsonProperty("genres")]
        public object AppGeneres { get; set; }

    }
   
}
