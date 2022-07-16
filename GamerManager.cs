using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class GamerManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" Silindi!");
        }

        public void SıgnIn(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" Kayıt oldu!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" Güncellendi");
        }
    }
}
