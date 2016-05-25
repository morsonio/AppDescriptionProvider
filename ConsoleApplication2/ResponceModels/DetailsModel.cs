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

    #region ja
   /* public class AppDetailsModel
    {

        [JsonProperty("success")]
        public bool IsExist { get; set; }

        [JsonProperty("data")]
        public AppDetailsDataModel Data { get; set; }
  
    }

    [Serializable]
    public class AppDetailsDataModel
    {

        [JsonProperty("type")]
        public string AppType { get; set; }

        [JsonProperty("name")]
        public string AppName {get;set;}

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

    }*/
    #endregion


    public class PcRequirements
    {
        [JsonProperty("minimum")]
        public string Minimum { get; set; }
    }

    public class MacRequirements
    {
        [JsonProperty("minimum")]
        public string Minimum { get; set; }
    }

    public class LinuxRequirements
    {
        [JsonProperty("minimum")]
        public string Minimum { get; set; }
    }

    public class Sub
    {
        [JsonProperty("packageid")]
        public string Packageid { get; set; }

        [JsonProperty("percent_savings_text")]
        public string PercentSavingsText { get; set; }

        [JsonProperty("percent_savings")]
        public int PercentSavings { get; set; }

        [JsonProperty("option_text")]
        public string OptionText { get; set; }

        [JsonProperty("option_description")]
        public string OptionDescription { get; set; }

        [JsonProperty("can_get_free_license")]
        public string CanGetFreeLicense { get; set; }

        [JsonProperty("is_free_license")]
        public bool IsFreeLicense { get; set; }

        [JsonProperty("price_in_cents_with_discount")]
        public int PriceInCentsWithDiscount { get; set; }
    }

    public class PackageGroup
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("selection_text")]
        public string SelectionText { get; set; }

        [JsonProperty("save_text")]
        public string SaveText { get; set; }

        [JsonProperty("display_type")]
        public int DisplayType { get; set; }

        [JsonProperty("is_recurring_subscription")]
        public string IsRecurringSubscription { get; set; }

        [JsonProperty("subs")]
        public Sub[] Subs { get; set; }
    }

    public class Platforms
    {
        [JsonProperty("windows")]
        public bool Windows { get; set; }

        [JsonProperty("mac")]
        public bool Mac { get; set; }

        [JsonProperty("linux")]
        public bool Linux { get; set; }
    }

    public class Metacritic
    {
        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Category
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Genre
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Screenshot
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("path_thumbnail")]
        public string PathThumbnail { get; set; }

        [JsonProperty("path_full")]
        public string PathFull { get; set; }
    }

    public class Webm
    {
        [JsonProperty("480")]
        public string Resolution480 { get; set; }

        [JsonProperty("max")]
        public string Max { get; set; }
    }

    public class Movie
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("webm")]
        public Webm Webm { get; set; }

        [JsonProperty("highlight")]
        public bool Highlight { get; set; }
    }

    public class Recommendations
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class ReleaseDate
    {
        [JsonProperty("coming_soon")]
        public bool ComingSoon { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class SupportInfo
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class Data
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("steam_appid")]
        public int SteamAppid { get; set; }

        [JsonProperty("required_age")]
        public int RequiredAge { get; set; }

        [JsonProperty("is_free")]
        public bool IsFree { get; set; }

        [JsonProperty("dlc")]
        public int[] Dlc { get; set; }

        [JsonProperty("detailed_description")]
        public string DetailedDescription { get; set; }

        [JsonProperty("about_the_game")]
        public string AboutTheGame { get; set; }

        [JsonProperty("supported_languages")]
        public string SupportedLanguages { get; set; }

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("pc_requirements")]
        public PcRequirements PcRequirements { get; set; }

        [JsonProperty("mac_requirements")]
        public MacRequirements MacRequirements { get; set; }

        [JsonProperty("linux_requirements")]
        public LinuxRequirements LinuxRequirements { get; set; }

        [JsonProperty("developers")]
        public string[] Developers { get; set; }

        [JsonProperty("publishers")]
        public string[] Publishers { get; set; }

        [JsonProperty("packages")]
        public string[] Packages { get; set; }

        [JsonProperty("package_groups")]
        public PackageGroup[] PackageGroups { get; set; }

        [JsonProperty("platforms")]
        public Platforms Platforms { get; set; }

        [JsonProperty("metacritic")]
        public Metacritic Metacritic { get; set; }

        [JsonProperty("categories")]
        public Category[] Categories { get; set; }

        [JsonProperty("genres")]
        public Genre[] Genres { get; set; }

        [JsonProperty("screenshots")]
        public Screenshot[] Screenshots { get; set; }

        [JsonProperty("movies")]
        public Movie[] Movies { get; set; }

        [JsonProperty("recommendations")]
        public Recommendations Recommendations { get; set; }

        [JsonProperty("release_date")]
        public ReleaseDate ReleaseDate { get; set; }

        [JsonProperty("support_info")]
        public SupportInfo SupportInfo { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }
    }

    [JsonConverter(typeof(JsonConverterExtension))]
    public class AppDetailsContainer
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
