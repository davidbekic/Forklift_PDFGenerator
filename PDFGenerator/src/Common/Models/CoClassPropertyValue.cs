namespace PDFGenerator
{
    public class CoClassPropertyValue
    {
        // public required string ReferenceDesignation { get; set; }
        public required string Discipline { get; set; }
        public required string Phase { get; set; }
        public required string Source { get; set; }
        public required string Value { get; set; }
        public string? Position { get; set; }
    }
}