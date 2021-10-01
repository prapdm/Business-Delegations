using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Delegations
{
    public interface IExportToFIle
    {
        Boolean Save(DataGridView dataGridView, string filename);
    }
}
