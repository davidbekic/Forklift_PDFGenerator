using System.IO;
using PDFGenerator;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PDFGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            // Data Source layer handled by main app, or perhaps here?
            var model = new Root
            {
                ProjectName = "Norra Latin",
                DeliveryName = "Technical Description - Requirements",
                Client = "Banfast AB",
                ProjectNumber = 123,
                Language = "en",
                CoClassVersion = "11.0",
                ApprovedBy = "Viktorija Raonic",
                Creator = "Branislav Bekic",
                CoClassObjects = new List<CoClassObject>
                {
                    new CoClassObject
                    {
                        Code = "BDA",
                        Name = "School",
                        ReferenceDesignation = "BDA",
                        ObjectType = "Complex",
                        Properties = new List<CoClassProperty>
                        {
                            new CoClassProperty
                            {
                                Code = "CDNC",
                                PropertyType = "Cultural",
                                Name = "Gross Area",
                                Values = new List<CoClassPropertyValue>
                                {
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "Det var en gång en hög som hetter Tjänder. £$©]@££$",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE, CO, RQ, KS, FS",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                }
                            },
                            new CoClassProperty
                            {
                                Code = "CDNC",
                                PropertyType = "Cultural",
                                Name = "Gross Area",
                                Values = new List<CoClassPropertyValue>
                                {
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "Det var en gång en hög som hetter Tjänder. £$©]@££$",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE, CO, RQ, KS, FS",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                }
                            },
                            new CoClassProperty
                            {
                                Code = "CDNC",
                                PropertyType = "Cultural",
                                Name = "Gross Area",
                                Values = new List<CoClassPropertyValue>
                                {
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "Det var en gång en hög som hetter Tjänder. £$©]@££$",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE, CO, RQ, KS, FS",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                }
                            },
                            new CoClassProperty
                            {
                                Code = "CDNC",
                                PropertyType = "Cultural",
                                Name = "Gross Area",
                                Values = new List<CoClassPropertyValue>
                                {
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "Det var en gång en hög som hetter Tjänder. £$©]@££$",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE, CO, RQ, KS, FS",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                }
                            },
                            new CoClassProperty
                            {
                                Code = "CDNC",
                                PropertyType = "Cultural",
                                Name = "Gross Area",
                                Values = new List<CoClassPropertyValue>
                                {
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "Det var en gång en hög som hetter Tjänder. £$©]@££$",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE, CO, RQ, KS, FS",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                }
                            },
                            new CoClassProperty
                            {
                                Code = "CDNC",
                                PropertyType = "Cultural",
                                Name = "Gross Area",
                                Values = new List<CoClassPropertyValue>
                                {
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "Det var en gång en hög som hetter Tjänder. £$©]@££$",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE, CO, RQ, KS, FS",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                }
                            },
                            new CoClassProperty
                            {
                                Code = "CDNC",
                                PropertyType = "Cultural",
                                Name = "Gross Area",
                                Values = new List<CoClassPropertyValue>
                                {
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "Det var en gång en hög som hetter Tjänder. £$©]@££$",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE, CO, RQ, KS, FS",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                }
                            },
                            new CoClassProperty
                            {
                                Code = "CDNC",
                                PropertyType = "Cultural",
                                Name = "Gross Area",
                                Values = new List<CoClassPropertyValue>
                                {
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "Det var en gång en hög som hetter Tjänder. £$©]@££$",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE, CO, RQ, KS, FS",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                }
                            },
                            new CoClassProperty
                            {
                                Code = "CDNC",
                                PropertyType = "Cultural",
                                Name = "Gross Area",
                                Values = new List<CoClassPropertyValue>
                                {
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "Det var en gång en hög som hetter Tjänder. £$©]@££$",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE, CO, RQ, KS, FS",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                }
                            },
                            new CoClassProperty
                            {
                                Code = "CDNC",
                                PropertyType = "Cultural",
                                Name = "Gross Area",
                                Values = new List<CoClassPropertyValue>
                                {
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "Det var en gång en hög som hetter Tjänder. £$©]@££$",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE, CO, RQ, KS, FS",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                }
                            },
                            new CoClassProperty
                            {
                                Code = "CDNC",
                                PropertyType = "Cultural",
                                Name = "Gross Area",
                                Values = new List<CoClassPropertyValue>
                                {
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "Det var en gång en hög som hetter Tjänder. £$©]@££$",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE, CO, RQ, KS, FS",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                }
                            },
                            new CoClassProperty
                            {
                                Code = "CDNC",
                                PropertyType = "Cultural",
                                Name = "Gross Area",
                                Values = new List<CoClassPropertyValue>
                                {
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "Det var en gång en hög som hetter Tjänder. £$©]@££$",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE, CO, RQ, KS, FS",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                }
                            },
                            new CoClassProperty
                            {
                                Code = "CDNC",
                                PropertyType = "Cultural",
                                Name = "Gross Area",
                                Values = new List<CoClassPropertyValue>
                                {
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "Det var en gång en hög som hetter Tjänder. £$©]@££$",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE, CO, RQ, KS, FS",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                    new CoClassPropertyValue
                                    {
                                        Discipline = "A",
                                        Phase = "DE",
                                        Source = "BBR",
                                        Position = "#1",
                                        Value = "1000m2",
                                    },
                                }
                            },
                            new CoClassProperty
                            {
                                Code = "PNNM",
                                PropertyType = "Material",
                                Name = "Project Name",
                            },
                        }
                    },
                    new CoClassObject
                    {
                        Code = "BDA",
                        Name = "School.Classroom",
                        ReferenceDesignation = "BDA.AD",
                        ObjectType = "Entity",
                    },
                    // new CoClassProperty
                    // {
                    //     Code = "BDA",
                    //     Name = "School",
                    //     ReferenceDesignation = "BDA.CDNC",
                    // },
                }
            };
            // var model = FreeReportDataSource.GetReportDetails();
            var document = new TechnicalDescriptionDocument(model);
            document.GeneratePdf("hello.pdf");
            Console.WriteLine("PDF generated successfully.");
        }
    }
}