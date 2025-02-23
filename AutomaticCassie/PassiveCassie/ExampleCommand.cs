using System;
using CommandSystem;
using Exiled.API.Features;
using RemoteAdmin;

namespace AutomaticCassie.PassiveCassie
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))] // ClientCommandHandler jeżeli komenda ma być na Konsolę
    class ExampleCommand : ICommand // Nazwa Komendy, Np "class ChaosInsurgencyForveWave : ICommand" 
    {
        public string Command { get; } = "ListaKomend"; // Komenda np = "SummonCiSUV";

        public string[] Aliases { get; } = new[] {"CmdLst", "SWList"}; // Aliasy komendy, czyli skrót komendy, pisać w {""} i przecinek po każdym aliasie, np =  new[] {"cicar, summonci, ciwave"}

        public string Description { get; } = "Lista dostępnych komend w pluginie AutomaticCassieSW"; // Opis Komendy, np = "This command summons Chaos Insurgency";


        // Z tym nic nie rób
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender) 
            {
                response = "\"Alpha-Warhead-Damaged\",\"AWDamage\",\"Alpha-Warhead-Unauthorized\",\"AWUnauthorized\",\"Cassie-Alpha1-Enter\",\"C-A1-E\",\"Cassie-HammerDown-Enter\",\"C-Nu7-E\",\"Cassie-Omega1-Enter\",\"C-O1-E\",\"Cassie-O5-Warhead-Detonation\", \"C-W-D\",\"Cassie-SCP049-Heavy\",\"049Hcz\", \"049Heavy\",\"Cassie-SCP049-Entrance\",\"049Ecz\", \"049Entrance\", \"Cassie-SCP049-Light\",\"049Lcz\", \"049Light\",\"Cassie-SCP049-Secured\",\"SCP049-S\", \"049Secured\",\"Cassie-SCP082-EntranceZone\",\"SCP082-EZ\", \"082Entrance\",\"Cassie-SCP082-LightContainment\",\"SCP082-LC\", \"082Light\",\"Cassie-SCP082-HeavyContainment\",\"SCP082-HCZ\", \"082Heavy\"\"Cassie-SCP082-Secured\",\"SCP082-S\", \"082Secured\",\"Cassie-SCP082-TerminationMTF\",\"SCP082-TMTF\",\"Cassie-SCP082-TerminationP\",\"SCP082-TP\",\"Cassie-SCP106-Heavy\", \"106Hcz\", \"106Heavy\",\"Cassie-SCP106-Entrance\",\"106Ecz\", \"106Entrance\",\"Cassie-SCP106-Light\", \"106Lcz\", \"106Light\",\"Cassie-SCP106-Secured\",\"SCP106-S\", \"106Secured\",\"Cassie-SCP173-LightContainment\",\"SCP173-LC\", \"173Light\",\"Cassie-SCP173-HeavyContainment\",\"SCP173-HC\", \"173Heavy\",\"Cassie-SCP173-EntranceZone\",\"SCP173-EZ\", \"173Entrance\",\"Cassie-SCP173-Secured\",\"SCP173-S\", \"173Secured\",\"Cassie-SCP939-Heavy\",\"939Hcz\", \"939Heavy\",\"Cassie-SCP939-Entrance\",\"939Ecz\", \"939Entrance\",\"Cassie-SCP939-Light\",\"939Lcz\", \"939Light\",\"Cassie-SCP939-Secured\",\"SCP939-S\", \"939Secured\",\"Cassie-SCP096-Heavy\",\"096Hcz\", \"096Heavy\",\"Cassie-SCP096-Entrance\",\"096Ecz\", \"096Entrance\",\"Cassie-SCP096-Light\",\"096Lcz\", \"096Light\", \"Cassie-SCP096-Secured\",\"SCP096-S\", \"096Secured\",\"MTFContraband\",\"MFOContraband\",\"IntrudersLCZ\",\"IntrudersLight\",\"IntrudersHCZ\",\"IntrudersHeavy\",\"IntrudersEZ\",\"IntrudersEntrance\",\"MTFEscort\",\"EscordPer\", \"MTFgotoHeavy\",\"gotoHCZ\", \"MTFgotoLight\",\"gotoLCZ\" ,\"MTFgotoEntrance\",\"gotoEZ\",\"Class-D-Riot\",\"dRiot\", \"All-ClassD-Termination\", \"dTermination\", \"All-ClassD-Terminated\",\"dTerminated\",\"Class-D-tCancel\",\"cdtCancel\",\"C-Kod-Pomaranczowy\",\"kod-pomaranczowy\",\"Cassie-kod-czarny\",\"kod-czarny\",\"Cassie-Kod-Zielony\",\"kod-zielony\"";
                return true;
            }
            else 
            {
                response = "InvalidRemoteAdminException";
                return false;
            }
        }

    }
}
