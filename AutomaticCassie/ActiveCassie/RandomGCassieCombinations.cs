using System;
using Exiled.API.Enums;
using Exiled.API.Features;

using MainPlugin = AutomaticCassie.Plugin;
using RandomHandler = System.Random;

namespace AutomaticCassie.ActiveCassie
{
    public static class RandomGCassieCombinations
    {

        static Plugin plugin = new Plugin();

        static RandomHandler randomGen = new RandomHandler();


        #region Combinations

        static string Comb1 = "pitch_0.6 .g5 pitch_0.55 .g5 pitch_0.50 .g5 pitch_0.45 .g5 pitch_0.4 .g5 pitch_0.8 Attention yield_0.4 pitch_0.3 .g5 pitch_0.2 .g5 pitch_0.15 .g5 pitch_0.1 .g5 pitch_0.05 .g5 pitch_0.03 .g5 .g2 .g3 .g1 .g4";
        static string Comb2 = "pitch_0.04 .g2 .g3 .g4 .g6 .g2 .g6 .g4 yield_0.2 .g4 yield_0.2 .g4 yield_0.2 .g4 yield_0.2 .g4 yield_0.2 .g4 yield_0.2 .g4"; // Light's off Mini Event
        static string Comb3 = "pitch_0.3 jam_018_6 .g6 yield_0.2 pitch_0.4 jam_018_6 .g6 yield_0.1 pitch_0.55 humans pitch_0.38 jam_018_6 .g6 yield_0.2 pitch_0.33 jam_018_6 .g4 should pitch_0.5 jam_018_6 .g5 yield_0.2 pitch_0.22 jam_018_6 .g3 pitch_0.7 die pitch_1 .g1 . . pitch_0.6 .g5 . .g5"; // -> Tak wiem że mogłem dać wszystkie te kombinację odrazu do Array, ale tak jest łatwiej modyfikować. 

        #endregion

        static string[] Combinations = { Comb1, Comb2, Comb3};

        public static void PlayCassie() 
        {

            int randomrandom = randomGen.Next(0,3);
            float randomlightsduration = randomGen.Next(5, 30);
            string selectcomb = Combinations[randomrandom];
            Cassie.Message(selectcomb);
            if (selectcomb == Comb2) 
            {
                Map.TurnOffAllLights(duration: randomlightsduration, zoneTypes: ZoneType.HeavyContainment);
            }
        }


    }
}
