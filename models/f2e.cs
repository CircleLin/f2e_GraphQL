using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace f2e_GraphQL.models
{
public class f2e
    {            
        [BsonRepresentation(BsonType.ObjectId)] 
        public string _id { get; set; }
        public string? job { get; set; }
        public string? gender { get; set; }
        public string? age { get; set; }
        public string? education { get; set; }
        public string? major { get; set; }
        public first_job? first_job { get; set; }
        public works? works { get; set; }
        public company? company { get; set; }
    }

    public class first_job
    {
        public string? tenure { get; set; }
        public string? leave { get; set; }
        public string? position { get; set; }
        public string? skill { get; set; }
        public string? render { get; set; }       
    }

    public class works
    {
        public string? window { get; set; }
        public string? market { get; set; }
    }

    public class company
    {
        public string? industry { get; set; }
        public string? score { get; set; }
        public string? scale { get; set; }
        public string? area { get; set; }
        public string? people { get; set; }
        public string? work { get; set; }
        public string? job_tenure { get; set; }
        public string? salary { get; set; }
        public string? salary_score { get; set; }
        public string? industry_message { get; set; }
    }
}
