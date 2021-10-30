
using System;

namespace Discount.Grpc.Entities
{
    public class Coupon
    {
        public Int32 Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public Int32 Amount { get; set; }
    }
}
