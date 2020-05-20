using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;
using DataAccessLayer.DataContext;
using System.Linq;
using DataAccessLayer.CQRS.Queries;

namespace DataAccessLayer.CQRS.Queries.FindLatestFood
{
    public class FindLatestFood
    {
        public FoodItem query()
        {
            using (var _dcm = new DatabaseConnectionManager())
            {
                int count = _dcm.FoodItems.Count();
                if (count != 0)
                {
                    long maxId = _dcm.FoodItems.Max(x => x.Id);
                    FoodItem query_food = _dcm.FoodItems.Where(x => x.Id == maxId).FirstOrDefault();
                    return query_food;
                }
                else
                {
                    FoodItem query_food = new FoodItem();
                    query_food.Name = "Initial food";
                    query_food.PurchaseDate = new DateTime(2020 - 01 - 01);
                    return query_food;
                }
            }
        }
    }
}
