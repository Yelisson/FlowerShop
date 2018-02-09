using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopModel
{
    class ProductComponent
    {
        public int id { get; set; }
        public int productId { set; get; }
        public int componentId { get; set; }
        public int count { get; set; }
    }
}
