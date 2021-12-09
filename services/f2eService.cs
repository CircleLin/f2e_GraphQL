using MongoDB.Driver;
using f2e_GraphQL.models;
using System.Collections.Generic;

namespace f2e_GraphQL.services
{
    public class f2eService
    {
         private readonly IMongoCollection<f2e> _f2eModel;
        public f2eService(If2eDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _f2eModel = database.GetCollection<f2e>(settings.f2eCollectionName);
        }      

        public List<f2e> Get()
        {            
            var data = _f2eModel.Find(f2e => true).ToList();
            return data;
        }
    }
}