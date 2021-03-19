using GameSalesApp.Abstract;
using GameSalesApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesApp.Concrete
{
    public class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("Oyun" + game.GameName + " " + "Mağaza'ya eklendi.");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine("Oyun" + game.GameName + " " + "Mağaza'dan kaldırıldı.");
        }
    }
}
