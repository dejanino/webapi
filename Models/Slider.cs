using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEDCApi.Models
{
    public class Slider
    {
        public int id { get; set; }
        public string imageurl { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
    }
}