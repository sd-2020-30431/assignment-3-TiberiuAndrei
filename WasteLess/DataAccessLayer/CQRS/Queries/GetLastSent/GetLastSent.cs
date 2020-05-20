using DataAccessLayer.DataContext;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetLastSent
{
    public class GetLastSent
    {
        public string username;

        public GetLastSent(string username)
        {
            this.username = username;
        }

        public DateTime query()
        {
            using (var _dcm = new DatabaseConnectionManager())
            {
                User query_user = _dcm.Users.Where(x => x.Username == username).FirstOrDefault();
                return query_user.LastSent;
            }

        }

    }

}
