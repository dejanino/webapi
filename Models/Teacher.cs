using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEDCApi.Models
{
    public class Teacher
    {
        public int id { get; set; }
        public string name { get; set; }
        public string avatarurl { get; set; }
        public string slogan { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string linkedin { get; set; }
        public string instagram { get; set; }
        public string google { get; set; }
        public string email { get; set; }
    }
}