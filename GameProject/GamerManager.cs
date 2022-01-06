using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IValidationService _validationService;

        public GamerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public void GamerAdd(Gamer gamer)
        {
            if (_validationService.Validation(gamer) == true)
            {
                Console.WriteLine("Gamer added from system.");
            }
            else
                Console.WriteLine("Wrong...!!!");
        }

        public void GamerDelete(Gamer gamer)
        {
            if (_validationService.Validation(gamer) == true)
            {
                Console.WriteLine("Gamer deleted from system.");
            }
            else
                Console.WriteLine("Wrong...!!!");
        }

        public void GamerUpdate(Gamer gamer)
        {
            if (_validationService.Validation(gamer) == true)
            {
                Console.WriteLine("Gamer updated from system.");
            }
            else
                Console.WriteLine("Wrong...!!!");
        }
    }
}
