using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Queries.GetFoodList;

namespace DataAccessLayer.CQRS.Handlers
{
    public class GetFoodListHandler
    {
        public GetFoodListResponse Handle(GetFoodList query)
        {
            return new GetFoodListResponse(query.query());
        }
    }
}
