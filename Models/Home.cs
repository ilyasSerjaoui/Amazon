using System;
using static System.Net.Mime.MediaTypeNames;

namespace amazon.Models
{
    public class Home
    {
        public string name { get; set; }
        public string image { get; set; }
        public string price { get; set; }
        public string type { get; set; }
        public int howmush { get; set; }

        public string f_n { get; set; }
        public string s_n { get; set; }
        public string email { get; set; }
        public string ps { get; set; }
        public string bd { get; set; }
    }
}
