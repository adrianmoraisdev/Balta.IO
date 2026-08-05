using System;
using System.Collections.Generic;
using System.Text;

namespace MaoNaMassa1
{
    public class CarrerItem : Base
    {
        public CarrerItem(int ordem, string title, string description, Course course)
        {
            if (course == null)
                throw new ArgumentNullException("Course cannot be null.");
            Ordem = ordem;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Ordem { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}
