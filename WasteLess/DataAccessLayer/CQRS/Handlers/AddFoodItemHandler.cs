using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Commands;

namespace DataAccessLayer.CQRS.Handlers
{
    public class AddFoodItemHandler
    {
        public bool Handle(AddFoodItem command)
        {
            bool res = false;
            if(command.command())
            {
                res = true;
            }
            return res;
        }

    }
}
