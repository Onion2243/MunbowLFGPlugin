﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandSystem;
using RemoteAdmin;
using Exiled.Permissions.Extensions;
using Exiled.API.Features.Items;




namespace MunbowLFGPlugin.Commands
{
    
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class NuttinWithTheLightsOutEnable : ICommand
    {

        private Handlers.player Player;
        private Handlers.NWTLOServer NWTLOServer;
        public static MunbowLFGPlugin Instance;

        public MunbowLFGPlugin mainplugin;
        
        public string Command { get; } = "EnableNWTLO";

        public string[] Aliases { get; } = { "EnableNWTLO" } ;

        public string Description { get; } = "Enables The Nutting With The Lights Out Gamemode";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {

            mainplugin = new MunbowLFGPlugin();
            
            if (sender is PlayerCommandSender player && !sender.CheckPermission("owner"))
            {
                response = "Nutting With The Lights Out Gamemode Has Been Enabled";

                Player = new Handlers.player();
                NWTLOServer = new Handlers.NWTLOServer();
                mainplugin.IsNWTLOEnabled = true;
                
                return true;

            }
            else
            {
                response = $"Someone Is Trying To Enable Nutting With The Lights Out";
                return false;
            }


        }
    }
}
