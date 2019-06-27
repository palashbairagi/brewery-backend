using System;
using System.Collections.Generic;
using brewerybackend.Models;
using MongoDB.Driver;

namespace brewerybackend.Services
{
    public class BreweryService
    {
        private readonly IMongoCollection<Brewery> _breweries;

        public BreweryService(IBreweryDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _breweries = database.GetCollection<Brewery>(settings.BreweryCollectionName);
        }

        public List<Brewery> Get()
        {
            return _breweries.Find(brewery => true).ToList();
        }

        public Brewery Get(long id)
        {
            return _breweries.Find<Brewery>(brewery => brewery.Id == id).FirstOrDefault();
        }
    }
}
