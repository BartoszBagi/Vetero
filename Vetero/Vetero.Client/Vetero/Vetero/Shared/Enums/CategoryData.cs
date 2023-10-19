﻿using System.ComponentModel.DataAnnotations;

namespace Vetero.Shared.Enums
{
    public enum CategoryData
    {
        [Display(Description = "Temperatura °C")]
        Temperature,
        [Display(Description = "Wilgotność %")]
        Humidity,     
        [Display(Description = "Prędkość wiatru km/h")]
        WindKph,
        [Display(Description = "Opad deszczu")]
        TotalPrecip_mm
    }
}