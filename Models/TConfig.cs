using System.ComponentModel.DataAnnotations;

namespace MedicalCharlesWembley.Models
{
    public class TConfig
    {
        public int ConfigID { get; set; }
        public string? ConfigGroup1 { get; set; }
        public string? ConfigGroup2 { get; set; }
        public string? ConfigKeyword { get; set; }
        public string? ConfigDescription { get; set; }
        public string? ConfigValueRange { get; set; }
        public bool? Is_Admin { get; set; }
        [Required(ErrorMessage = "Config Name is required")]
        public string? ConfigName { get; set; }
        [Required(ErrorMessage = "Config Value is required")]
        public string? ConfigValue { get; set; }
        public string? ConfigType { get; set; }
    }
}