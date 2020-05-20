using DataAccessLayer.CQRS.Queries.FindLatestFood;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CQRS.Handlers
{
    public class FindLatestFoodHandler
    {
        public FindLatestFoodResponse Handle(FindLatestFood query)
        {
            return new FindLatestFoodResponse(query.query());
        }

    }

}
