using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetMailBot
{
    public class GetMailBotResponse
    {
        public MailBot response;

        public GetMailBotResponse(MailBot response)
        {
            this.response = response;
        }

    }

}
