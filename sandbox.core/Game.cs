using System;
using System.Collections.Generic;
using System.Text;

namespace sandbox.core
{
    public class Game
    {
        public int ID { get; set; }
        public List<Player> Players;
        public List<Card> Cards;
        public State GameState;

        public Game()
        { Players = new List<Player>();
            Cards = new List<Card>();
            ID = 1;
            GameState = State.Calc;
        }

        public DateTime GameTime { get; set; }
    }
}
