using System;
using System.Collections.Generic;
using System.Text;

namespace MaoNaMassa1
{
    public class Carrer : Content
    {
        public Carrer(string title, string url) : base(title, url)
        {
            Items = new List<CarrerItem>();
        }
        public int Courses { get; set; }
        public IList<CarrerItem> Items { get; set; } = new List<CarrerItem>();
        public int TotalCourses => Items.Count;
        
    }
}
