using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiShop.Catalog.Dtos.ProductDetailDtos
{
    public class UpdateProductDetailDto
    {
        public string ProductDetailID { get; set; }
        public string ProductDescription { get; set; }
        public string ProductInfo { get; set; }
        public string ProductID { get; set; }

    }
}