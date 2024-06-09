using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RacingCar_Server
{
     public class Player
    {
        public string name { get; set; }
        public Socket playerSocket { get; set; }

    }

}
