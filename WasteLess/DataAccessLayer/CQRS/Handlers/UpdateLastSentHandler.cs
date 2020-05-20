using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Commands;

namespace DataAccessLayer.CQRS.Handlers
{
    public class UpdateLastSentHandler
    {
        public bool Handle(UpdateLastSent command)
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
