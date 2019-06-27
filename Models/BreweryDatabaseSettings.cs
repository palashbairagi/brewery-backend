using System;

namespace brewerybackend.Models
{
    public class BreweryDatabaseSettings : IBreweryDatabaseSettings
    {
        public string BreweryCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IBreweryDatabaseSettings
    {
        string BreweryCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
