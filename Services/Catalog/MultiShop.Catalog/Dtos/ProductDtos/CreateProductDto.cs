using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiShop.Catalog.Dtos.ProductDetailDtos
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImgUrl { get; set; }
        public string ProductDescription { get; set; }
        public string CategoryID { get; set; }
    }
}