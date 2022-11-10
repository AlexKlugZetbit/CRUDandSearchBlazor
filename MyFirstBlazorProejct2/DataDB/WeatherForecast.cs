using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstBlazorProejct2.DataDB
{
    public partial class WeatherForecast
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? TemperatureC { get; set; }
        public string? Summary { get; set; }
        public int? TemperatureF { get; set; }
    }
}
