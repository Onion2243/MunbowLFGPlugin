using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using player = Exiled.Events.Handlers.Player;
using server = Exiled.Events.Handlers.Server;
using Exiled;

namespace MunbowLFGPlugin
{
    public sealed class MunbowLFGPlugin : Plugin<Config>
    {
        private Handlers.player Player;
        private Handlers.NWTLOServer Server;
        public static MunbowLFGPlugin Instance;

        public static object NWTLOServer { get; internal set; }

        public override void OnEnabled()
        {
            base.OnEnabled();
            RegisterEvents();
            Instance = this;
            MunbowLFGPlugin.Instance.Server.IsNWTLOEnabled = true;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            UnRegisterEvents();
            Instance = null;
        }

        public void RegisterEvents()
        {
            Player = new Handlers.player();
            Server = new Handlers.NWTLOServer();

   
        }

        public void UnRegisterEvents()
        {
            Player = new Handlers.player();
            Server = new Handlers.NWTLOServer();

            

        }
    }
}
