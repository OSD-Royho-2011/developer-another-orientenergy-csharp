using System;
using System.Collections.Generic;
using OrientEnergy.Enums;
using OrientEnergy.Services;
using Xunit;

namespace OrientEnergy.Tests
{
    public class AccountServiceTest
    {
        private const Supplier PRICE_PLAN_ID = Supplier.NeurondPower;
        private const String SMART_METER_ID = "orient-sm-id";

        private AccountService accountService;

        public AccountServiceTest()
        {
            Dictionary<String, Supplier> smartMeterToPricePlanAccounts = new Dictionary<string, Supplier>();
            smartMeterToPricePlanAccounts.Add(SMART_METER_ID, PRICE_PLAN_ID);

            accountService = new AccountService(smartMeterToPricePlanAccounts);
        }

        [Fact]
        public void GivenTheSmartMeterIdReturnsThePricePlanId()
        {
            var result = accountService.GetPricePlanIdForSmartMeterId("orient-sm-id");
            Assert.Equal(Supplier.NeurondPower, result);
        }

        [Fact]
        public void GivenAnUnknownSmartMeterIdReturnsANullSupplier()
        {
            var result = accountService.GetPricePlanIdForSmartMeterId("bob-carolgees");
            Assert.Equal(Supplier.NullSupplier, result);
        }
    }
}
