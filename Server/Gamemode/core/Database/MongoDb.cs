using gamemode.Player;
using MongoDB.Driver;
using MongoDB.Driver.Core.Authentication;

namespace gamemode.core.Database;

public class MongoDb
{
    private string conn = "mongodb://127.0.0.1:27017";
    private string database = "altv";
    private MongoClient MongoClient;
    private IMongoDatabase db;

    public MongoDb()
    {
    }


    public void Open()
    {
        MongoClient = new MongoClient(conn);
        db = MongoClient.GetDatabase(database);
    }

    public void Insert<T>(T t, string collection)
    {
        IMongoCollection<T> coll = db.GetCollection<T>(collection);
        coll.InsertOne(t);
    }

    public List<T> fetch<T>(T t, string collection)
    {
        IMongoCollection<T> coll = db.GetCollection<T>(collection);
        var result = coll.FindSync(_ => true);
        
        return result.ToList();
    }

    public void Update<T>(T t, String id, string collection)
    {
        IMongoCollection<T> coll = db.GetCollection<T>(collection);
        var filter = Builders<T>.Filter.Eq("Id", id);
        coll.ReplaceOne(filter, t, new ReplaceOptions { IsUpsert = true });
    }
}