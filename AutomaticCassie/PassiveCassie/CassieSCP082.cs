using System;
using CommandSystem;
using Exiled.API.Features;
using RemoteAdmin;

[CommandHandler(typeof(RemoteAdminCommandHandler))]
class SCP082EntranceZone : ICommand
{
    public string Command { get; } = "Cassie-SCP082-EntranceZone";

    public string[] Aliases { get; } = new[] { "SCP082-EZ", "082Entrance" };

    public string Description { get; } = "Puszcza Cassie o wykryciu SCP-082 w Strefie Wejściowej.";

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        if (sender is PlayerCommandSender) 
        {
            response = "Komenda wysłana pomyślnie";
            Cassie.MessageTranslated("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . SCP 0 8 2 Detected jam_027_4 .g5 in Pitch_0.9 Entrance Zone pitch_0.6 .g4", "Uwaga, Wykryto <color=#FF0000>SCP-082</color> w Strefie Wejściowej", isNoisy:false);
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
     cassie_sl pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . SCP 0 8 2 Detected jam_027_4 .g5 in Pitch_0.9 Entrance Zone pitch_0.6 .g4
     Spolszczenie: Uwaga, Wykryto SCP-082 w Strefie Wejściowej
     Wygląd: SCP-082 na czerwono        
    */

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class SCP082LightContainment : ICommand
    {
        public string Command { get; } = "Cassie-SCP082-LightContainment";

        public string[] Aliases { get; } = new[] { "SCP082-LC", "082Light" };

        public string Description { get; } = "Puszcza Cassie o wykryciu SCP-082 w Strefie Lekkiego Przechowywania.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . SCP 0 8 2 Detected jam_027_4 .g5 in Pitch_0.9 Light Containment pitch_0.6 .g4", "Uwaga, Wykryto <color=#FF0000>SCP-082</color> w Strefie Lekkiego Nadzoru", isNoisy: false);
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
         cassie_sl pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . SCP 0 8 2 Detected jam_027_4 .g5 in Pitch_0.9 Light Containment pitch_0.6 .g4
         Spolszczenie: Uwaga, Wykryto SCP-082 w Strefie Lekkiego Nadzoru
         Wygląd: SCP-082 na czerwono
        */



    }

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class SCP082HeavyContainment : ICommand
    {
        public string Command { get; } = "Cassie-SCP082-HeavyContainment";

        public string[] Aliases { get; } = new[] { "SCP082-HC", "082Heavy" };

        public string Description { get; } = "Puszcza Cassie o wykryciu SCP-082 w Strefie Ciężkiego Przechowywania.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . SCP 0 8 2 Detected jam_027_4 .g5 in Pitch_0.9 Heavy Containment pitch_0.6 .g4", "Uwaga, <color=#FF0000>SCP-082</color> został wykryty w Strefie Wyższego Nadzoru", isNoisy: false);
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
         cassie_sl pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . SCP 0 8 2 Detected jam_027_4 .g5 in Pitch_0.9 Heavy Containment pitch_0.6 .g4
         Spolszczenie: Uwaga, SCP-082 został wykryty w Strefie Wyższego Nadzoru
         Wygląd: SCP-082 na czerwono
        */

    }


}
