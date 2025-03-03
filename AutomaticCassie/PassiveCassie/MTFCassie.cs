using System;
using CommandSystem;
using RemoteAdmin;
using Exiled.API.Features;

namespace AutomaticCassie.PassiveCassie
{

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class CassieMTFContraband : ICommand
    {
        public string Command { get; } = "MTFContraband";

        public string[] Aliases { get; } = new[] { "" };

        public string Description { get; } = "Cassie informujące o kontrabandzie MFO";



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                Cassie.MessageTranslated("pitch_0.9 MTFunits .g2 central to all security guards . jam_10_2 pitch_0.95 . jam_44_3 Corruption Detected In MTFUnit Personnel . pitch_0.89 jam_50_4 .g4 If you see any not .g6 normal activity .g2 jam_044_2 arrest that person immediately .g6", "Jednostka <color=#ADD8E6>MTF</color>, Centrala do wszystkich Ochroniarzy. Wykryto korupcję w jednostce <color=#ADD8E6>MTF</color>. Jeśli zostanie zauważona jakakolwiek nietypowa lub podejrzana aktywność, proszę natychmiast <color=#FF0000>aresztować</color> podejrzanego.", isNoisy: false);
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
    class CassieMTFEscord : ICommand
    {
        public string Command { get; } = "MTFEscort";

        public string[] Aliases { get; } = new[] { "EscordPer" };

        public string Description { get; } = "Cassie informujące o autoryzacji eskorty personelu";



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                Cassie.MessageTranslated("MTFunits central to ninetailedfox . secure all personnel . over", "Centrala <color=#ADD8E6MTF</color>, do <color=#FFA500>Nine Tailed Fox</color>, Eskortować cały personnel", isNoisy: false);
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
