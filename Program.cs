using iText.Html2pdf;
using iText.License;
using System.IO;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            LicenseKey.LoadLicenseFile("iTextLicenseKey.xml");
            using (FileStream htmlSource = File.Open("input.html", FileMode.Open))
            using (FileStream pdfDest = File.Open("cmp_checkAttrFunctionWithTypeTest.pdf", FileMode.OpenOrCreate))
            {
                ConverterProperties converterProperties = new ConverterProperties();
                HtmlConverter.ConvertToPdf(htmlSource, pdfDest, converterProperties);
            }
        }
    }
}
