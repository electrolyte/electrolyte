using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Electrolyte.Core.Test
{
    [TestClass]
    public class LoggingLog
    {
        [TestInitialize]
        public void TestInitialize()
        {
            // Setup for test
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // CLeanup after test runs
        }

        [TestMethod]
        public void DebugFunctionCallsUnderlyingDebugFormatFunction()
        {
            var log = new Electrolyte.Core.Logging.Log();
            log.Debug("HI!");
        }
    }
}
