// See https://aka.ms/new-console-template for more information

using MongoDB.Driver;

var server = new MongoServerAddress("localhost", 27017);

var settings = new MongoClientSettings { Server = server };

var client = new MongoClient(settings);

var database = client.GetDatabase("db_portal");

Console.ReadLine();