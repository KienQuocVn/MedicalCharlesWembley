namespace MedicalCharlesWembley.Models;

public class TDownload
    {
        public int DownloadID { get; set; }
        public string? Filename { get; set; }
        public string? Mask { get; set; }
        public int Remaining { get; set; }
        public DateTime RegDate { get; set; }
    }