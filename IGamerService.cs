using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    interface IGamerService
    {
        public void SıgnIn(Gamer gamer);
        public void Delete(Gamer gamer);
        public void Update(Gamer gamer);
    }
}
