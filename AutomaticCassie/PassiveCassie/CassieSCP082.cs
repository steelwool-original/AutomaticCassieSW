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

        public string[] Aliases { get; } = new[] { "SCP082-HCZ", "082Heavy" };

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


    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class SCP082Secured : ICommand
    {
        public string Command { get; } = "Cassie-SCP082-Secured";

        public string[] Aliases { get; } = new[] { "SCP082-S", "082Secured" };

        public string Description { get; } = "Puszcza Cassie o zabezpieczeniu SCP-082.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated(".g4 .g4 SCP 0 8 2 jam_030_2 contained successfully by .g6 MTFunits .g5", "<color=#FF0000>SCP-082</color> został skutecznie zabezpieczony przez jednostki <color=#ADD8E6>MFO</color>", isNoisy: false);
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
    class SCP082TerminationMTF : ICommand
    {
        public string Command { get; } = "Cassie-SCP082-TerminationMTF";

        public string[] Aliases { get; } = new[] { "SCP082-TMTF" };

        public string Description { get; } = "Puszcza Cassie o terminacji SCP-082 z powodu zabicia operatora MTF.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated(".g4 .g5 pitch_0.85 jam_45_2 Danger . . pitch_1.0 .g4 pitch_0.95 SCP 0 8 2 killed Mobile Task Force jam_44_3 agent . . pitch_1.0 Attention .g4 MTFunit . pitch_0.9 jam_46_4 terminate SCP 0 8 2 pitch_1.0 .g3 .g3", "<color=#FF0000>Niebezpieczeństwo</color>, <color=#FF0000>SCP-082</color> zabił członka <color=#ADD8E6>Mobilnej Formacji Operacyjnej</color>. Uwaga! Jednostka <color=#ADD8E6>MTF</color>, natychmiast terminować <color=#FF0000>SCP-082</color>.", isNoisy: false);
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
    class SCP082TerminationPersonnel : ICommand
    {
        public string Command { get; } = "Cassie-SCP082-TerminationP";

        public string[] Aliases { get; } = new[] { "SCP082-TP" };

        public string Description { get; } = "Puszcza Cassie o terminacji SCP-082 z powodu zabicia Personelu Placówki.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("Cassie_sl .g4 .g5 pitch_0.85 jam_45_2 Danger . . pitch_1.0  .g4 pitch_0.95 SCP 0 8 2 killed 1  of pitch_0.8 jam_44_3 personnel . . pitch_1.0 Attention .g4 MTFunit . pitch_0.9 jam_46_4 terminate SCP 0 8 2 pitch_1.0 .g3 .g3", "<color=#FF0000>Niebezpieczeństwo</color>, <color=#FF0000>SCP-082</color> zabił jednego członka personelu Fundacji. Uwaga! Jednostka <color=#ADDE6>MTF</color>, natychmiast terminować <color=#FF0000>SCP-082</color>.", isNoisy: false);
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
