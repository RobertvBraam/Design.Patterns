using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Domain.CrossCuttingConcerns
{
    public class CustomerBase
    {
        public Guid Id { get; set; }
        string Name { get; set; }
        public IEnumerable<CarBase> Cars { get; set; }
    }
}
