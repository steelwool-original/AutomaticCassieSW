using System;
using CommandSystem;
using RemoteAdmin;

using CassieHandler = Exiled.API.Features.Cassie;

namespace AutomaticCassie.PassiveCassie
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class CassieO5WarheadDetonation : ICommand
    {
        public string Command { get; } = "Cassie-O5-Warhead-Detonation"; 

        public string[] Aliases { get; } = new[] { "" }; 

        public string Description { get; } = "Puszcza Cassie o detonacji głowicy z polecenia rady O5"; 
        


        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {

            if (sender is PlayerCommandSender) 
            {

                response = "Cassie activated!";
                CassieHandler.MessageTranslated("cassie_sl pitch_0.1 .g4 . .g4 pitch_0.9 Warning . . pitch_0.8 Warning . facility status is critical .g1 . detonation jam_044_2 center .g2  jam_044_2  decided that site 0 2 is designated .g6 for jam_044_2  detonation .g2 with Alpha Warhead . please evacuate immediately . MtfUnits evacuate to surface .g1 zone and secure elevators . jam_044_2  detonation sequence .g3 will be jam_044_2  initiated in 30 seconds . emergency jam_044_2  generators will be initiated in 3 . . 2 . . 1 . .G1 .G3 .G2", "<color=#FF0000>Uwaga</color> do całego personelu, Status <color=#ADD8E6>Placówki</color> jest <color=#FF0000>krytyczny</color> Centrum Detonacji zadecydowało o detonacji <color=#ADD8E6>Ośrodka-02</color>. Zadaniem całego personelu jest ewakuacja na strefę zewnętrzną wraz z Mobilnymi Formacjami Operacyjnymi. E-11 zabezpieczcie windy surface zone Sekwencja detonacji rozpocznie się za 30 sekund, Awaryjne generatory zostaną uruchomione za 3.. 2.. 1..");
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
