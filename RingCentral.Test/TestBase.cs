using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingCentral.Test
{
    public class TestBase
    {
        public static RestClient rc = new RestClient(Config.Instance.appKey, Config.Instance.appSecret, Config.Instance.server);

        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            var temp = rc.Authorize(Config.Instance.username, Config.Instance.extension, Config.Instance.password).Result;
        }
    }
}
