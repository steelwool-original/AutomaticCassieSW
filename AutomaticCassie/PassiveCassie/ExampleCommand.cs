using System;
using CommandSystem;
using Exiled.API.Features;
using RemoteAdmin;

namespace AutomaticCassie.PassiveCassie
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))] // ClientCommandHandler jeżeli komenda ma być na Konsolę
    class ExampleCommand : ICommand // Nazwa Komendy, Np "class ChaosInsurgencyForveWave : ICommand" 
    {
        public string Command { get; } = "ListaKomend"; // Komenda np = "SummonCiSUV";

        public string[] Aliases { get; } = new[] {"CmdLst", "SWList"}; // Aliasy komendy, czyli skrót komendy, pisać w {""} i przecinek po każdym aliasie, np =  new[] {"cicar, summonci, ciwave"}

        public string Description { get; } = "Lista dostępnych komend w pluginie AutomaticCassieSW"; // Opis Komendy, np = "This command summons Chaos Insurgency";


        // Z tym nic nie rób
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender) 
            {
                response = "True";
                return true;
            }
            else 
            {
                response = "InvalidRemoteAdminException";
                return false;
            }
        }

    }
}
