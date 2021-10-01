using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Delegations
{
    class ExportToFile
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

        public void Save()
        {
            dataSaver.Save(this.dataGridView, this.filename);
        }

    }
}
