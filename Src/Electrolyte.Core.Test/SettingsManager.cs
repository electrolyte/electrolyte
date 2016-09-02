using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Electrolyte.Core.Test
{
    [TestClass]
    public class SettingsManager
    {
        [TestMethod]
        public void GetReturnsValueForFoundKey()
        {
        }

        [TestMethod]
        public void GetReturnsNullForNotFoundKey()
        {
            
        }

        [TestMethod]
        public void SetCreatesNewValueForNewKey()
        {
            
        }

        [TestMethod]
        public void SetUpdatesValueForExistingKey()
        {
            
        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void SetThrowsArgumentExceptionIfNoModuleProvided()
        {
            
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void SetThrowsArgumentExecptionIfNoKeyProvided()
        {
            
        }
    }
}
