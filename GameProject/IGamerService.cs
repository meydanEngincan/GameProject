using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface IGamerService
    {
        void GamerAdd(Gamer gamer);
        void GamerDelete(Gamer gamer);
        void GamerUpdate(Gamer gamer);
    }
}
