using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    class Authorization
    {
        static public Profile Auth(string login, string password)
        {
            //var data = DatabaseOperations.PushQuery(DatabaseOperations.SingleConnection(),
            //    $"SELECT Id, Surname, Name, System_role FROM Profiles WHERE Profile_login = \'{login}\' AND Profile_password = \'{password}\'");
            using (var db = new BarcodesEntities())
            {
                var data = db.Profiles.Where(p => p.ProfileLogin == login && p.ProfilePassword == password).ToList().FirstOrDefault();
                if (data != null)
                    return ProfileCreator.GetProfile(data.Id, data.Surname, data.Name, data.SystemRole);
                return null;
            }
        }
    }
}
