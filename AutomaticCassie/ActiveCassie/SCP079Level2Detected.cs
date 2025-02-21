using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Scp079;

using CassieHandler = Exiled.Events.Handlers.Cassie;

namespace AutomaticCassie.ActiveCassie
{
    class SCP079Level2Detected
    {

        public static void ZeroSevenNineContainmentBreach(GainingLevelEventArgs ev) 
        {
           if (ev.NewLevel == 2) 
            {
                Cassie.MessageTranslated("Cassie_sl pitch_0.8 jam_044_8 Warning .g3 . . Facility pitch_0.9 jam_077_5 malfunction jam_090_4 detected . . Danger .g4 . Doors .g6 malfunction jam_030_5 detected . . Lights jam_035_4 malfunction detected . jam_044_5 SCP jam_22_7 0 jam_044_3 7 9 activity jam_044_5 detected . . . . jam_066_6 Cassiesystem .g1 malfunction detected  ALL MTFunits secure SCP 0 7 9 .g6 immediately .g2", "Cassie system wykrył awarię. <color=#FF0000>Ostrzeżenie</color> :<color=#FF0000> awaria </color> urządzenia wykryta. <color=#FF0000>Niebezpieczeństwo</color> : wykryto awarię drzwi oraz świateł. Wykryta aktywność <color=#8B0000>SCP-079</color> . Awaria systemu Cassie. Wszystkie jednostki <color=#0000FF>MTF</color> mają zabezpieczyć <color=#8B000>SCP-079</color> natychmiast.");
            } 
        }
    }
}
