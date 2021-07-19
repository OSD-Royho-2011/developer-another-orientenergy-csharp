using System;
using System.Collections.Generic;
using OrientEnergy.Enums;

namespace OrientEnergy.Services
{
    public class AccountService : Dictionary<string, Supplier>, IAccountService
    { 
        private Dictionary<string, Supplier> _smartMeterToPricePlanAccounts;

        public AccountService(Dictionary<string, Supplier> smartMeterToPricePlanAccounts) {
            _smartMeterToPricePlanAccounts = smartMeterToPricePlanAccounts;
        }

        public Supplier GetPricePlanIdForSmartMeterId(string smartMeterId) {
            if (!_smartMeterToPricePlanAccounts.ContainsKey(smartMeterId))
            {
                return Supplier.NullSupplier;
            }
            return _smartMeterToPricePlanAccounts[smartMeterId];
        }
    }
}
