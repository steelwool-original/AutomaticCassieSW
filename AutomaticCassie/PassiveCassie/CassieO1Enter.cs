using System;
using CommandSystem;
using RemoteAdmin;
using Exiled.API.Features;

namespace AutomaticCassie.PassiveCassie
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class CassieO1Enter : ICommand
    {
        public string Command { get; } = "Cassie-Omega1-Enter";

        public string[] Aliases { get; } = new[] { "C-O1-E" };

        public string Description { get; } = "Cassie informujące o wkroczeniu MFO Law's Left Hand do placówki";


        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("bell_start pitch_0.80 Alert . .G1 Alert .g5 .g3 pitch_0.8 MTFunit Omega 1 has jam_080_6 entered the Facility through Gate jam_070_1 B . . . Command to all remaining personnel .g4 .g3 . .g1 execute orders from MTFunit Omega 1 or you will be arrested . .g3 .g4 . jam_060_4 Omega 1 will leave the facility after they reach their .g1 target pitch_0.1 .g3 .g4 .g6 bell_end", "<color=#FF0000>Uwaga</color>, <color=#FF0000>Uwaga</color>! Jednostka <color=#ADD8E6>MTF</color> Omega-1 wkroczyła do placówki przez Bramę B. Komenda do całego pozostałego personelu: Bezwzględnie podporządkować się poleceniom jednostki Omega-1, w przeciwnym razie grozi <color=#FF0000>aresztowanie</color>. Omega-1 opuści placówkę po osiągnięciu celu.", isNoisy: false);
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
