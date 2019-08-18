using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Domain.Ports
{
    public interface ISuplier
    {
        Guid Id { get; set; }
        string Name { get; set; }
        List<CarPart> GetCarParts();
    }

    public enum CarPart
    {
        Wheel,
        Engine,
        Chassis
    }
}
