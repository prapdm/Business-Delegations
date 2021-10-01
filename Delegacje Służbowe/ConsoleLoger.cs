using System.Diagnostics;

namespace Delegations
{
    class ConsoleLoger : ILoger
    {
        public string  Write(string msg)
        {
            Debug.WriteLine(msg);
            return msg;
        }
    }
}
