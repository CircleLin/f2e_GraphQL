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

        public f2e GetById(string id)
        {
            var f2eData = _f2eModel.Find(x=>x._id == id).FirstOrDefault();
            if(f2eData == null)
            {
                throw new System.Exception($"查無id為{id}的資料");
            }
            return f2eData;
        }
    }
}