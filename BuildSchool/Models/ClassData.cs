using System.Collections.Generic;

namespace BuildSchool.Models
{
    public class ClassData
    {
        public string Time { get; set; }
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public IEnumerable<string> Description { get; set; }
    }
}