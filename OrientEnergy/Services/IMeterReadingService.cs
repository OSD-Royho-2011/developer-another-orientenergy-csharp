using System.Collections.Generic;
using OrientEnergy.Domain;

namespace OrientEnergy.Services
{
    public interface IMeterReadingService
    {
        List<ElectricityReading> GetReadings(string smartMeterId);
        void StoreReadings(string smartMeterId, List<ElectricityReading> electricityReadings);
    }
}