using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackatonBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://projecthackaton.herokuapp.com:443/{0}";
        public static string Name { get; set; } = "HackatonBot";
        public static string Key { get; set; } = "877554193:AAEE_C5ixIcqbT511sG3t5rjH9p4nSbg-hU";
    }
}