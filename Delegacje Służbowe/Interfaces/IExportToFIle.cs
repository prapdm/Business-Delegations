using System;
using System.Windows.Forms;

namespace Delegations
{
    public interface IExportToFIle
    {
        Boolean Save(DataGridView dataGridView, string filename);
    }
}
