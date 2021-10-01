using System;
using System.Collections.Generic;
using System.Text;

namespace Delegations
{
    interface IAutentication
    {
        Boolean Login(string login, string password);
        int GetID();
    }
}
