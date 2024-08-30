using System;

namespace PDFGenerator
{
    public class StringFormatter
    {
        static public string FormatReferenceDesignation(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return input.Replace(".", " > ");
        }
    }
}