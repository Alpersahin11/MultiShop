using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiShop.Discount.Dtos
{
    public class UpdateCouponDto
    {
        public int CouponID { get; set; }

        public string Code { get; set; }

        public int Rate { get; set; }

        public bool IsActive { get; set; }

        public DateTime ValidDate { get; set; }
    }
}