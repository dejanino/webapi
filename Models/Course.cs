using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEDCApi.Models
{
    public class Course
    {
        public int id { get; set; }
        public string image { get; set; }
        public DateTime date { get; set; }
        public int duration { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public Teacher teacher { get; set; }
    }
}