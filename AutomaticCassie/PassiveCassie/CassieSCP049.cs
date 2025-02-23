using System;
using CommandSystem;
using Exiled.API.Features;
using RemoteAdmin;

namespace AutomaticCassie.PassiveCassie
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))] 
    class CassieSCP049Heavy : ICommand 
    {
        public string Command { get; } = "Cassie-SCP049-Heavy"; 

        public string[] Aliases { get; } = new[] { "049Hcz", "049Heavy" }; 

        public string Description { get; } = "Cassie informujące o SCP-049 w Heavy Containment"; 



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender) 
            {
                Cassie.MessageTranslated("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning .g1 .g1 to all jam_30_3 Personnel . . SCP 0 4 9 Detected jam_027_4 .g5 in Pitch_0.9 Heavy Containment pitch_0.6 .g4", "Uwaga do całego Personelu . . Aktywność podmiotu <color=#FF0000>SCP 049</color> została wykryta w Strefie Wyższego Nadzoru.", isNoisy:false);
                response = "Komenda wysłana pomyślnie";
                return true;
            }
            else 
            {
                response = "InvalidRemoteAdminExpection";
                return false;
            }
        }



        /*
         Cassie ma być komendą dla admina gdy zobaczy że SCP 049 jest w heavy
	 Cassie: 
         cassie_sl pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning .g1 .g1 to all jam_30_3 Personnel . . SCP 0 4 9 Detected jam_027_4 .g5 in Pitch_0.9 Heavy Containment pitch_0.6 .g4
         Uwaga do całego Personelu . . Aktywność podmiotu SCP 049 została wykryta w Strefie Wyższego Nadzoru.
         Wygląd: Na czerwono SCP 049
        */



    }


    [CommandHandler(typeof(RemoteAdminCommandHandler))] 
    class CassieSCP049Light : ICommand 
    {
        public string Command { get; } = "Cassie-SCP049-Entrance";

        public string[] Aliases { get; } = new[] { "049Ecz", "049Entrance" }; 

        public string Description { get; } = "Cassie informujące o SCP-049 w Entrance Zone"; 


        // Z tym nic nie rób
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender) 
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning .g1 .g1 to all jam_30_3 Personnel . . SCP 0 4 9 Detected jam_027_4 .g5 in Pitch_0.9 Light Containment pitch_0.6 .g4", " Uwaga do całego Personelu . . Aktywność podmiotu <color=#FF0000>SCP 049</color> została wykryta w Strefie Niższego Nadzoru.", isNoisy:false);
                return true;
            }
            else 
            {
                response = "InvalidRemoteAdminExpection";
                return false;
            }
        }



        /*
         Cassie ma być komendą dla admina gdy zobaczy że SCP 049 jest w light
	 Cassie: 
         cassie_sl pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning .g1 .g1 to all jam_30_3 Personnel . . SCP 0 4 9 Detected jam_027_4 .g5 in Pitch_0.9 Entrance Zone pitch_0.6 .g4
         Uwaga do całego Personelu . . Aktywność podmiotu SCP 049 została wykryta w Strefie Wejściowej.
         Wygląd: Na czerwono SCP 049
        */



    }


    [CommandHandler(typeof(RemoteAdminCommandHandler))] 
    class SCP049Entrance : ICommand 
    {
        public string Command { get; } = "Cassie-SCP049-Light"; 

        public string[] Aliases { get; } = new[] { "049Lcz", "049Light" };

        public string Description { get; } = "Cassie informujące o SCP-049 w Light Containment Zone"; 


        // Z tym nic nie rób
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender) 
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning .g1 .g1 to all jam_30_3 Personnel . . SCP 0 4 9 Detected jam_027_4 .g5 in Pitch_0.9 Light Containment Zone pitch_0.6 .g4", "Uwaga do całego Personelu . . Aktywność podmiotu <color=#FF0000>SCP 049</color> została wykryta w Strefie Niższego Nadzoru.", isNoisy:false);
                return true;
            }
            else 
            {
                response = "InvalidRemoteAdminExepction";
                return false;
            }
        }



        /*
         Cassie ma być komendą dla admina gdy zobaczy że SCP 049 jest w light
	 Cassie: 
         cassie_sl pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning .g1 .g1 to all jam_30_3 Personnel . . SCP 0 4 9 Detected jam_027_4 .g5 in Pitch_0.9 Entrance Zone pitch_0.6 .g4
         Uwaga do całego Personelu . . Aktywność podmiotu SCP 049 została wykryta w Strefie Wejściowej.
         Wygląd: Na czerwono SCP 049
        */



    }

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class SCP049Secured : ICommand
    {
        public string Command { get; } = "Cassie-SCP049-Secured";

        public string[] Aliases { get; } = new[] { "SCP049-S", "049Secured" };

        public string Description { get; } = "Puszcza Cassie o zabezpieczeniu SCP-049.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated(".g4 .g4 SCP 0 4 9 jam_030_2 contained successfully by .g6 MTFunits .g5", "<color=#FF0000>SCP-049</color> został skutecznie zabezpieczony przez jednostki <color=#ADD8E6>MFO</color>", isNoisy: false);
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
         cassie_sl .g4 .g4 SCP 0 4 9 jam_030_2 contained successfully by .g6 MTFunits .g5
         Spolszczenie: SCP-049 został skutecznie zabezpieczony przez jednostki MFO
         Wygląd: SCP-049 na czerwono MFO na niebiesko
        */



    }



}