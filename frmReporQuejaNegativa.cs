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
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;

namespace sistemareparto
{
    public partial class frmReporQuejaNegativa : Form
    {
        private void pro_Negativas()
        {

            clsConsultas mclsNegativas = new clsConsultas();
            dvg_QuejasNegativas.DataSource = mclsNegativas.fun_getAllQuejasNegativas();
        }

        public frmReporQuejaNegativa()
        {
            InitializeComponent();
            pro_Negativas();
        }

        private void dvg_QuejasNegativas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ReporteQuejasNegativas_Click(object sender, EventArgs e)
        {

            
            //CREACION DE LA TABLA iTextSharp  
            PdfPTable pdfTable = new PdfPTable(dvg_QuejasNegativas.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            //AÑADIR FILA
            foreach (DataGridViewColumn column in dvg_QuejasNegativas.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);

            }

          //RECORRE EL DATAGRID
            foreach (DataGridViewRow row in dvg_QuejasNegativas.Rows)
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


            using (FileStream stream = new FileStream(folderPath + "Repartidores con quejas Negativas.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph("REPARTIDORES CON QUEJAS NEGATIVAS"));
                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }
    }
}
