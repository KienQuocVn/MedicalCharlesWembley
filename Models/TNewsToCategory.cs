namespace MedicalCharlesWembley.Models;

public class TNewsToCategory
    {
        public int NewsCategoryID { get; set; }
        public long NewsID { get; set; }
        public TNewsCategory? TNewsCategory { get; set; }
    }