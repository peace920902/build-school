using Microsoft.AspNetCore.Components;

namespace BuildSchool.Shared
{
    public partial class BaseComponent
    {
        [Parameter] public string Class { get; set; }
        [Parameter] public string Style { get; set; }
    }
}