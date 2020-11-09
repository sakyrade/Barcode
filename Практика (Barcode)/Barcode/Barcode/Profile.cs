using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    public abstract class Profile
    {
        protected int Id { get; set; }
        protected string Surname { get; set; }
        protected string Name { get; set; }
        protected string Role { get; set; }
    }
}
