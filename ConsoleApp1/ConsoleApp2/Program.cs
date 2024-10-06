using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            Page page = doc.Pages.Add();

            page.Paragraphs.Add(new TextFragment("ddsdsdd World!"));

            Table table = new Table();
            table.Border = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));

            Row fila = table.Rows.Add();
            fila.Cells.Add("1");

            doc.Pages[1].Paragraphs.Add(table);

            doc.Save("C:/loga/archivo.pdf");
            Console.ReadKey();
        }
    }
}
