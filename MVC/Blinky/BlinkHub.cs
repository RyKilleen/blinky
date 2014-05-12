using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Blinky
{
    public class BlinkHub : Hub
    {
        public void isPushed()
        {
            Clients.All.isPushed();
        }

        public void isReleased()
        {
            Clients.All.isReleased();
        }
    }
}