using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication2.DAL.Models
{
    public class Application
    {
        public Application()
        {

        }

        public Application(string name,int id)
        {
            this.ApplicationName = name;
            this.ApplicationSteamAppId = id;
        }

        [Key]
        public int ApplicationId { get; set; }

        [Required]
        public String ApplicationName { get; set; }

        public ICollection<Description> ApplicationDescriptions { get; set; }

        public int ApplicationSteamAppId { get; set; }
        
    }
}
