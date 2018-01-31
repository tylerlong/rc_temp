using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace RingCentral.Test
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void GetAccount()
        {
            var rc = TestBase.rc;
            var temp = rc.Authorize(Config.Instance.username, Config.Instance.extension, Config.Instance.password).Result;
            var account = rc.Restapi().Account().Get().Result;
            Assert.IsNotNull(account);
            Assert.IsNotNull(account.serviceInfo);
        }
    }
}
