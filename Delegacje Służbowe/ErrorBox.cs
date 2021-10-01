using System.Windows.Forms;

namespace Delegations
{
    public class ErrorBox : ILoger
    {
        public string Write(string msg)
        {
            var result = MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return result.ToString();
        }
    }
}
