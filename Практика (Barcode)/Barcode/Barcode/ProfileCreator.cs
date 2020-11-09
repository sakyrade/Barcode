using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    abstract class ProfileCreator
    {
        static public Profile GetProfile(int id, string surname, string name, string role)
        {
            if (role == "User") return User.SingleUser(id, surname, name, role);
            else if (role == "Admin") return Admin.SingleAdmin(id, surname, name, role);
            else throw new FormatException();
        }
    }
}
