using System;
using System.Collections.Generic;
using System.Text;

namespace sandbox.core
{
    public class GameHistory
    {
        public int ID { get; set; }
        public ICollection<Game> GameHistor;

    }
}
