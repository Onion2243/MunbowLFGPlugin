using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using player = Exiled.Events.Handlers.Player;
using Items = Exiled.Events.Handlers.Item;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Server;

namespace MunbowLFGPlugin.Handlers
{
    class player
    {
        public void OnLeft(LeftEventArgs ev)
        {
            Map.Broadcast(15, $"{ev.Player} Has Left The Server");
        }

        public void OnJoined(JoinedEventArgs ev)
        {
            Log.Info("Something Is Happening");
            Map.Broadcast(15, $"{ev.Player} Has Joined The Server");
        }

        public void InteractingWithADoor(InteractingDoorEventArgs ev)
        {
            ev.Player.DropHeldItem();
        }
    }
}