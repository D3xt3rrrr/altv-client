using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Enums;
using gamemode.core.System.cardealer;
using gamemode.Player;

namespace gamemode.core.Event.ClientEvent;

public class Player : IScript
{

    [ScriptEvent(ScriptEventType.PlayerDisconnect)]
    public static void Disconnect(MyPlayer player, string reason)
    {
        Account account = new Account { Id = player.Id };
        List<Account> list = Init.mongo.fetch(account, "accounts");
        list[0].Save(player);
    }
    
    
    
    [ClientEvent("core:buyCar")] 
    public void buyCar(MyPlayer player, double price, string model)
    {
        Account account = new Account();
        account.Id = player.Id;
        
        List<Account> list = Init.mongo.fetch(account, "accounts");
        account = list[0];
        new CarDealer().Buy(account, player, price, model);
    }
}