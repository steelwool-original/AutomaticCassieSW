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

        public string[] Aliases { get; } = new[] { "MFOContraband" };

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
    class IntrudersInLightCassie : ICommand
    {
        public string Command { get; } = "IntrudersLCZ";

        public string[] Aliases { get; } = new[] { "IntrudersLight" };

        public string Description { get; } = "Cassie informujące o Intruzach w LCZ";



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                Cassie.MessageTranslated(".g2 jam_042_4 .g2 Danger . Unauthorized jam_055_4 Intruders at .g1 Light Containment Zone pitch_0.9 jam_022_2 .g4", "<color=#FF0000>Niebezpieczeństwo</color>, Wykryto nieautoryzowaną intruzję w Light Containment Zone", isNoisy: false);
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
    class IntrudersInHeavyCassie : ICommand
    {
        public string Command { get; } = "IntrudersHCZ";

        public string[] Aliases { get; } = new[] { "IntrudersHeavy" };

        public string Description { get; } = "Cassie informujące o Intruzach w HCZ";



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                Cassie.MessageTranslated(".g2 jam_042_4 .g2 Danger . Unauthorized jam_055_4 Intruders at .g1 Heavy Containment Zone pitch_0.9 jam_022_2 .g4", "<color=#FF0000>Niebezpieczeństwo</color>, Wykryto nieautoryzowaną intruzję w Heavy Containment Zone", isNoisy: false);
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
    class IntrudersInEntranceCassie : ICommand
    {
        public string Command { get; } = "IntrudersEZ";

        public string[] Aliases { get; } = new[] { "IntrudersEntrance" };

        public string Description { get; } = "Cassie informujące o Intruzach w EZ";



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                Cassie.MessageTranslated(".g2 jam_042_4 .g2 Danger . Unauthorized jam_055_4 Intruders at .g1 Entrance Zone pitch_0.9 jam_022_2 .g4", "<color=#FF0000>Niebezpieczeństwo</color>, Wykryto nieautoryzowaną intruzję w Entrance Zone", isNoisy: false);
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

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class CassieMTFgotoHeavy : ICommand
    {
        public string Command { get; } = "MTFgotoHeavy";

        public string[] Aliases { get; } = new[] { "gotoHCZ" };

        public string Description { get; } = "Cassie rozkazujące MFO o udaniu się do HCZ";



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                Cassie.MessageTranslated("MTFunits central to ninetailedfox  .g3 go to .g2 Heavy Containment Zone  jam_044_2 .g4", "Centrala <color=#ADD8E6>MTF</color> do <color=FFA550>Nine Tailed Fox</color>, Udajcie się do Heavy Containment Zone", isNoisy: false);
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
    class CassieMTFgotoLight : ICommand
    {
        public string Command { get; } = "MTFgotoLight";

        public string[] Aliases { get; } = new[] { "gotoLCZ" };

        public string Description { get; } = "Cassie rozkazujące MFO o udaniu się do LCZ";



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                Cassie.MessageTranslated("MTFunits central to ninetailedfox  .g3 go to .g2 Light Containment Zone  jam_044_2 .g4", "Centrala <color=#ADD8E6>MTF</color> do <color=FFA550>Nine Tailed Fox</color>, Udajcie się do Light Containment Zone", isNoisy: false);
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
    class CassieMTFgotoEntrance : ICommand
    {
        public string Command { get; } = "MTFgotoEntrance";

        public string[] Aliases { get; } = new[] { "gotoEZ" };

        public string Description { get; } = "Cassie rozkazujące MFO o udaniu się do EZ";



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                Cassie.MessageTranslated("MTFunits central to ninetailedfox  .g3 go to .g2 Entrance Zone  jam_044_2 .g4", "Centrala <color=#ADD8E6>MTF</color> do <color=FFA550>Nine Tailed Fox</color>, Udajcie się do Entrance Zone", isNoisy: false);
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
