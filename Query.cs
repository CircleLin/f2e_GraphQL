﻿using System.Threading.Tasks;
using System.Collections.Generic;
using f2e_GraphQL.services;
using f2e_GraphQL.models;
using HotChocolate;

namespace f2e_GraphQL
{
    public class Query
    {
        public List<f2e> Getf2e([Service] f2eService f2eservice)
        {
            var dd =  f2eservice.Get();    
            return dd;
        }   
    }
}
