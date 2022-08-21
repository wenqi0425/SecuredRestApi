using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecuredRestApi.Settings
{
    // JWT class will be used to read data from JWT setting in appsettings.json by using IOptions of ASP.NET Core. 
    // appsettings.json
    public class JWT
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double DurationInMinutes { get; set; }
    }
}
