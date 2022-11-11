using System;
using AltV.Net;
using AltV.Net.Elements.Entities;
using gamemode.Player;

namespace gamemode
{
    internal class MyResource : Resource
    {

        public override void OnStart()
        {
            Console.WriteLine("<--- Démarage Atlis Island Server --->");
            Init.Open();
        }
        
        public override void OnStop()
        {
            Console.WriteLine("<--- Fermetureasd Atlis Island Server --->");
        }
    
        public override IEntityFactory<IPlayer> GetPlayerFactory()
        {
            return new MyPlayerFactory();
        }
        public override IEntityFactory<IVehicle> GetVehicleFactory()
        {
            return new MyVehicleFactory();
        }
    }
}



