using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecretSatanWebMVC.Models
{
    public class People
    {
        public string Text { get; set; }
        public string[] Names { get; set; }
        public Dictionary<string, string> Pairs { get; set; }
        public static bool IsSet = false;
    }
}