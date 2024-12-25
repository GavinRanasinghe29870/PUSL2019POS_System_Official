using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace POS_System.UserControls
{
    public partial class InventoryReport : UserControl
    {
        public InventoryReport()
        {
            InitializeComponent();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Inventory Report.pdf";
            bool fileError = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("It wasn't possible to write the data to disk." + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(dataGridViewInventory.ColumnCount);
                        pdfTable.DefaultCell.Padding = 7;
                        pdfTable.DefaultCell.BorderWidth = 1;
                        pdfTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                        iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10f, BaseColor.WHITE);

                        foreach (DataGridViewColumn column in dataGridViewInventory.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, headerFont));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(55, 94, 94);
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_CENTER;
                            cell.PaddingTop = 10;
                            cell.PaddingBottom = 10;
                            cell.BorderWidth = 1;
                            pdfTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dataGridViewInventory.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();

                            // Add issued date
                            Paragraph paragraph = new Paragraph();
                            paragraph.Add(new iTextSharp.text.Chunk("Issued Date - " + DateTime.Now.ToString("dd/MM/yyyy") + "\n"));
                            paragraph.Add(new iTextSharp.text.Chunk("Issued Time - " + DateTime.Now.ToString("HH:mm:ss")));
                            paragraph.Alignment = Element.ALIGN_RIGHT;
                            paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 11f, BaseColor.BLACK);
                            paragraph.SpacingBefore = 3f;
                            paragraph.SpacingAfter = 50f;
                            pdfDoc.Add(paragraph);

                            iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16f, BaseColor.BLACK);

                            // Add title
                            paragraph = new Paragraph();
                            paragraph.Add(new iTextSharp.text.Chunk("**Inventory Report**", titleFont));
                            paragraph.Alignment = Element.ALIGN_CENTER;
                            paragraph.SpacingAfter = 20f;
                            pdfDoc.Add(paragraph);

                            // Add table
                            pdfTable.SpacingBefore = 10f;
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                        }

                        MessageBox.Show("Successfully Saved As PDF !!!", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }
        }
    }
}
