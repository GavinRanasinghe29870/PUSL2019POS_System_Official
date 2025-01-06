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
using System.Data.SqlClient;
using POS_System.Classes;

namespace POS_System.UserControls
{
    public partial class CustomerActivityReport : UserControl
    {
        public CustomerActivityReport()
        {
            InitializeComponent();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Customer Activity Report.pdf";
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
                        PdfPTable pdfTable = new PdfPTable(dataGridViewCustomer.ColumnCount);
                        pdfTable.DefaultCell.Padding = 7;
                        pdfTable.DefaultCell.BorderWidth = 1;
                        pdfTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                        iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10f, BaseColor.WHITE);

                        foreach (DataGridViewColumn column in dataGridViewCustomer.Columns)
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

                        foreach (DataGridViewRow row in dataGridViewCustomer.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string cellValue = cell.Value.ToString();
                                if (cell.ColumnIndex == 2 || cell.ColumnIndex == 3) // 2nd and 5th columns (0-based index)
                                {
                                    if (decimal.TryParse(cellValue, out decimal number))
                                    {
                                        cellValue = number.ToString("#,##0");
                                    }
                                }
                                pdfTable.AddCell(cellValue);
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
                            paragraph.Add(new iTextSharp.text.Chunk("**Customer Activity Report**", titleFont));
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

        private void CustomerActivityReport_Load(object sender, EventArgs e)
        {
            string conString = ConnectionString.constring;
            try
            {
                using (SqlConnection cn = new SqlConnection(conString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("CustomerActivityView"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM CustomerActivityView", cn))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);

                            // Format the TotalValue column to display two decimal places
                            dataGridViewCustomer.Columns["totalAmountSpent"].DefaultCellStyle.Format = "N2";

                            dataGridViewCustomer.DataSource = dt;
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
                    using (DataTable dt = new DataTable("CustomerActivityView"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM CustomerActivityView WHERE CustomerID=@CustomerID", cn))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", txtSearch.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Invalid ID, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Format the TotalValue column to display two decimal places
                            dataGridViewCustomer.Columns["totalAmountSpent"].DefaultCellStyle.Format = "N2";

                            dataGridViewCustomer.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string conString = ConnectionString.constring;
            try
            {
                txtSearch.Text = string.Empty;

                using (SqlConnection cn = new SqlConnection(conString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("CustomerActivityView"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM CustomerActivityView", cn))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);

                            // Format the TotalValue column to display two decimal places
                            dataGridViewCustomer.Columns["totalAmountSpent"].DefaultCellStyle.Format = "N2";

                            dataGridViewCustomer.DataSource = dt;
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