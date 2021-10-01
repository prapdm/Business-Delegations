using System;

namespace Delegations
{
    interface IAutentication
    {
        Boolean Login(string login, string password);
        int GetID();
    }
}
