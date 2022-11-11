using System.Data;
using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Enums;
using gamemode.Player;

namespace gamemode.core.Event.ClientEvent;

public class Accounts : IScript
{
    [ClientEvent("core:login")]
    public void Login(MyPlayer player, string username, string password)
    {
        Account account = new Account() { Username = username, Password = password };
        if (account.Login())
        {
            account.Update();
            player.Spawn(new Position(account.X, account.Y, account.Z),1000);
            player.Model = (uint)PedModel.FreemodeMale01;
            player.Id = account.Id;
            player.Emit("core:successLogin");
            player.Emit("core:init", account.Bank, account.Cash);
        }
    }

   

    [ClientEvent("core:register")]
    public void Create(MyPlayer player, string username, string password)
    {
        Account account = new Account { Username = username, Password = password};
        if (account.Create())
        {
            player.Spawn(new Position(0, 0, 75),1000);
            player.Model = (uint)PedModel.FreemodeMale01;
            player.Id = account.Id;
            player.Emit("core:successLogin");
        }
    }
}