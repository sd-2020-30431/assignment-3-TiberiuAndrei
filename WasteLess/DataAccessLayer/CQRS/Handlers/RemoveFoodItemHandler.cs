using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Commands;

namespace DataAccessLayer.CQRS.Handlers
{
    public class RemoveFoodItemHandler
    {
        public bool Handle(RemoveFoodItem command)
        {
            bool res = false;
            if (command.command())
            {
                res = true;
            }
            return res;
        }

    }

}
