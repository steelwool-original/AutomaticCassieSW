using System;
using CommandSystem;
using Exiled.API.Features;
using RemoteAdmin;

namespace AutomaticCassie.PassiveCassie
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))] 
    class CassieAlpha1Enter : ICommand 
    {
        public string Command { get; } = "Cassie-Alpha1-Enter"; 

        public string[] Aliases { get; } = new[] { "" }; 

        public string Description { get; } = "Cassie informujące o wkroczeniu MFO Alpha-1 do placówki"; 


        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender) 
            {
                response = "Komenda wysłana pomyślnie";
                Cassie.MessageTranslated("pitch_0.3 .g1 .g2 .g5 pitch_0.99 Attention To All MTFunits .g6 In jam_005_4 pitch_0.87 Foundation . pitch_0.09 .g4 .g4 pitch_0.8 jam_044_2 High Personnel Of Foundation Team . Decide To .g1 .g3 .g1 Send . Alpha 1 .g6 Red Right Hand .g5 To Site 02 . pitch_0.1 .g4 .g5 .g2 .g3 pitch_0.7 . jam_005_7 Warning . pitch_1.4 .g2 .g2 .g4 pitch_0.8 jam_005_7 All . pitch_0.8 Survivors Are Advised To Cooperate With Alpha 1 pitch_1 .g4 .g6 pitch_0.87 If You Do Something Against Foundation Forces pitch_1.4 .g2 .g2 .g4 pitch_0.8 You Will Be Designated For jam_040_2 pitch_0.7 Neutralization pitch_0.09 .g4 .g4", "Uwaga do wszystkich Mobilych Formacji Operacyjnych w ośrodku, Wysoko postawiony personel zadecydował o wysłaniu MFO <color=#FF0000>Alpha-1</color> do Ośrodka-02. Cały personel zobowiązany jest do kooperowania z jednostką <color=#FF0000>Alpha-1</color> W przypadku działania przeciwko jednostce zostanie wydany <color=#FF0000>nakaz terminacji</color>.", isNoisy:false);
                return true;
            }
            else 
            {
                response = "InvalidRemoteAdminException";
                return false;
            }
        }



        /*
         Cassie ma być komendą dla admina który zrobi customową jednostke Alpha-1 na serwerze
	 Cassie:
         cassie_sl pitch_0.3 .g1 .g2 .g5 pitch_0.99 Attention To All MTFunits .g6 In jam_005_4 pitch_0.87 Foundation . pitch_0.09 .g4 .g4 pitch_0.8 jam_044_2 High Personnel Of Foundation Team . Decide To .g1 .g3 .g1 Send . Alpha 1 .g6 Red Right Hand .g5 To Site 02 . pitch_0.1 .g4 .g5 .g2 .g3 pitch_0.7 . jam_005_7 Warning . pitch_1.4 .g2 .g2 .g4 pitch_0.8 jam_005_7 All . pitch_0.8 Survivors Are Advised To Cooperate With Alpha 1 pitch_1 .g4 .g6 pitch_0.87 If You Do Something Against Foundation Forces pitch_1.4 .g2 .g2 .g4 pitch_0.8 You Will Be Designated For jam_040_2 pitch_0.7 Neutralization pitch_0.09 .g4 .g4
         Uwaga do wszystkich Mobilych Formacji Operacyjnych w ośrodku . . Wysoko postawiony personel zadecydował o wysłaniu MFO Alpha-1 do Ośrodka-02 . . Cały personel zobowiązany jest do kooperowania z jednostką Alpha-1 W przypadku działania przeciwko jednostce zostanie wydany nakaz terminacji.
         Wygląd: Alpha-1 (każde powtórzenie) na czerwono lekko powiększone na czerowno równierz nakaz terminacji
        */



    }
}