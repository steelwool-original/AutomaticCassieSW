using System;
using CommandSystem;
using RemoteAdmin;
using Exiled.API.Features;

namespace AutomaticCassie.PassiveCassie
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class CassieSCP106Heavy : ICommand
    {
        public string Command { get; } = "Cassie-SCP106-Heavy";

        public string[] Aliases { get; } = new[] { "106Hcz", "106Heavy" };

        public string Description { get; } = "Cassie informujące o SCP-106 w Heavy Containment";



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                Cassie.MessageTranslated("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning .g1 .g1 to all jam_30_3 Personnel . . SCP 1 0 6 Detected jam_027_4 .g5 in Pitch_0.9 Heavy Containment pitch_0.6 .g4", "Uwaga do całego Personelu . . Aktywność podmiotu <color=#FF0000>SCP 106</color> została wykryta w Strefie Wyższego Nadzoru.", isNoisy: false);
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
    class CassieSCP106Light : ICommand
    {
        public string Command { get; } = "Cassie-SCP106-Entrance";

        public string[] Aliases { get; } = new[] { "106Ecz", "106Entrance" };

        public string Description { get; } = "Cassie informujące o SCP-106 w Entrance Zone";


        // Z tym nic nie rób
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning .g1 .g1 to all jam_30_3 Personnel . . SCP 1 0 6 Detected jam_027_4 .g5 in Pitch_0.9 Light Containment pitch_0.6 .g4", " Uwaga do całego Personelu . . Aktywność podmiotu <color=#FF0000>SCP 106</color> została wykryta w Strefie Niższego Nadzoru.", isNoisy: false);
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
    class SCP106Entrance : ICommand
    {
        public string Command { get; } = "Cassie-SCP106-Light";

        public string[] Aliases { get; } = new[] { "106Lcz", "106Light" };

        public string Description { get; } = "Cassie informujące o SCP-106 w Light Containment Zone";


        // Z tym nic nie rób
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning .g1 .g1 to all jam_30_3 Personnel . . SCP 1 0 6 Detected jam_027_4 .g5 in Pitch_0.9 Light Containment Zone pitch_0.6 .g4", "Uwaga do całego Personelu . . Aktywność podmiotu <color=#FF0000>SCP 106</color> została wykryta w Strefie Niższego Nadzoru.", isNoisy: false);
                return true;
            }
            else
            {
                response = "InvalidRemoteAdminExepction";
                return false;
            }
        }



    }

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class SCP106Secured : ICommand
    {
        public string Command { get; } = "Cassie-SCP106-Secured";

        public string[] Aliases { get; } = new[] { "SCP106-S", "106Secured" };

        public string Description { get; } = "Puszcza Cassie o zabezpieczeniu SCP-106.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated(".g4 .g4 SCP 1 0 6 jam_030_2 contained successfully by .g6 MTFunits .g5", "<color=#FF0000>SCP-106</color> został skutecznie zabezpieczony przez jednostki <color=#ADD8E6>MFO</color>", isNoisy: false);
                return true;
            }
            else
            {
                response = "InvalidRemoteAdminExepction";
                return false;
            }
        }


    }
}
