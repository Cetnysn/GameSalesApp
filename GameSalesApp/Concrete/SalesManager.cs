using GameSalesApp.Abstract;
using GameSalesApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesApp.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sale(User user, Game game)
        {
            Console.WriteLine("Sayın: " + user.FirstName + " " + user.LastName + " "+ game.GameName + " " + "Oyununu bizden satın aldığınız için teşekkür ederiz " + "\n"  + "Ücret: " + game.GamePrice);
        }
    }
}
