using CMS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase , iLoggable
    {
        private string _productname;

        public Product()
        {

        }

        public Product(int productId)
        {
            ProductID = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }

        public int ProductID { get; private set; }
        
        public string ProductName 
        {
            get
            {

                return _productname.InsertSpaces();
            }
            set
            {
                _productname = value;
            }
        }
        public string Log() =>
            $"{ProductID}:{ProductName} Detail : {ProductDescription} status: {EntityState.ToString()}";
        public override string ToString()
        {
            return ProductName;
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            
            return isValid;
        }

        
    }
}
