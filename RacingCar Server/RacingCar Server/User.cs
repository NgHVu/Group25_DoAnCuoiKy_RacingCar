using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingCar_Server
{
    struct User
    {
        //User instance
        public Player player;
        //whether the game has started
        public bool started;
        // is there anyone sitting down
        public bool someone;
    }
}
