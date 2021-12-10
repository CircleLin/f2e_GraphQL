using HotChocolate;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace f2e_GraphQL.models
{
[GraphQLDescription("前端從業人員資料")]
public class f2e
    {            
        [BsonRepresentation(BsonType.ObjectId)] 
        public string? _id { get; set; }

        [GraphQLDescription("職稱")]
        public string? job { get; set; }

        [GraphQLDescription("性別")]
        public string? gender { get; set; }

        [GraphQLDescription("年齡")]
        public string? age { get; set; }

        [GraphQLDescription("學歷")]
        public string? education { get; set; }

        [GraphQLDescription("科系")]
        public string? major { get; set; }

        [GraphQLDescription("第一份工作")]
        public first_job? first_job { get; set; }

        [GraphQLDescription("工作相關")]
        public works? works { get; set; }

        [GraphQLDescription("現任公司")]
        public company? company { get; set; }
    }

    public class first_job
    {
        [GraphQLDescription("第一份年資")]
        public string? tenure { get; set; }

        [GraphQLDescription("第一份工作離職原因")]
        public string? leave { get; set; }

        [GraphQLDescription("第一份工作被要求非前端工程師的技能")]
        public string? position { get; set; }

        [GraphQLDescription("第一份工作上公司所導入的技能")]
        public string? skill { get; set; }

        [GraphQLDescription("接觸到哪一種開發模式")]
        public string? render { get; set; }       
    }

    public class works
    {
        [GraphQLDescription("主要是哪些窗口有溝通障礙")]
        public string? window { get; set; }

        [GraphQLDescription("自評工作能力範圍")]
        public string? market { get; set; }
    }

    public class company
    {
        [GraphQLDescription("產業類型")]
        public string? industry { get; set; }

        [GraphQLDescription("產業滿意度")]
        public string? score { get; set; }

        [GraphQLDescription("公司規模人數")]
        public string? scale { get; set; }

        [GraphQLDescription("公司位置")]
        public string? area { get; set; }

        [GraphQLDescription("相同職位人數")]
        public string? people { get; set; }

        [GraphQLDescription("工作型態")]
        public string? work { get; set; }

        [GraphQLDescription("工作年資")]
        public string? job_tenure { get; set; }

        [GraphQLDescription("年薪範圍")]
        public string? salary { get; set; }

        [GraphQLDescription("薪水滿意度")]
        public string? salary_score { get; set; }

        [GraphQLDescription("產業簽到區")]
        public string? industry_message { get; set; }
    }
}
