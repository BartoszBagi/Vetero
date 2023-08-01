using System.ComponentModel.DataAnnotations;

namespace Vetero.Shared.Enums
{
    public enum CategoryData
    {
        [Display(Description = "Temperatura")]
        Temperature,
        [Display(Description = "Wilgotność")]
        Humidity,     
        [Display(Description = "Prędkość wiatru")]
        WindKph,
        [Display(Description = "Opad deszczu")]
        TotalPrecip_mm
    }
}
