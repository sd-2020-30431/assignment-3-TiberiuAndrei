using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Queries.GetFoodListExp;

namespace DataAccessLayer.CQRS.Handlers
{
    public class GetFoodListExpHandler
    {
        public GetFoodListExpResponse Handle(GetFoodListExp query)
        {
            return new GetFoodListExpResponse(query.query());
        }

    }
}
