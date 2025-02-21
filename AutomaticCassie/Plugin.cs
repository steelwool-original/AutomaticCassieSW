using System;
using Exiled.API.Features;
using Exiled.API.Enums;
using UnityEngine;

using PlayerHandler = Exiled.Events.Handlers.Player;
using ServerHandler = Exiled.Events.Handlers.Server;
using CassieHandler = Exiled.Events.Handlers.Cassie;
using RandomHandler = System.Random;
using Epsilon11CassieHandler = AutomaticCassie.ActiveCassie.Epsilon11SpawnCassie;
using System.Collections;
using AutomaticCassie.ActiveCassie;



namespace AutomaticCassie
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "Automatic Cassie Plugin";
        public override string Author => "Deathsies";
        public override Version Version => new Version(1, 0, 0);

        public static Plugin Instance;
        

        #region Instantions

        RandomHandler randomGen = new RandomHandler();
        Epsilon11CassieHandler Eps11Handler = new Epsilon11CassieHandler();
        EventHandlers eventhandlers = new EventHandlers();

        #endregion


        #region floats/timers

        public float RandomGCombinationsCountdown;

        #endregion


        #region Settings

        #endregion

        public override void OnEnabled()
        {
            base.OnEnabled();
            RandomGCombinationsCountdown = randomGen.Next(60,180);
            eventhandlers.OnEnabled();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            eventhandlers.OnDisabled();
        }

        public IEnumerator TimerEnumerator() 
        {
            while (true) 
            {
                if (RandomGCombinationsCountdown >= 1)
                {
                    RandomGCombinationsCountdown--;
                }
                else
                {
                    RandomGCombinationsCountdown = randomGen.Next(60,180);
                    RandomGCassieCombinations.PlayCassie();
                }

                // Different Timers >

                yield return new WaitForSeconds(1);
            }
        }

    }
}
