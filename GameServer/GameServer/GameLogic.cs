using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    class GameLogic
    {

        public static void Update()
        {
            ServerThreadManager.UpdateMain();
        }
    }
}
