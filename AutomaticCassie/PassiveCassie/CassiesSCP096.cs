using System;
using CommandSystem;
using RemoteAdmin;
using Exiled.API.Features;

namespace AutomaticCassie.PassiveCassie
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class CassieSCP096Heavy : ICommand
    {
        public string Command { get; } = "Cassie-SCP096-Heavy";

        public string[] Aliases { get; } = new[] { "096Hcz", "096Heavy" };

        public string Description { get; } = "Cassie informujące o SCP-096 w Heavy Containment";



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                Cassie.MessageTranslated("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning .g1 .g1 to all jam_30_3 Personnel . . SCP 0 9 6 Detected jam_027_4 .g5 in Pitch_0.9 Heavy Containment pitch_0.6 .g4", "Uwaga do całego Personelu . . Aktywność podmiotu <color=#FF0000>SCP 096</color> została wykryta w Strefie Wyższego Nadzoru.", isNoisy: false);
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
    class CassieSCP096Light : ICommand
    {
        public string Command { get; } = "Cassie-SCP096-Entrance";

        public string[] Aliases { get; } = new[] { "096Ecz", "096Entrance" };

        public string Description { get; } = "Cassie informujące o SCP-096 w Entrance Zone";


        // Z tym nic nie rób
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning .g1 .g1 to all jam_30_3 Personnel . . SCP 0 9 6 Detected jam_027_4 .g5 in Pitch_0.9 Light Containment pitch_0.6 .g4", " Uwaga do całego Personelu . . Aktywność podmiotu <color=#FF0000>SCP 096</color> została wykryta w Strefie Niższego Nadzoru.", isNoisy: false);
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
    class SCP096Entrance : ICommand
    {
        public string Command { get; } = "Cassie-SCP096-Light";

        public string[] Aliases { get; } = new[] { "096Lcz", "096Light" };

        public string Description { get; } = "Cassie informujące o SCP-096 w Light Containment Zone";


        // Z tym nic nie rób
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning .g1 .g1 to all jam_30_3 Personnel . . SCP 0 9 6 Detected jam_027_4 .g5 in Pitch_0.9 Light Containment Zone pitch_0.6 .g4", "Uwaga do całego Personelu . . Aktywność podmiotu <color=#FF0000>SCP 096</color> została wykryta w Strefie Niższego Nadzoru.", isNoisy: false);
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
    class SCP096Secured : ICommand
    {
        public string Command { get; } = "Cassie-SCP096-Secured";

        public string[] Aliases { get; } = new[] { "SCP096-S", "096Secured" };

        public string Description { get; } = "Puszcza Cassie o zabezpieczeniu SCP-096.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated(".g4 .g4 SCP 0 9 6 jam_030_2 contained successfully by .g6 MTFunits .g5", "<color=#FF0000>SCP-096</color> został skutecznie zabezpieczony przez jednostki <color=#ADD8E6>MFO</color>", isNoisy: false);
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
