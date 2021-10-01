using System;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Windows.Forms;

namespace Delegations
{
    public class SaveToPDF : IExportToFIle
    {

        private readonly WarningBox warning = new WarningBox();
        private readonly InfoBox info = new InfoBox();

        public Boolean  Save(DataGridView dataGridView, string filename)
        {

            if (dataGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = $"{filename}.pdf"
                };

                
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
                           
                            warning.Write("It wasn't possible to write the data to the disk." + ex.Message);
                            return false;
                        }
                    }
                    
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = 1;

                            foreach (DataGridViewColumn column in dataGridView.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            info.Write("Plik zapisany pomyślnie");
                            return true;
                        }
                        catch (Exception ex)
                        {
                            warning.Write("Error :" + ex.Message);
                            return false;
                        }
                     
                }
            }
            else
            {
                warning.Write("Nie ma żadnych danych w tabeli!");
                return false;
            }

            return false;
        }

    }
}
