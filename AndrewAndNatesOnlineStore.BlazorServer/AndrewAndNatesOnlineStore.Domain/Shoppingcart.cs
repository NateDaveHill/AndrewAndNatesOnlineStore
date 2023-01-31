using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AndrewAndNatesOnlineStore.Domain
{
    [Keyless]
    public class Shoppingcart
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}
