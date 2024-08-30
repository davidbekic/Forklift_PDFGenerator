using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PDFGenerator
{
    public class TechnicalDescriptionDocument : IDocument
    {
        public Root Model { get; }

        public TechnicalDescriptionDocument(Root model)
        {
            Model = model;
        }
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;

        public void Compose(IDocumentContainer container)
        {
            container

                .Page(page =>
                {
                    page.Margin(30);
                    page.Content().Element(ComposeFirstPage);
                });
            container

                .Page(page =>
                {
                    page.Margin(30);
                    page.Content().Element(ComposeTableOfContents);
                    // page.Content().Text(text =>
                    // {
                    //     text.SectionLink("Custom location link", "BDA.AD");
                    // }); ;
                });
            container
                .Page(page =>
                {
                    page.Margin(30);
                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                    page.Footer().AlignCenter().Text(x =>
                    {
                        x.CurrentPageNumber();
                        x.Span(" / ");
                        x.TotalPages();
                    });
                });
            // container
            //     .Page(page =>
            //     {
            //         page.Margin(50);

            //         page.Header().Height(100).Background(Colors.Grey.Lighten1);
            //         page.Content().Background(Colors.Grey.Lighten3);
            //         page.Footer().Height(50).Background(Colors.Grey.Lighten1);
            //     });
        }

        void ComposeHeader(IContainer container)
        {
            var titleStyle = TextStyle.Default.FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

            container
            // .PaddingVertical()
            .Table(table =>
            {

                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });
                table.Cell().RowSpan(3).ColumnSpan(3).Element(container =>
                {
                    return container
                        .Border(1)
                        // .ShowOnce()
                        .MinWidth(50)
                        .MinHeight(50)
                        .AlignCenter()
                        .AlignMiddle();
                }).Text("Forklift").FontSize(25);
                table.Cell().ColumnSpan(3).Element(Block).Text(LanguageHelper.CheckLanguage(Model.Language, "Project Name") + "\n" + Model.ProjectName).FontSize(8);
                table.Cell().ColumnSpan(3).Element(Block).Text(text =>
                {
                    text.Span(LanguageHelper.CheckLanguage(Model.Language, "Project Number")).FontSize(8);
                    text.Span("\n").FontSize(8);
                    text.Span(Model.ProjectNumber.ToString()).FontSize(8);
                });
                table.Cell().ColumnSpan(3).Element(Block).Text(text =>
                {
                    text.Span(LanguageHelper.CheckLanguage(Model.Language, "Page")).FontSize(8);
                    text.Span("\n").FontSize(8);
                    text.CurrentPageNumber().FontSize(8);
                });
                table.Cell().ColumnSpan(6).Element(Block).Text(text =>
                {
                    text.Span(LanguageHelper.CheckLanguage(Model.Language, "Delivery Name")).FontSize(8);
                    text.Span("\n").FontSize(8);
                    text.Span(Model.DeliveryName).FontSize(8);
                });
                table.Cell().ColumnSpan(3).Element(Block).Text(text =>
                {
                    text.Span(LanguageHelper.CheckLanguage(Model.Language, "Creator")).FontSize(8);
                    text.Span("\n").FontSize(8);
                    text.Span(Model.Creator).FontSize(8);
                });
                table.Cell().ColumnSpan(6).Element(Block).Text("Classification\nCoClass").FontSize(8);
                table.Cell().ColumnSpan(3).Element(Block).Text(text =>
                {
                    text.Span(LanguageHelper.CheckLanguage(Model.Language, "Date")).FontSize(8);
                    text.Span("\n").FontSize(8);
                    text.Span(DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString()).FontSize(8);
                });
                table.Cell().ColumnSpan(3).Element(BottomBlock).Text(LanguageHelper.CheckLanguage(Model.Language, "Code")).FontSize(8);
                table.Cell().ColumnSpan(6).Element(BottomBlock).Text(LanguageHelper.CheckLanguage(Model.Language, "Value")).FontSize(8);
                table.Cell().Element(BottomBlock).Text(LanguageHelper.CheckLanguage(Model.Language, "Discipline")).FontSize(8);
                table.Cell().Element(BottomBlock).Text(LanguageHelper.CheckLanguage(Model.Language, "Phase")).FontSize(8);
                table.Cell().Element(BottomBlock).Text(LanguageHelper.CheckLanguage(Model.Language, "Source")).FontSize(8);

                // for simplicity, you can also use extension method described in the "Extending DSL" section
                static IContainer Block(IContainer container)
                {
                    return container
                        .Border(1)
                        // .Background(Colors.White)
                        .Padding(3)
                        .MinWidth(50)
                        .MinHeight(20);
                    // .AlignCenter()
                    // .AlignMiddle();
                }
                static IContainer BottomBlock(IContainer container)
                {
                    return container
                        // .Border(1)
                        .BorderLeft(1)
                        .BorderRight(1)
                        .Padding(3)
                        .MinWidth(10)
                        // .MaxWidth(20)
                        .MinHeight(20);
                }
            });
        }

        void ComposeTableOfContents(IContainer container)
        {
            container
                .Padding(20)
                .Column(column =>
                {
                    // Title for the Table of Contents
                    column.Item()
                            .Text("Table of Contents");
                    // Loop through CoClassObjects to create each entry
                    for (var i = 0; i < Model.CoClassObjects.Count; i++)
                    {
                        Console.WriteLine(Model.CoClassObjects[i].ReferenceDesignation);
                        var coClassObject = Model.CoClassObjects[i];
                        column.Item().Text(text =>
                        {
                            text.SectionLink(StringFormatter.FormatReferenceDesignation(Model.CoClassObjects[i].ReferenceDesignation), Model.CoClassObjects[i].ReferenceDesignation);
                        });
                    }
                });
            // }
        }


        // void ComposeContent(IContainer container)
        // {
        //     container
        //         .Column(column =>
        //         {
        //             for (var i = 0; i < Model.CoClassObjects.Count; i++)
        //             {
        //                 column.Item().Section(Model.CoClassObjects[i].Code).Table(table =>
        //                 {
        //                     table.ColumnsDefinition(columns =>
        //                     {
        //                         for (int k = 0; k < 12; k++)
        //                         {
        //                             columns.RelativeColumn();
        //                         }
        //                     });

        //                     table.Cell().ColumnSpan(3).Element(Block).Text(Model.CoClassObjects[i].ReferenceDesignation).FontSize(8);
        //                     table.Cell().ColumnSpan(6).Element(Block).Text(Model.CoClassObjects[i].Name).FontSize(8);
        //                     table.Cell().ColumnSpan(3).Element(Block);
        //                 });
        //                 for (var j = 0; j < Model.CoClassObjects[i].Properties?.Count; j++)
        //                 {
        //                     column.Item().Section(Model.CoClassObjects[i].Properties?[j].Code).Table(table =>
        //                 {
        //                     table.ColumnsDefinition(columns =>
        //                     {
        //                         for (int k = 0; k < 12; k++)
        //                         {
        //                             columns.RelativeColumn();
        //                         }
        //                     });

        //                     table.Cell().ColumnSpan(3).Element(Block).Text(Model.CoClassObjects[i].Properties?[j].Code).FontSize(8);
        //                     table.Cell().ColumnSpan(6).Element(Block).Text(Model.CoClassObjects[i].Properties?[j].Name).FontSize(8);
        //                     table.Cell().ColumnSpan(3).Element(Block);
        //                 });
        //                 }
        //             }
        //         });

        //     static IContainer Block(IContainer container)
        //     {
        //         return container
        //             .Padding(3)
        //             .ShowOnce()
        //             .MinWidth(50)
        //             .MinHeight(20);
        //     }
        // }

        void ComposeContent(IContainer container)
        {
            container
                .Column(column =>
                {
                    for (var i = 0; i < Model.CoClassObjects.Count; i++)
                    {
                        column.Item().PaddingTop(15);
                        column.Item().Element(c => ComposeObject(c, Model.CoClassObjects[i]));
                    }
                });
        }

        static void ComposeObject(IContainer container, CoClassObject coClassObject)
        {
            Color backgroundColor = CoClassObject.GetObjectColor(coClassObject.ObjectType);
            // Console.WriteLine(coClassObject.ReferenceDesignation);
            container.Section(coClassObject.ReferenceDesignation).Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    for (int k = 0; k < 12; k++)
                        columns.RelativeColumn();
                });
                table.Cell().ColumnSpan(3).Element(c => ObjectBlock(c, backgroundColor)).Text(StringFormatter.FormatReferenceDesignation(coClassObject.ReferenceDesignation)).FontSize(12).FontColor(Colors.White);
                table.Cell().ColumnSpan(6).Element(c => ObjectBlock(c, backgroundColor)).Text(StringFormatter.FormatReferenceDesignation(coClassObject.Name)).FontSize(12).FontColor(Colors.White);
                table.Cell().ColumnSpan(3).Element(c => ObjectBlock(c, backgroundColor)).Text("");

                if (coClassObject.Properties != null)
                {
                    for (var i = 0; i < coClassObject.Properties.Count; i++)
                    {
                        if (coClassObject.Properties[i].Values != null)
                        {
                            // table.Cell().ColumnSpan(12).RowSpan(2).Element(c => c.Border(1).ExtendHorizontal());
                            table.Cell().ColumnSpan(12).Element(c => ComposeProperty(c, coClassObject.Properties[i]));
                        }
                    }
                }
            });
        }

        static void ComposeProperty(IContainer container, CoClassProperty coClassProperty)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    for (int k = 0; k < 12; k++)
                        columns.RelativeColumn();
                });

                table.Cell().ColumnSpan(3).Element(Block).Text(coClassProperty.Code).FontSize(8);
                table.Cell().ColumnSpan(6).Element(Block).Text(StringFormatter.FormatReferenceDesignation(coClassProperty.Name)).FontSize(8);
                table.Cell().ColumnSpan(3).Element(Block);
                table.Cell().ColumnSpan(12).RowSpan(2).Element(c => c.Border(1).ExtendHorizontal());

                // if (coClassProperty.Values != null)
                // {
                for (var i = 0; i < coClassProperty.Values?.Count; i++)
                {
                    table.Cell().ColumnSpan(12).Element(c => ComposeValue(c, coClassProperty.Values[i]));
                }
                // }
            });
        }

        static void ComposeValue(IContainer container, CoClassPropertyValue coClassValue)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    for (int k = 0; k < 12; k++)
                        columns.RelativeColumn();
                });

                table.Cell().ColumnSpan(3).Element(Block).Text(coClassValue.Position).FontSize(8);
                table.Cell().ColumnSpan(6).Element(Block).Text(coClassValue.Value).FontSize(8);
                table.Cell().Element(Block).Text(coClassValue.Discipline).FontSize(8);
                table.Cell().Element(Block).Text(coClassValue.Phase).FontSize(8);
                table.Cell().Element(Block).Text(coClassValue.Source).FontSize(8);



            });
        }

        static IContainer Block(IContainer container)
        {
            return container
                .Padding(3)
                // .MinWidth(10)
                .MinHeight(10);
        }

        static IContainer ObjectBlock(IContainer container, Color BackgroundColor)
        {
            return container
                .Background(BackgroundColor)
                .Padding(3);
            // .MinWidth(10)
            // .MinHeight(20);
        }

        void ComposeFirstPage(IContainer container)
        {
            container
           .PaddingVertical(40)
           // .Height(250)
           .AlignCenter()
           .AlignMiddle()
           .Row(row =>
           {
               row.RelativeItem().Column(column =>
               {
                   column.Item().Text(Model.DeliveryName).Style(TextStyle.Default.FontSize(24));
                   column.Item().Text(LanguageHelper.CheckLanguage(Model.Language, "Project Name") + ": " + Model.ProjectName);
                   if (Model.Client != null)
                   {
                       column.Item().Text(LanguageHelper.CheckLanguage(Model.Language, "Client") + ": " + Model.Client);
                   }
                   column.Item().Text(LanguageHelper.CheckLanguage(Model.Language, "CoClassVersion") + ": " + Model.CoClassVersion);
                   if (Model.ProjectNumber != null)
                   {
                       column.Item().Text(LanguageHelper.CheckLanguage(Model.Language, "Project Number") + ": " + Model.ProjectNumber.ToString());
                   }
               });
           });

        }

    }
}