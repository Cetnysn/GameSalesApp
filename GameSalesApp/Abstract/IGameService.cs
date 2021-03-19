using GameSalesApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesApp.Abstract
{
    public interface IGameService
    {
        void AddGame(Game game);
        void DeleteGame(Game game);
    }
}
