using AltV.Net.Data;
using gamemode.core.Database;
using MongoDB.Driver;

namespace gamemode;

public class Init
{
    public static MongoDb mongo;

    public static void Open()
    {
        mongo = new MongoDb();
        mongo.Open();
    }
}
