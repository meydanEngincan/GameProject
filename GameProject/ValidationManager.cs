using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class ValidationManager : IValidationService
    {
       
        public bool Validation(Gamer gamer)
        {
            if (gamer.BirthYear == 1995 && gamer.FirstName == "ENGİN CAN" && gamer.LastName == "MEYDAN" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
                return false;
        }
    }
}
