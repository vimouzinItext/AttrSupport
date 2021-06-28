package Example;

import com.itextpdf.html2pdf.HtmlConverter;
import com.itextpdf.kernel.pdf.*;
import com.itextpdf.licensekey.LicenseKey;
import java.io.*;

public class Main {
    public static void main(String[] args) throws IOException {
        LicenseKey.loadLicenseFile("iTextKey.xml");
        PdfDocument pdfDocument = new PdfDocument(new PdfWriter("output.pdf"));
        HtmlConverter.convertToPdf(new FileInputStream("sample_original (2).html"),pdfDocument);
    }
}
