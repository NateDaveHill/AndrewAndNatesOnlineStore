using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AndrewAndNatesOnlineStore.Domain
{
    public class Shoppingcart
    {
        public int CartId { get; set; }
        public List<Product> ProductList { get; set; }
    }
}
