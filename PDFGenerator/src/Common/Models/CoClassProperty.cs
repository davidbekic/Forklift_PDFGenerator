namespace PDFGenerator
{
    public class CoClassProperty
    {
        // public required string ReferenceDesignation { get; set; }
        public required string PropertyType { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public List<CoClassPropertyValue>? Values { get; set; }
    }
}