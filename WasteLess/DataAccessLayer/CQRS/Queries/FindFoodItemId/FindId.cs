using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;
using DataAccessLayer.DataContext;
using System.Linq;
using DataAccessLayer.CQRS.Queries;

namespace DataAccessLayer.CQRS.Queries.FindFoodItemId
{
    public class FindId
    {
        long id;

        public FindId(long id)
        {
            this.id = id;
        }

        public int query()
        {
            using (var _dcm = new DatabaseConnectionManager())
            {
                int count = _dcm.FoodItems.Count(x => x.Id == id);
                return count;
            }
        }

    }

}
