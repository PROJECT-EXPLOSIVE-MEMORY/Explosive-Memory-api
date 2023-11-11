using System.Collections.Generic;
using System.Linq;
using Explosive.Memory.Domain.Catalog;

namespace Explosive.Memory.Domain.Orders
{
        public class OrderItem
    {
        public int Id {get; set;}
        public int itemId{get; set;}
        public virtual Item Item {get; set;}
        public int Quantity {get; set;}
        public decimal Price => Item.Price * Quantity; 
    }
}
