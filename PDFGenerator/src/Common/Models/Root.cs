namespace PDFGenerator
{
    public class Root
    {
        public required List<CoClassObject> CoClassObjects { get; set; }
        public required string ProjectName { get; set; }
        public required string DeliveryName { get; set; }
        public required string Language { get; set; }
        public required string CoClassVersion { get; set; }
        public string? Creator { get; set; }
        public int? DeliveryNumber { get; set; }
        public int? ProjectNumber { get; set; }
        public string? Client { get; set; }
        public string? InformationDesignation { get; set; }
        public string? Phase { get; set; }
        public string? DegreeOfDetermination { get; set; }
        public string? Purpose { get; set; }
        public string? ApprovedBy { get; set; }
        public int? ChangeMemo { get; set; }

    }
}