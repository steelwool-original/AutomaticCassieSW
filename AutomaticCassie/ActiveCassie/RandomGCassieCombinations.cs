using System;
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

        static string Comb1 = ".g4 .g5 .g5 .g3 .g4 .g6 .g4 .g3 .g2 .g1";
        static string Comb2 = ".g6 .g6 .g6 .g2 .g3 .g4 .g2 .g2";
        static string Comb3 = ".g2 .g2 .g2 .g3 .g3 .g3 .g2 .g3 .g4 .g4 .g2"; // -> Tak wiem że mogłem dać wszystkie te kombinację odrazu do Array, ale tak jest łatwiej modyfikować. 
        static string Comb4 = ".g2 .g3 .g6 .g3 .g2 .g3 .g1 .g2 .g2 .g1"; 
        static string Comb5 = ".g3 .g1 .g5 .g1 .g5 .g5 .g2 .g2";
        static string Comb6 = ".g2 .g1 .g4 .g6 .g6";

        #endregion

        static string[] Combinations = { Comb1, Comb2, Comb3, Comb4, Comb5, Comb6 };

        public static void PlayCassie() 
        {
            Cassie.Message(Combinations[randomGen.Next(0, 5)]);
        }


    }
}
