package example;
import com.itextpdf.html2pdf.HtmlConverter;
import com.itextpdf.kernel.pdf.*;
import java.io.*;

public class Main {
    public static void main(String[] args) throws IOException {
        PdfDocument pdfDocument = new PdfDocument(new PdfWriter("cmp_checkAttrFunctionWithTypeTest.pdf"));
        HtmlConverter.convertToPdf(new FileInputStream("inputHtml.html"),pdfDocument);
    }
}
