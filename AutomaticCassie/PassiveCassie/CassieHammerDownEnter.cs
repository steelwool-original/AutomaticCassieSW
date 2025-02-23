using System;
using CommandSystem;
using RemoteAdmin;
using Exiled.API.Features;

namespace AutomaticCassie.PassiveCassie
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class CassieHammerDownEnter : ICommand
    {
        public string Command { get; } = "Cassie-HammerDown-Enter";

        public string[] Aliases { get; } = new[] { "C-Nu7-E" };

        public string Description { get; } = "Cassie informujące o wkroczeniu MFO Hammer Down do placówki";


        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("bell_start pitch_0.80 Alert . .g1 Alert .g5 .g3 pitch_0.90 MTFunit Nu 7 jam_080_6 has entered the Facility through Gate jam_070_1 B . Any activity jam_050_2 against MTFunit .g3 Nu 7 will be .g1 jam_070_4 stopped by termination if needed .g3 .g4 . MTFunit .g2 Nu 7 will stay in .g1 Site 0 2 until this Facility will be safe .g4 .g5 .g6 bell_end", "<color=#FF0000>Ogłoszenie</color>: Jednostka <color=#ADD8E6>MTF</color> <color=#73ad71>Nu-7</color> wkroczyła do placówki przez bramę B. Wszystkie działania sprzeczne z protokołami jednostki <color=#ADD8E6>MTF</color> zostaną natychmiast zatrzymane, a w razie potrzeby, także przez terminację. Jednostka <color=#73ad71>Nu-7</color> będzie utrzymywać obecność w placówce, aż do momentu zapewnienia pełnego bezpieczeństwa obiektu.", isNoisy: false);
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
