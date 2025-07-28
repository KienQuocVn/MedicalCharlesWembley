namespace MedicalCharlesWembley.Models;

public class TMapTerritoryArea
    {
        public long MapTerriAreaID { get; set; }
        public int? TerritoryID { get; set; }
        public int? AreaID { get; set; }
        public string? Keyword { get; set; }
        public long? TMapID { get; set; }
    }