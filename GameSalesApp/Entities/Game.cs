﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesApp.Entities
{
    public class Game: IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GamePrice { get; set; }
    }
}
