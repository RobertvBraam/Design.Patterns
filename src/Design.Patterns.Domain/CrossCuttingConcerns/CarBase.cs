using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Domain.CrossCuttingConcerns
{
    public class CarBase
    {
        public Guid Id { get; set; }
        public CarMake CarMake { get; set; }
    }

    public enum CarMake
    {
        Mercedes,
        Ford,
        Porche,
        Audi,
        Peugot
    }
}
