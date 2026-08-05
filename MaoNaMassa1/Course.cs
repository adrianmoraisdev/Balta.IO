using MaoNaMassa1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaoNaMassa1
{
    public class Course : Content
    {
        public Course(string title, string url) : base(title, url)
        {
            Modules = new List<Module>();
            
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
