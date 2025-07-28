namespace MedicalCharlesWembley.Models;

public class TPollOption
    {
        public int PollOptionID { get; set; }
        public int PollID { get; set; }
        public string? Answer { get; set; }
        public int? Votes { get; set; }
        public TPoll? TPoll { get; set; }
    }