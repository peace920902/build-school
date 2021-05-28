using Microsoft.AspNetCore.Components;

namespace BuildSchool.Models
{
    public class ServiceData
    {
        public string ImagePath { get; set; }
        public string ImageTitle { get; set; }
        public RenderFragment ImageDescription { get; set; }
        public RenderFragment TextTitle { get; set; }
        public string Text { get; set; }
    }
}