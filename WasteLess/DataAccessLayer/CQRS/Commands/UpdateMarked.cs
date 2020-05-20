using DataAccessLayer.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;
using System.Linq;

namespace DataAccessLayer.CQRS.Commands
{
    public class UpdateMarked
    {
        List<FoodItem> foodItems;
        public UpdateMarked(List<FoodItem> foodItems)
        {
            this.foodItems = foodItems;
        }
        public bool command()
        {
            bool res = false;
            using (var _dcm = new DatabaseConnectionManager())
            {
                foreach (FoodItem fi in foodItems)
                {
                    FoodItem nfi = _dcm.FoodItems.Where(x => x.Id == fi.Id).FirstOrDefault();
                    nfi.Marked = true;
                    _dcm.FoodItems.Update(nfi);
                    _dcm.SaveChanges();
                }
                res = true;
            }
            return res;
        }
    
    }

}
