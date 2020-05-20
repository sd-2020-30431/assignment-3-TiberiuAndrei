using DataAccessLayer.DataContext;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetMailBot
{
    public class GetMailBot
    {
        public MailBot query()
        {
            using (var _dcm = new DatabaseConnectionManager())
            {
                MailBot mailBot = _dcm.MailBots.First();
                return mailBot;
            }

        }

    }
}
