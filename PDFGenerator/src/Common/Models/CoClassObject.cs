using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PDFGenerator
{
    public class CoClassObject
    {
        public required string ReferenceDesignation { get; set; }
        public required string ObjectType { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public List<CoClassProperty>? Properties { get; set; }
        public static Color GetObjectColor(string ObjectType)
        {
            return ObjectType.ToLower() switch
            {
                "complex" => Colors.Black,
                "entity" => Colors.Green.Darken2,
                "space complex" => Colors.Yellow.Darken1,
                "space" => Colors.Yellow.Medium,
                "functional system" => Colors.Blue.Lighten3,
                "compositional system" => Colors.Blue.Lighten3,
                "component" => Colors.Blue.Lighten1,
                "work result" => Colors.Blue.Lighten1,
                _ => Colors.Black,
            };
        }
    }
}