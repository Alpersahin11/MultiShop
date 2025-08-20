using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Results.AdressResults
{
    public class GetAddressQueryResult
    {
        public int AdressID { get; set; }
        public string UserID { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Detail { get; set; }
    }
}