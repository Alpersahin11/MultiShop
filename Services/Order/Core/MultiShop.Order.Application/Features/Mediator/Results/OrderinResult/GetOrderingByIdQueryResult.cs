using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.Mediator.Results
{
    public class GetOrderingByIdQueryResult
    {
        public int OrderingID { get; set; }
        public string UserID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}