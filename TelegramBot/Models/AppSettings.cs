using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://chatvk.azurewebsites.net:443/{0}";

        public static string Name { get; set; } = "MVCBot";

        public static string Key { get; set; } = "329360020:AAFdorMVuyd51Wy7ci6QKShk0Z11ZKVH9N4";
    }
}