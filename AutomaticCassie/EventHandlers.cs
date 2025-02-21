using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.Handlers;
using Exiled.API.Enums;
using UnityEngine;

using server = Exiled.Events.Handlers.Server;

namespace AutomaticCassie
{


    public class EventHandlers
    {

        public void OnEnabled() 
        {
            Exiled.Events.Handlers.Map.AnnouncingNtfEntrance += ActiveCassie.Epsilon11SpawnCassie.OnMTFSpawn;
            Exiled.Events.Handlers.Scp079.GainingLevel += ActiveCassie.SCP079Level2Detected.ZeroSevenNineContainmentBreach;
            server.WaitingForPlayers += OnWaitingForPlayers;
        }

        public void OnDisabled() 
        {
            Exiled.Events.Handlers.Map.AnnouncingNtfEntrance -= ActiveCassie.Epsilon11SpawnCassie.OnMTFSpawn;
            Exiled.Events.Handlers.Scp079.GainingLevel -= ActiveCassie.SCP079Level2Detected.ZeroSevenNineContainmentBreach;
            server.WaitingForPlayers -= OnWaitingForPlayers;
        }    


        public void OnWaitingForPlayers() 
        {
            Log.Info(message: "Debug Debug, waiting for playa!");
        }

    }
}
