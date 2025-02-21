using System;
using CommandSystem;
using Exiled.API.Features;
using RemoteAdmin;

namespace AutomaticCassie.PassiveCassie
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))] // ClientCommandHandler jeżeli komenda ma być na Konsolę
    class ExampleCommand : ICommand // Nazwa Komendy, Np "class ChaosInsurgencyForveWave : ICommand" 
    {
        public string Command { get; } = "ExampleCommand"; // Komenda np = "SummonCiSUV";

        public string[] Aliases { get; } = new[] {"ExmplCmd"}; // Aliasy komendy, czyli skrót komendy, pisać w {""} i przecinek po każdym aliasie, np =  new[] {"cicar, summonci, ciwave"}

        public string Description { get; } = "Example Command"; // Opis Komendy, np = "This command summons Chaos Insurgency";


        // Z tym nic nie rób
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender) 
            {
                Cassie.Message(".g7");
                response = "Command works!";
                return true;
            }
            else 
            {
                response = "InvalidRemoteAdminException";
                return false;
            }
        }



        /*
         Tutaj opisz co komenda ma robić, a ja reszte zrobię sam
        */



    }
}
