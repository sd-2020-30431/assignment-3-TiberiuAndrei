using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Queries.GetMailBot;

namespace DataAccessLayer.CQRS.Handlers
{
    public class GetMailBotHandler
    {
        public GetMailBotResponse Handle(GetMailBot query)
        {
            return new GetMailBotResponse(query.query());
        }
    
    }

}
