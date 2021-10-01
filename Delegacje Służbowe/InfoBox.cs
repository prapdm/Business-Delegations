using System.Windows.Forms;

namespace Delegations
{
    public class InfoBox : ILoger
    {
        public string Write(string msg)
        {
           var results = MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           return results.ToString();
        }
    }
}
