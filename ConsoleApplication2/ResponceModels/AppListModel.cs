using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplication2.ResponceModels
{
    public class AppListModel
    {
        [JsonProperty("applist")]
        public GetAppListResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetAppListResponseData
    {
        /// <summary>
        /// A list of objects containing the title and app ID of each program available in the store.
        /// </summary>
        [JsonProperty("apps")]
        public List<AppModel> Apps { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class AppModel
    {
        /// <summary>
        /// An integer containing the program's ID.
        /// </summary>
        [JsonProperty("appid")]
        public int AppID { get; set; }
        /// <summary>
        /// A string containing the program's publicly facing title.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }

}
