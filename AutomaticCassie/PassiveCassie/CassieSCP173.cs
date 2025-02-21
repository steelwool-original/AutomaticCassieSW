using System;
using CommandSystem;
using Exiled.API.Features;
using RemoteAdmin;

namespace AutomaticCassie.PassiveCassie
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class SCP173LightContainment : ICommand
    {
        public string Command { get; } = "Cassie-SCP173-LightContainment";

        public string[] Aliases { get; } = new[] { "SCP173-LC", "173Light" };

        public string Description { get; } = "Puszcza Cassie o wykryciu SCP-173 w Strefie Lekkiego Przechowywania.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender) 
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("cassie_sl pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . SCP 1 7 3 Detected jam_027_4 .g5 in Pitch_0.9 Light Containment pitch_0.6 .g4", "Uwaga, <color=#FF0000>SCP-173</color> został wykryty w Strefie Lekkiego Przechowywania", isNoisy:false);
                return true;
            }
            else 
            {
                response = "InvalidRemoteAdminExepction";
                return false;
            }
        }

        /*
         Cassie:
         cassie_sl pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . SCP 1 7 3 Detected jam_027_4 .g5 in Pitch_0.9 Light Containment pitch_0.6 .g4
         Spolszczenie: Uwaga, SCP-173 został wykryty w Strefie Lekkiego Przechowywania
         Wygląd: SCP-173 na czerwono
        */
    }


    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class SCP173HeavyContainment : ICommand
    {
        public string Command { get; } = "Cassie-SCP173-HeavyContainment";

        public string[] Aliases { get; } = new[] { "SCP173-HC", "173Heavy" };

        public string Description { get; } = "Puszcza Cassie o wykryciu SCP-173 w Strefie Ciężkiego Przechowywania.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender) 
            {
                response = "Pomyślnie wysłano komende";
                Cassie.MessageTranslated("cassie_sl pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . SCP 1 7 3 Detected jam_027_4 .g5 in Pitch_0.9 Heavy Containment pitch_0.6 .g4", "Uwaga, <color=#FF0000>SCP-173</color> został wykryty w Strefie Wyższego Przechowywania", isNoisy:false);
                return false;
            }
            else 
            {
                response = "InvalidRemoteAdminExepction";
                return false;
            }
        }

        /*
         Cassie:
         cassie_sl pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . SCP 1 7 3 Detected jam_027_4 .g5 in Pitch_0.9 Heavy Containment pitch_0.6 .g4
         Spolszczenie: Uwaga, SCP-173 został wykryty w Strefie Wyższego Przechowywania
         Wygląd: SCP-173 na czerwono
        */



    }


    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class SCP173EntranceZone : ICommand
    {
        public string Command { get; } = "Cassie-SCP173-EntranceZone";

        public string[] Aliases { get; } = new[] { "SCP173-EZ", "173Entrance" };

        public string Description { get; } = "Puszcza Cassie o wykryciu SCP-173 w Strefie Wejściowej.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Pomyślnie wysłano komende";
                Cassie.MessageTranslated("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . SCP 1 7 3 Detected jam_027_4 .g5 in Pitch_0.9 Entrance Zone pitch_0.6 .g4", "Uwaga, Wykryto <color=#FF0000>SCP-173</color> w Strefie Wejściowej", isNoisy: false);
                return false;
            }
            else
            {
                response = "InvalidRemoteAdminExepction";
                return false;
            }
        }

        /*
         Cassie:
         cassie_sl pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . SCP 1 7 3 Detected jam_027_4 .g5 in Pitch_0.9 Entrance Zone pitch_0.6 .g4
         Spolszczenie: Uwaga, Wykryto SCP-173 w Strefie Wejściowej
         Wygląd: SCP-173 na czerwono
        */

    }


    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class SCP173Secured : ICommand
    {
        public string Command { get; } = "Cassie-SCP173-Secured";

        public string[] Aliases { get; } = new[] { "SCP173-S", "173Secured" };

        public string Description { get; } = "Puszcza Cassie o zabezpieczeniu SCP-173.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Pomyślnie wysłano komende";
                Cassie.MessageTranslated(".g4 .g4 SCP 1 7 3 jam_030_2 contained successfully by .g6 MTFunits .g5", "<color=#FF0000>SCP-173</color> został skutecznie zabezpieczony przez jednostki <color=#ADD8E6>MFO</color>", isNoisy: false);
                return false;
            }
            else
            {
                response = "InvalidRemoteAdminExepction";
                return false;
            }
        }

        /*
         Cassie:
         cassie_sl .g4 .g4 SCP 1 7 3 jam_030_2 contained successfully by .g6 MTFunits .g5
         Spolszczenie: SCP-173 został skutecznie zabezpieczony przez jednostki MFO
         Wygląd: SCP-173 na czerwono, MFO na niebiesko
        */



    }

}