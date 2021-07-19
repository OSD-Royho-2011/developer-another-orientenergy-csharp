using System;
namespace OrientEnergy.Domain
{
    public class ElectricityReading
    {
        public DateTime Time { get; set; }
        public Decimal Reading { get; set; }
    }
}
