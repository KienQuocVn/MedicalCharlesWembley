namespace MedicalCharlesWembley.Models;

public class TZoneToGeoZone
    {
        public int zone_to_geo_zone_id { get; set; }
        public int country_id { get; set; }
        public int? zone_id { get; set; }
        public int? geo_zone_id { get; set; }
        public DateTime date_added { get; set; }
        public DateTime date_modified { get; set; }
    }