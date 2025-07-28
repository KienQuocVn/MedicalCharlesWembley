namespace MedicalCharlesWembley.Models;

public class TProductToDownload
    {
        public int ProductID { get; set; }
        public int DownloadID { get; set; }
        public TProduct? TProduct { get; set; }
        public TDownload? TDownload { get; set; }
    }