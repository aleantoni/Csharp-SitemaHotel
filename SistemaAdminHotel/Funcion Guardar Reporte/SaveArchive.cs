using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace SistemaAdminHotel.Funcion_Guardar_Reporte
{
    public static class SaveArchive
    {
        public static void GenerateReport (string path, string fecha, Chart chart)
        {
            Document doc = new Document();

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

                doc.Open();

                doc.Add(new Paragraph("Informacion de ventas"));
                doc.Add(new Paragraph("Fecha: " + fecha));
                //doc.Add(new Paragraph("Total: " + total));

                using (MemoryStream chartStream = new MemoryStream())
                {
                    chart.SaveImage(chartStream, ChartImageFormat.Png);
                    iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(chartStream.GetBuffer());
                    doc.Add(chartImage);
                }
                doc.Close();

                MessageBox.Show("Informe guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el informe " + ex.Message);
            }
            finally
            {
                if (doc.IsOpen())
                    doc.Close();
            }
        }
    }
}
