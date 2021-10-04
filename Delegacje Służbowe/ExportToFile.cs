using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Delegations
{
    public class ExportToFile
    {
        private readonly DataGridView dataGridView;
        private readonly string filename;
        private readonly IExportToFIle dataSaver;

        public ExportToFile(DataGridView dataGridView, string filename, IExportToFIle dataSaver)
        {
            this.dataGridView = dataGridView;
            this.filename = filename;
            this.dataSaver = dataSaver;
        }

        public Boolean Save()
        {
            return dataSaver.Save(this.dataGridView, this.filename);
        }

    }
}
