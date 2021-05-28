using Microsoft.AspNetCore.Components;

namespace BuildSchool.Models
{
    public class BannerData
    {
        public RenderFragment Title { get; set; }
        public RenderFragment SubTitle { get; set; }
        public string ImgPath { get; set; }
        public bool IsEnglish { get; set; }
    }
}