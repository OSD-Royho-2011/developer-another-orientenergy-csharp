using OrientEnergy.Enums;

namespace OrientEnergy.Services
{
    public interface IAccountService
    {
        Supplier GetPricePlanIdForSmartMeterId(string smartMeterId);
    }
}