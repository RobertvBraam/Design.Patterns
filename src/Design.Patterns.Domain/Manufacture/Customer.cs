using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Domain.Manufacture
{
    public class Customer
    {
        public Guid Id { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}
