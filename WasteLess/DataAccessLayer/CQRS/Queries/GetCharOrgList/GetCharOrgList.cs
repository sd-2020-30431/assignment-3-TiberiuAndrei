using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;
using DataAccessLayer.DataContext;
using System.Linq;
using DataAccessLayer.CQRS.Queries;

namespace DataAccessLayer.CQRS.Queries.GetCharOrgList
{
    public class GetCharOrgList
    {
        //returns the current available charity organisations
        public List<CharOrg> query()
        {
            using (var _dcm = new DatabaseConnectionManager())
            {
                IEnumerable<CharOrg> charOrgList = (from x in _dcm.CharOrgs select x);
                return charOrgList.ToList();
            }

        }

    }

}
