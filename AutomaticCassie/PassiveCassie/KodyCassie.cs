using System;
using CommandSystem;
using RemoteAdmin;
using Exiled.API.Features;
using Exiled.API.Features.Doors;
using Exiled.API.Enums;

namespace AutomaticCassie.PassiveCassie
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))] // ClientCommandHandler jeżeli komenda ma być na Konsolę
    class OrangeCode : ICommand // Nazwa Komendy, Np "class ChaosInsurgencyForveWave : ICommand" 
    {
        public string Command { get; } = "C-Kod-Pomaranczowy"; // Komenda np = "SummonCiSUV";

        public string[] Aliases { get; } = new[] { "kod-pomaranczowy" }; // Aliasy komendy, czyli skrót komendy, pisać w {""} i przecinek po każdym aliasie, np =  new[] {"cicar, summonci, ciwave"}

        public string Description { get; } = "Cassie informujące o kodzie pomarańczowym, wraz z puszczeniem blokuje checkpointy Light-Heavy na 3 minuty"; // Opis Komendy, np = "This command summons Chaos Insurgency";


        // Z tym nic nie rób
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender) 
            {
                response = "Kod wysłany pomyślnie!";
                Cassie.MessageTranslated("bell_start pitch_0.5 .g2 pitch_0.9 .g1 pitch_0.9 jam_043_5 Warning .g1 .g3 .g4 Code jam_090_1 Orange has been jam_080_3 activated pitch_0.7 .g5 pitch_0.9 Class D jam_090_2 personnel have jam_080_3 started .g1 an insurgency pitch_0.7 .g5 pitch_0.6 .g5 pitch_0.9 jam_080_3 To all personnel proceed with standard security protocols pitch_1 bell_end pitch_0.1 .g3 pitch_1", "Uwaga . <color=#FFCC99>Kod Pomarańczowy</color> został aktywowany . . Personel <color=#FFA550>Klasy D</color> Rozpoczął bunt Cały Personel ma za zadanie postępować według standardowych procedur kodu <color=#FFCC99>pomarańczowego</color>.", isNoisy:true);
                CheckpointDoor.Get(DoorType.CheckpointEzHczA).Lock(time: 180, lockType: DoorLockType.Lockdown079);
                CheckpointDoor.Get(DoorType.CheckpointEzHczB).Lock(time: 180, lockType: DoorLockType.Lockdown079);
                return true;
            }
            else 
            {
                response = "InvalidRemoteAdminExepction";
                return false;
            }
        }



        /*
         Blokuje checkpointy heavy-light na 3 minuty przy tym puszcza cassie
         Cassie:
         bell_start pitch_0.5 .g2 pitch_0.9 .g1 pitch_0.9 jam_043_5 Warning .g1 .g3 .g4 Code jam_090_1 Orange has been jam_080_3 activated pitch_0.7 .g5 pitch_0.9 Class D jam_090_2 personnel have jam_080_3 started .g1 an insurgency pitch_0.7 .g5 pitch_0.6 .g5 pitch_0.9 jam_080_3 To all personnel proceed with standard security protocols pitch_1 bell_end pitch_0.1 .g3 pitch_1
         Uwaga . Kod Pomarańczowy został aktywowany . . Personel Klasy D Rozpoczął bunt Cały Personel ma za zadanie postępować według standardowych procedur kodu pomarańczowego.
         Wygląd: podkreśl niektóre słowa np klas d na pomarańczowo tak samo sam kod pomarańczowy
        */



    }

    [CommandHandler(typeof(RemoteAdminCommandHandler))] // ClientCommandHandler jeżeli komenda ma być na Konsolę
    class CodeBlack : ICommand // Nazwa Komendy, Np "class ChaosInsurgencyForveWave : ICommand" 
    {
        public string Command { get; } = "Cassie-kod-czarny"; // Komenda np = "SummonCiSUV";

        public string[] Aliases { get; } = new[] { "kod-czarny" }; // Aliasy komendy, czyli skrót komendy, pisać w {""} i przecinek po każdym aliasie, np =  new[] {"cicar, summonci, ciwave"}

        public string Description { get; } = "Cassie informujące o kodzie czarnym w placówce"; // Opis Komendy, np = "This command summons Chaos Insurgency";


        // Z tym nic nie rób
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender)
            {
                response = "Kod wysłany pomyślnie!";
                Cassie.MessageTranslated("pitch_0.2 .g5 pitch_0.4 .g5 pitch_0.95 Foundation Personnel .g6 Code Black Has Been Initiated pitch_0.3 .g5 .g5 pitch_0.9 All Foundation Forces Please Evacuate Site Personnel .g1 .g1 On Surface Zone .g5 . .g5", "Uwaga Personelu Fundacji . . <color#737373>Kod Czarny</color> został uruchomiony . . Wszystkie siły zbrojne Fundacji powinny pomóc ewakuawać Personel na Strefę Zewnętrzną.", isNoisy: true);
                return true;
            }
            else
            {
                response = "InvalidRemoteAdminExepction";
                return false;
            }
        }



        /*
         pitch_0.2 .g5 pitch_0.4 .g5 pitch_0.95 Foundation Personnel .g6 Code Black Has Been Initiated pitch_0.3 .g5 .g5 pitch_0.9 All Foundation Forces Please Evacuate Site Personnel .g1 .g1 On Surface Zone .g5 . .g5
 	 Uwaga Personelu Fundacji . . Kod Czarny został uruchomiony . . Wszystkie siły zbrojne Fundacji powinny pomóc ewakuawać Personel na Strefę Zewnętrzną.
         Wygląd: kod czarny na czarno cncn
        */



    }




    [CommandHandler(typeof(RemoteAdminCommandHandler))] // ClientCommandHandler jeżeli komenda ma być na Konsolę
    class CodeGreen : ICommand // Nazwa Komendy, Np "class ChaosInsurgencyForveWave : ICommand" 
    {
        public string Command { get; } = "Cassie-Kod-Zielony"; // Komenda np = "SummonCiSUV";

        public string[] Aliases { get; } = new[] { "kod-zielony" }; // Aliasy komendy, czyli skrót komendy, pisać w {""} i przecinek po każdym aliasie, np =  new[] {"cicar, summonci, ciwave"}

        public string Description { get; } = "Cassie informujące o kodzie zielonym w placówce"; // Opis Komendy, np = "This command summons Chaos Insurgency";


        // Z tym nic nie rób
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender) 
            {
                response = "Kod wysłany pomyślnie";
                Cassie.MessageTranslated("pitch_0.2 .g5 pitch_0.9 .g5 .g5 pitch_0.95 Attention Foundation Personnel .g6 Code Green Has Been Initiated pitch_0.3 .g5 .g1 pitch_0.94 Group Of Interest Against Foundation HasEntered .g4 pitch_0.99 .g4 All Personnel Stay in safe area .g5 .g5 MTFunits proceed with standard procedures pitch_0.8 .g5 . .g5 pitch_1", "Uwaga Do Personelu Fundacji . . <color=#2cbf1f>Kod Zielony</color> został aktywowany . . Nieznana grupa wrogich jednostek wkroczyła do placówki . Cały Personel ma pozostać w bezpiecznym miejscu . . <color=#ADD8E6>Mobilne Formacje Operacyjne</color> Stosować się do Standardowych Procedur", isNoisy: true);
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
 	pitch_0.2 .g5 pitch_0.9 .g5 .g5 pitch_0.95 Attention Foundation Personnel .g6 Code Green Has Been Initiated pitch_0.3 .g5 .g1 pitch_0.94 Group Of Interest Against Foundation HasEntered .g4 pitch_0.99 .g4 All Personnel Stay in safe area .g5 .g5 MTFunits proceed with standard procedures pitch_0.8 .g5 . .g5 pitch_1
        Uwaga Do Personelu Fundacji . . Kod Zielony został aktywowany . . Nieznana grupa wrogich jednostek wkroczyła do placówki . Cały Personel ma pozostać w bezpiecznym miejscu . . Mobilne Formacje Operacyjne Stosować się do Standardowych Procedur
        Wygląd: wedle uznania
        */



    }


}
