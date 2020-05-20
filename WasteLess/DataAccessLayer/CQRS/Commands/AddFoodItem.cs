using DataAccessLayer.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;

namespace DataAccessLayer.CQRS.Commands
{
    public class AddFoodItem
    {
        FoodItem fi;
        public AddFoodItem(FoodItem fi)
        {
            this.fi = fi;
        }
        public bool command()
        {
            bool res = false;
            using (var _dcm = new DatabaseConnectionManager())
            {
                _dcm.Add(fi);
                _dcm.SaveChanges();
                res = true;
            }
            return res;
        }

    }

}
