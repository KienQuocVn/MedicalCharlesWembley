namespace MedicalCharlesWembley.Models;

public class TTerritory
    {
        public int TerritoryID { get; set; }
        public string? TerritoryName { get; set; }
        public int? TerriParent { get; set; }
        public int? Status { get; set; }
        public int? AreaID { get; set; }
        public int? SortOrder { get; set; }
    }