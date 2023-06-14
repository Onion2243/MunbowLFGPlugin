using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Server;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Scp173;
using Player = Exiled.Events.Handlers.Player;
using Items = Exiled.Events.Handlers.Item;
using Player1 = Exiled.API.Features.Player;
using Item = Exiled.API.Features.Items;

namespace MunbowLFGPlugin.Handlers
{

    class NWTLOServer
    {
        public MunbowLFGPlugin mainplugin;
        

        public static NWTLOServer Instance;
        Random rd = new Random();
       public void OnRoundStarted()
        {
            mainplugin = new MunbowLFGPlugin();
            if(mainplugin.IsNWTLOEnabled == true)
            {
                
                foreach (Player1 player in Player1.List)
                {
                    player.Role.Set(PlayerRoles.RoleTypeId.ClassD);
                    player.AddItem(ItemType.Flashlight);
                    Map.TurnOffAllLights(9999, Exiled.API.Enums.ZoneType.LightContainment);
                    
                    
                }
            }
            
        }
    }
}
