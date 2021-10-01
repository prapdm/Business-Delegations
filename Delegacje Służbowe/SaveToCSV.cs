using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Delegations 
{
    class SaveToCSV : IExportToFIle
    {
        private readonly WarningBox warning = new WarningBox();
        private readonly InfoBox info = new InfoBox();


        public Boolean Save(DataGridView dataGridView, string filename)
        {

            if (dataGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "CSV (*.csv)|*.csv",
                    FileName = $"{filename}.csv"
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

                            info.Write("Plik zapisany pomyślnie" );
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
