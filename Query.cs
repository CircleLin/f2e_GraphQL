using System.Threading.Tasks;
using System.Collections.Generic;
using f2e_GraphQL.services;
using f2e_GraphQL.models;
using HotChocolate;

namespace f2e_GraphQL
{
    public class Query
    {
        [GraphQLDescription("取得所有前端從業人員資料")]
        public List<f2e> Getf2e([Service] f2eService f2eservice)
        {
            var dd =  f2eservice.Get();    
            return dd;
        }   

        [GraphQLDescription("取得單筆前端從業人員資料")]
        public f2e Getf2eById([Service] f2eService f2eservice, [GraphQLName("id")] string id)
        {
            var f2e = f2eservice.GetById(id);
            return f2e;
        }
    }
}
