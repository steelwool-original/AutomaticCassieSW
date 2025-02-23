using System;
using CommandSystem;
using RemoteAdmin;
using Exiled.API.Features;
using UnityEngine.Scripting;

namespace AutomaticCassie.PassiveCassie.AlphaWarhead
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class AlphaWarheadDamagedCassie : ICommand
    {
        public string Command { get; } = "Alpha-Warhead-Damaged";

        public string[] Aliases { get; } = new[] { "AWDamage" };

        public string Description { get; } = "Cassie informujące o uszkodzeniu głowicy Alpha Warhead";



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                Cassie.MessageTranslated("pitch_0.2 .g4 . .g4 pitch_1 Warning . alpha pitch_0.93 jam_72_5 warhead jam_027_4 has been damaged in 10 percent . Evacuate immediately", "<color=#FF0000>Uwaga</color>, głowica Alpha Warhead została uszkodzona w 10%, Ewakuować się natychmiastowo!", isNoisy: false);
                response = "Komenda wysłana pomyślnie";
                return true;
            }
            else
            {
                response = "InvalidRemoteAdminExpection";
                return false;
            }
        }
    }

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class AlphaWarheadUnauthorizedCassie : ICommand
    {
        public string Command { get; } = "Alpha-Warhead-Unauthorized";

        public string[] Aliases { get; } = new[] { "AWUnauthorized" };

        public string Description { get; } = "Cassie informujące o nie-autoryzowanym personelu w głowicy Alpha Warhead";



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                Cassie.MessageTranslated("pitch_0.3 .g4 . .g4 . .g4 pitch_1 jam_01_3 danger . pitch_0.7 not authorized pitch_0.9 personnel pitch_1 detected in pitch_0.8 heavy containment pitch_1 jam_7_3 warhead . pitch_0.8 .g4 . .g4 . .g4 . ", "<color=#FF0000>Niebezpieczeństwo</color>, Wykryto nieautoryzowany personel w strefie głowicy Heavy Containment Zone.", isNoisy: false);
                response = "Komenda wysłana pomyślnie";
                return true;
            }
            else
            {
                response = "InvalidRemoteAdminExpection";
                return false;
            }
        }
    }

}
