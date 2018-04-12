﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peril.Models;
using Peril.Types;

namespace Peril.Models
{
    class PerilGameStateModel
    {

        public List<Player> Players { get; set; }

        public Types.Battle ActiveBattle { get; set; }

        public int Phase { get; set; }

        public Dictionary<int, Types.Territory> Territories { get; set; }

        public List<int> TurnOrder { get; set; }

        public int PowerRate { get; set; }

        public int CurrentTurn { get; set; }

        public string Victor { get; set; }


        public PerilGameStateModel()
        {
            // unpack curTurn gameState JSON into holder object
        }
    }
}
