using iText.Html2pdf;
using System.IO;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {        
            using (FileStream htmlSource = File.Open("inputHtml.html", FileMode.Open))
            using (FileStream pdfDest = File.Open("output.pdf", FileMode.OpenOrCreate))
            {
                ConverterProperties converterProperties = new ConverterProperties();
                HtmlConverter.ConvertToPdf(htmlSource, pdfDest, converterProperties);
            }
        }
    }
}
