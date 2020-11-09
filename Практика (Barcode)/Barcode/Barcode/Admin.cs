using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    class Admin : Profile
    {
        static private Admin admin;
        private Admin(int id, string surname, string name, string role)
        {
            this.Id = id;
            this.Surname = surname;
            this.Name = name;
            this.Role = role;
        }
        static public Admin SingleAdmin(int id, string surname, string name, string role)
        {
            if (admin == null) admin = new Admin(id, surname, name, role);
            return admin;
        }
    }
}
