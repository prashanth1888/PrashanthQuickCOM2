using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrashanthquickLIB.Model
{
    public class OrdersModel
    {

        public int OrderId { get; set; }

        public int? CustomerId { get; set; }

        public int? EmployeId { get; set; }

        public string? OrderDate { get; set; }

        public int? ShipperId { get; set; }

       
    }
}
