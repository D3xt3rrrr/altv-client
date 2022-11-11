using AltV.Net;
using AltV.Net.Data;
using gamemode.core.Entity.Vehicle;
using gamemode.Player;

namespace gamemode.core.System.cardealer;

public class CarDealer
{
    public CarDealer()
    {
        
    }

    public void Buy(Account account, MyPlayer player, double price, string model)
    {
        if (account.Bank - price > 0)
            account.Bank -= price;
        
        MyVehicle newVehicle = new MyVehicle(player.Core, Alt.Hash(model),
            new Position(player.Position.X, player.Position.Y + 1.5f, player.Position.Z), player.Rotation);

    }
}