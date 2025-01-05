using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using POS_System.Classes;
using System.Data.SqlClient;

namespace POS_System.UserControls
{
    public partial class SalesReport : UserControl
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Sales Report.pdf";
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
                        PdfPTable pdfTable = new PdfPTable(dataGridViewSales.ColumnCount);
                        pdfTable.DefaultCell.Padding = 7;
                        pdfTable.DefaultCell.BorderWidth = 1;
                        pdfTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                        iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10f, BaseColor.WHITE);
                        iTextSharp.text.Font dataFont = FontFactory.GetFont(FontFactory.HELVETICA, 10f, BaseColor.BLACK);

                        foreach (DataGridViewColumn column in dataGridViewSales.Columns)
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

                        foreach (DataGridViewRow row in dataGridViewSales.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value is DateTime)
                                {
                                    pdfTable.AddCell(new Phrase(((DateTime)cell.Value).ToString("dd/MM/yyyy"), dataFont));
                                }
                                else
                                {
                                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), dataFont));
                                }
                            }
                        }

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(new iTextSharp.text.Rectangle(PageSize.A4.Height, PageSize.A4.Width), 10f, 10f, 10f, 0f);
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
                            paragraph.Add(new iTextSharp.text.Chunk("**Sales Records**", titleFont));
                            paragraph.Alignment = Element.ALIGN_CENTER;
                            paragraph.SpacingAfter = 20f;
                            pdfDoc.Add(paragraph);

                            // Add date range
                            paragraph = new Paragraph();
                            if (dtFrom.Value.Date == dtTo.Value.Date)
                            {
                                paragraph.Add(new iTextSharp.text.Chunk(" Sales Record - " + dtFrom.Value.ToString("dddd, dd/MM/yyyy")));
                            }
                            else
                            {
                                paragraph.Add(new iTextSharp.text.Chunk("Sales Record From " + dtFrom.Value.ToString("dd/MM/yyyy") + " To " + dtTo.Value.ToString("dd/MM/yyyy")));
                            }
                            paragraph.Alignment = Element.ALIGN_LEFT;
                            paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 13f, BaseColor.BLACK);
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

        private void SalesReport_Load(object sender, EventArgs e)
        {
            dtFrom.Value = DateTime.Today;
            dtTo.Value = DateTime.Today;

            string conString = ConnectionString.constring;
            try
            {
                using (SqlConnection cn = new SqlConnection(conString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("Sales"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM SalesVIew WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)", cn))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);

                            

                            dataGridViewSales.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string conString = ConnectionString.constring;
            try
            {
                using (SqlConnection cn = new SqlConnection(conString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    using (DataTable dt = new DataTable())
                    {
                        // Get the selected date from the date pickers
                        DateTime fromDate = dtFrom.Value.Date;
                        DateTime toDate = dtTo.Value.Date.AddDays(1).AddSeconds(-1);

                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM SalesView WHERE SaleDate BETWEEN @fromDate AND @toDate", cn))
                        {
                            // Add parameters for date range
                            cmd.Parameters.AddWithValue("@fromDate", fromDate);
                            cmd.Parameters.AddWithValue("@toDate", toDate);

                            // Fill data into DataTable
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                            sqlDataAdapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No sales records found for the selected date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            dataGridViewSales.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewToday_Click(object sender, EventArgs e)
        {
            string conString = ConnectionString.constring;
            try
            {
                dtFrom.Value = DateTime.Now;
                dtTo.Value = DateTime.Now;

                using (SqlConnection cn = new SqlConnection(conString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("Sales"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM SalesVIew WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)", cn))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);



                            dataGridViewSales.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
