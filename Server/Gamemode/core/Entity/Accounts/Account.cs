using System.ComponentModel;
using AltV.Net;
using gamemode.core.Database;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace gamemode.Player;

[DataObject]
public class Account
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
    public double Cash { get; set; }
    public double Bank { get; set; }
    

    public bool Create()
    {
        this.Bank = 100000.00;
        this.Cash = 100000.00;
        
        if (Init.mongo.fetch(this, "accounts").Count >= 1)
            return false;
        
        Password = BCrypt.Net.BCrypt.HashPassword(Password + "sjfkdsakj433i##@$#");
        Init.mongo.Insert(this, "accounts");
        return true;
    }

    public bool Login()
    {
        List<Account> list = Init.mongo.fetch(this, "accounts");
        if (list.Count != 1)
            return false;

        if (!BCrypt.Net.BCrypt.Verify(Password + "sjfkdsakj433i##@$#", list[0].Password))
            return false;
        
        this.Bank = list[0].Bank;
        this.Cash = list[0].Cash;

        return true;
    }

    public void Save(MyPlayer player)
    {
        X = player.Position.X;
        Y = player.Position.Y;
        Z = player.Position.Z;
        Init.mongo.Update(this, Id, "accounts");
    }

    public void Update()
    {
        List<Account> list = Init.mongo.fetch(this, "accounts");
        X = list[0].X;
        Y = list[0].Y;
        Z = list[0].Z;
    }

    public void UpdateUI(MyPlayer player)
    {
        player.Emit("core:init", Bank, Cash);
    }
}