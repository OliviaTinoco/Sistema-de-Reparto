using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemareparto.Modelo;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

namespace sistemareparto
{
    public partial class frmReporteReparQuejaPositiva : Form
    {
        private void pro_loadQuejasPositivas()
        {
            clsConsultas mclsQuejaPositivas = new clsConsultas();
            dvg_QuejasPositivas.DataSource = mclsQuejaPositivas.fun_getAllQuejasPositivas();
        }
        public frmReporteReparQuejaPositiva()
        {
            InitializeComponent();

            pro_loadQuejasPositivas();
        }

        private void frmReporteReparQuejaPositiva_Load(object sender, EventArgs e)
        {

        }

        private void btn_ReporteQuejasPositivas_Click(object sender, EventArgs e)
        {

            //CREACION DE LA TABLA iTextSharp 
            PdfPTable pdfTable = new PdfPTable(dvg_QuejasPositivas.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            //AÑADIR FILA
            foreach (DataGridViewColumn column in dvg_QuejasPositivas.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);

            }

            //RECORRE EL DATAGRID
            foreach (DataGridViewRow row in dvg_QuejasPositivas.Rows)
            {
                if (row.DataBoundItem != null)
                {

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }

                }
            }
            //EXPORTA AL PDF
            string folderPath = " D:\\Merlyn c\\Desktop\\PDFs\\";
         
            if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

            if (Directory.Exists(folderPath))
            {
                  MessageBox.Show("Reporte Creado Exitosamente!!!");
            }


            using (FileStream stream = new FileStream(folderPath + "Repartidores con quejas positivas.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Paragraph("REPARTIDORES CON QUEJAS POSITIVAS"));
                    pdfDoc.Add(Chunk.NEWLINE);
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            
        }
    }
}
