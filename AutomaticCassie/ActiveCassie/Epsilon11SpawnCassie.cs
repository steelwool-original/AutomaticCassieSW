using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Map;

namespace AutomaticCassie.ActiveCassie
{
    class Epsilon11SpawnCassie
    {


        public static void OnMTFSpawn(AnnouncingNtfEntranceEventArgs ev) 
        {
            ev.IsAllowed = false;
            Cassie.MessageTranslated("pitch_0.23 .g4 .g4 pitch_0.99 .g4 pitch_0.98 .g4 pitch_0.23 .g4 .g4 pitch_1 . . mtfUnit Epsilon 11 . Designated NineTailedFox has entered the facility . All personnel . Do not attempt to get to the exit . either stay in a shelter or go to 1 of the many safe areas around the facility . personnel escort will start when all scpsubjects are pitch_0.95 recontained pitch_023 .g4 .g4", "<color=#ADD8E6>Mobilna Formacja Operacyjna</color> Epsilon-11, Dezygnacja <color=#FFA500>Nine Tailed Fox</color>, weszła do <color=#ADD8E6>placówki</color>. Cały personel proszony jest o pozostanie w schronie <color=#90EE90>ewakuacyjnym</color> lub w innym, bezpiecznym miejscu do czasu zakończenia procedury <color=#FF0000>dekontaminacji</color>. Eksportacja zostanie rozpoczęta, gdy wszystkie wymagane protokoły zostaną przywrócone.");
        }

    }
}
