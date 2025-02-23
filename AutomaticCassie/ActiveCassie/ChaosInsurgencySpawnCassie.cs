using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Map;

namespace AutomaticCassie.ActiveCassie
{
    class ChaosInsurgencySpawnCassie
    {
        public static void OnChaosSpawn(AnnouncingChaosEntranceEventArgs ev) 
        {
            Cassie.MessageTranslated("cassie pitch_0.8 Warning . pitch_1.0 unauthorized access to surface gate detected  pitch_0.4 .g4 pitch_1.0 surface guards please check this jam_066_4 immediately pitch_0.1 . .g2 . .g3 . .g4 . .g4 .g4 . pitch_0.9 jam_040_2  danger . .g4 danger surface guards are K I A . Warning to mtfunits and facility guards in site 2 . unauthorized unit is in the facility pitch_0.1 .g6 .g2 .g3 .g1 pitch_1.0", "<color=#FF0000>Uwaga!</color> Wykryto nieautoryzowany dostęp do bramy Surface Zone. Strażnicy Surface proszeni są o natychmiastowe sprawdzenie... Strażnicy Surface Zone są color=#FF0000>KIA</color>. <color=#FF0000>Uwaga</color> do <color=#ADD8E6>Mobilnych Jednostek Operacyjnych</color> i ochrony placówki: <color=#FF0000>Nieautoryzowana</color> jednostka wkroczyła na teren placówki.", isNoisy:true);
        }
    }
}
