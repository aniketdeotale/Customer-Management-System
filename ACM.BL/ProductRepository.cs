using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {

        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if(productId==2)
            {
                product.ProductName = "Sunflower";
                product.ProductDescription = "Assorted Size set of 4 Bright Sunflowers";
                product.CurrentPrice = 40;

            }
            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}
