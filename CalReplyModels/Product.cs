using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalReplyModels
{
    /// <summary>
    /// Product model class
    /// </summary>
    public class Product
    {
        //Id for the product
        public int Id { get; set; }

        //Product name
        public string Name { get; set; }

        //Product category
        public string Category { get; set; }
        
        //Product price
        public decimal Price { get; set; }
    }
}
