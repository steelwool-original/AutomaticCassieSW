using System;
using RemoteAdmin;
using CommandSystem;
using Exiled.API.Features;

namespace AutomaticCassie.PassiveCassie
{
    class ClassDRiotCassie : ICommand
    {
        public string Command { get; } = "Class-D-Riot";

        public string[] Aliases { get; } = new[] { "dRiot" };

        public string Description { get; } = "Puszcza Cassie o wyłomie Klas-D.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender) 
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("pitch_0.70 .g4 .g4 .g4 pitch_1 . Class D personnel . has escaped class d cells . pitch_0.70 .g4 .g4 g4", "Personel <color=#FF7700>Klasy D</color> wyłamał się z cel.", isNoisy: false);
                return true;
            }
            else 
            {
                response = "InvalidRemoteAdminExepction";
                return false;
            }
        }
    }


    class AllClassDForTerminationCassie : ICommand
    {
        public string Command { get; } = "All-ClassD-Termination";

        public string[] Aliases { get; } = new[] { "dTermination" };

        public string Description { get; } = "Puszcza Cassie o terminacji Klas-D.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("jam_077_4 MtfUnits All jam_042_3 ClassD . Personnel Designated pitch_1.1 For pitch_1 .g3 jam_067_3 Termination .g4", "Cały personel <color=#FF7700>Klasy D</color> został wyznaczony do <color=#FF0000>terminacji</color>.", isNoisy: true);
                return true;
            }
            else
            {
                response = "InvalidRemoteAdminExepction";
                return false;
            }
        }
    }


    class AllClassDTerminatedCassie : ICommand
    {
        public string Command { get; } = "All-ClassD-Terminated";

        public string[] Aliases { get; } = new[] { "dTerminated" };

        public string Description { get; } = "Puszcza Cassie o udanej terminacji Klas-D.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("All .g4 Class 0 jam_044_2 Personnel .g5 Has. pitch_0.8 been jam_055_8 Terminated .g2", "Cały personel 0 został zlikwidowany.", isNoisy: false);
                return true;
            }
            else
            {
                response = "InvalidRemoteAdminExepction";
                return false;
            }
        }
    }


    class CancelClassDTermination : ICommand
    {
        public string Command { get; } = "Class-D-tCancel";

        public string[] Aliases { get; } = new[] { "cdtCancel" };

        public string Description { get; } = "Puszcza Cassie o anulacji terminacji Klas-D.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("pitch_0.4 .g2 .g1 .g5 .g2 .g3 pitch_0.7 jam_022_4 Warning pitch_0.85 class D termination jam_060_7 cancel . MTFunits .g5 secure all jam_036_5 class D personnel pitch_0.3 .g1 .g5 .g3 .g1", "<color=#FF0000>Ostrzeżenie</color>: Terminacja <color=#FF7700>klasy D</color> zostało anulowane. Zabezpieczyć cały personel <color=#FF7700>klasy D</color>.", isNoisy: false);
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
