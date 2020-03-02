using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEDCApi.Models
{
    public class Review
    {
        public int id { get; set; }
        public string reviewtext { get; set; }
        public int grade { get; set; }
        public Student student { get; set; }
    }
}