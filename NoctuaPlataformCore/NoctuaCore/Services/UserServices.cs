using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoctuaCore.Services
{
    class UserServices
    {
        public bool isValid(User user) {

            if (user.Nome != null && user.Sobrenome != null &&
                user.DtNasc != null && user.Email != null && user.Password != null)
            {

                return true;

            }
            else return false;

        }
    }
}
