using System;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Windows.Forms;

namespace Delegacje_Służbowe
{
    class ExportClass
    {
        private readonly DataGridView dataGridView;
        private readonly string filename;



        public ExportClass(DataGridView dataGrid, string filename)
        {
            this.dataGridView = dataGrid;
            this.filename = filename;
        }

        public void ExportCSV()
        {
            if (dataGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "CSV (*.csv)|*.csv",
                    FileName = $"{this.filename}.csv"
                };
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
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            string csv = "";
                            int columns = dataGridView.Columns.Count;
                            int i = 0;

                            foreach (DataGridViewColumn column in dataGridView.Columns)
                            {
                                if (i == ((columns) - 1))
                                    csv += column.HeaderText;
                                else
                                    csv += column.HeaderText + ";";

                                i++;
                            }
                            csv += "\n";

                            i = 0;

                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (i == ((columns) - 1))
                                        csv += cell.Value.ToString();
                                    else
                                        csv += cell.Value.ToString() + ";";

                                    i++;


                                }
                                csv += "\n";
                            }

                            using (StreamWriter stream = new StreamWriter(sfd.FileName))
                            {
                                stream.Write(csv);
                                stream.Close();
                            }

                            MessageBox.Show("Plik zapisany pomyślnie", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie ma żadnych danych w tabeli!", "Info");
            }
        }


            public void PrintPDF()
        {



            if (dataGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = $"{this.filename}.pdf"
                };
                
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
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
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

                            MessageBox.Show("Plik zapisany pomyślnie", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie ma żadnych danych w tabeli!", "Info");
            }

        }

    }
}
