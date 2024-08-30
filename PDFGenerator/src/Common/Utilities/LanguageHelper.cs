namespace PDFGenerator
{
    public static class LanguageHelper
    {
        // A dictionary to hold translations for various labels
        private static readonly Dictionary<string, Dictionary<string, string>> Translations =
            new Dictionary<string, Dictionary<string, string>>
        {
            { "en", new Dictionary<string, string>
                {
                    { "Project Name", "Project Name" },
                    { "Client", "Client" },
                    { "CoClass Version", "CoClass Version" },
                    { "Project Number", "Project Number" },
                    { "Delivery Name", "Delivery Name" },
                    { "Reference Designation", "Reference Designation" },
                    { "Type", "Type" },
                    { "Code", "Code" },
                    { "Value", "Value" },
                    { "Label", "Label" },
                    { "Text", "Text" },
                    { "Location", "Location" },
                    { "Photo Count", "Photo Count" },
                    { "Date", "Date" },
                    { "Comments", "Comments" }
                }
            },
            { "sv", new Dictionary<string, string>
                {
                    { "Project Name", "Projektnamn" },
                    { "Client", "Beställare" },
                    { "CoClass Version", "CoClass Version" },
                    { "Project Number", "Projektnummer" },
                    { "Delivery Name", "Leveransnamn" },
                    { "Reference Designation", "Referensbeteckning" },
                    { "Type", "Typ" },
                    { "Code", "Kod" },
                    { "Value", "Värde" },
                    { "Label", "Etikett" },
                    { "Text", "Text" },
                    { "Location", "Plats" },
                    { "Photo Count", "Fotografering" },
                    { "Date", "Datum" },
                    { "Comments", "Kommentarer" }
                }
            }
        };

        // Method to retrieve the translated text based on label and language
        public static string GetTranslation(string label, string languageCode)
        {
            if (Translations.ContainsKey(languageCode) && Translations[languageCode].ContainsKey(label))
            {
                return Translations[languageCode][label];
            }

            // Fallback to English if translation is not found
            return Translations["en"].ContainsKey(label) ? Translations["en"][label] : label;
        }

        static public string CheckLanguage(string language, string label)
        {
            if (label == "Project Name")
            {
                return language == "en" ? "Project Name" : "Projektnamn";
            }
            else if (label == "Client")
            {
                return language == "en" ? "Client" : "Beställare";
            }
            else if (label == "CoClassVersion")
            {
                return "CoClass Version";
            }
            else if (label == "Project Number")
            {
                return language == "en" ? "Project Number" : "Projektnummer";
            }
            else if (label == "Delivery Name")
            {
                return language == "en" ? "Delivery Name" : "Leveransnamn";
            }
            else if (label == "Reference Designation")
            {
                return language == "en" ? "Reference Designation" : "Referensbeteckning";
            }
            else if (label == "Type")
            {
                return language == "en" ? "Type" : "Typ";
            }
            else if (label == "Code")
            {
                return language == "en" ? "Code" : "Kod";
            }
            else if (label == "Value")
            {
                return language == "en" ? "Value" : "Värde";
            }
            else if (label == "Label")
            {
                return language == "en" ? "Label" : "Etikett";
            }
            else if (label == "Text")
            {
                return language == "en" ? "Text" : "Text";
            }
            else if (label == "Location")
            {
                return language == "en" ? "Location" : "Plats";
            }
            else if (label == "Photo Count")
            {
                return language == "en" ? "Photo Count" : "Fotografering";
            }
            else if (label == "Date")
            {
                return language == "en" ? "Date" : "Datum";
            }
            else if (label == "Comments")
            {
                return language == "en" ? "Comments" : "Kommentarer";
            }
            else if (label == "Page")
            {
                return language == "en" ? "Page" : "Sida";
            }
            else if (label == "Creator")
            {
                return language == "en" ? "Creator" : "Skapare";
            }
            else if (label == "Discipline")
            {
                return language == "en" ? "Discipline" : "Disciplin";
            }
            else if (label == "Phase")
            {
                return language == "en" ? "Phase" : "Fas";
            }
            else if (label == "Source")
            {
                return language == "en" ? "Source" : "Källa";
            }
            else
                return "";
        }
    }
}
