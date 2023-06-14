using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandSystem;
using Exiled.Permissions.Extensions;
using RemoteAdmin;

namespace MunbowLFGPlugin.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class NuttinWithTheLightsOutDisabled : ICommand
    {

        private Handlers.player Player;
        public Handlers.NWTLOServer Server;
        

        public string Command { get; } = "DisableNWTLO";

        public string[] Aliases { get; } = { "DisableNWTLO" };

        public string Description { get; } = "Disables The Nutting With The Lights Out Gamemode";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender player && !sender.CheckPermission("owner"))
            {
                response = "You Have Disabled The Nutting With The Lights Out Gamemode";

                Player = new Handlers.player();
                Server = new Handlers.NWTLOServer();

                 

                

                return true;


            }
            else
            {
                response = "Someone Is Trying To Disable Nutting With The Lights Out";
                return false;
            }
        }
    }
}
