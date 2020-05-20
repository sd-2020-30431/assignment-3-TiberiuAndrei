using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;

namespace DataAccessLayer.CQRS.Queries.GetCharOrgList
{
    public class GetCharOrgListResponse
    {
        public List<CharOrg> response;

        public GetCharOrgListResponse(List<CharOrg> response)
        {
            this.response = response;
        }

    }
}
