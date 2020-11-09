using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    class User : Profile
    {
        static private User user;

        private User(int id, string surname, string name, string role)
        {
            this.Id = id;
            this.Surname = surname;
            this.Name = name;
            this.Role = role;
        }

        static public User SingleUser(int id, string surname, string name, string role)
        {
            if (user == null) user = new User(id, surname, name, role);
            return user;
        }

        public override string ToString()
        {
            return $"{Surname} {Name} {Role}";
        }
    }
}
