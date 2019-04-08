using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9944848_consoleRegistrationForm
{
    class Validatepass
    {
        public static string Passconfirm(string pass1, string pass2)
        {
            if (pass1 == pass2)
            {
                return "Password was set";
            }
            else
            {
                return "Password dosen't match";
            }

        }
    }
}


