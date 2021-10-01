using System.Windows.Forms;

namespace Delegations
{
    class WarningBox : ILoger
    {

        public string Write(string msg)
        {
            var result = MessageBox.Show(msg, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result.ToString();
        }
    }
}
