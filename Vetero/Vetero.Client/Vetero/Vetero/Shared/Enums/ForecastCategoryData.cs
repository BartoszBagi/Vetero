using System.ComponentModel.DataAnnotations;

namespace Vetero.Shared.Enums
{
    public enum ForecastCategoryData
    {
        [Display(Description = "Temperatura °C")]
        temp_c,
        [Display(Description = "Wilgotność %")]
        humidity,     
        [Display(Description = "Prędkość wiatru km/h")]
        wind_kph,
        [Display(Description = "Opad deszczu")]
        precip_in
    }
}
