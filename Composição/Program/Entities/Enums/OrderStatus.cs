using System;
using System.Collections.Generic;
using System.Text;

namespace Program.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayments = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
