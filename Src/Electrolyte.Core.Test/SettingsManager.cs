using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Electrolyte.Core.Test
{
    [TestClass]
    public class SettingsManager
    {
        private Electrolyte.Core.Logging.ILog _log;

        [TestInitialize]
        public void TestInitialize()
        {
            // We're not testing logging so we'll just mock out the object
            var mock = new Moq.Mock<Electrolyte.Core.Logging.ILog>();
            _log = mock.Object;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Remove the set test file after each run
            if (System.IO.File.Exists(@"./TestFiles/set.yaml"))
            {
                System.IO.File.Delete(@"./TestFiles/set.yaml");
            }
        }

        [TestMethod]
        public void GetReturnsValueForFoundKey()
        {
            var manager = new Electrolyte.Core.Settings.Manager(_log, @"./TestFiles/get.yaml");
            var value = manager.Get("SampleModule", "SampleKey");
            Assert.AreEqual("SampleValue", value);
        }

        [TestMethod]
        public void GetReturnsNullForNotFoundModule()
        {
            var manager = new Electrolyte.Core.Settings.Manager(_log, @"./TestFiles/get.yaml");
            var value = manager.Get("SampleBadModule", "SampleKey");
            Assert.IsNull(value);
        }

        [TestMethod]
        public void GetReturnsNullForNotFoundKey()
        {
            var manager = new Electrolyte.Core.Settings.Manager(_log, @"./TestFiles/get.yaml");
            var value = manager.Get("SampleModule", "SampleBadKey");
            Assert.IsNull(value);
        }

        [TestMethod]
        public void SetCreatesNewValueForNewKey()
        {
            string[] expected = new string[]
            {
                "SampleModule:",
                "  SampleKey: SampleValue"
            };
            var manager = new Electrolyte.Core.Settings.Manager(_log, @"./TestFiles/set.yaml");
            manager.Set("SampleModule", "SampleKey", "SampleValue");

            var actual = System.IO.File.ReadAllLines(@"./TestFiles/set.yaml");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetUpdatesValueForExistingKey()
        {
            string[] expected = new string[]
            {
                "SampleModule:",
                "  SampleKey: SampleUpdateValue"
            };
            var manager = new Electrolyte.Core.Settings.Manager(_log, @"./TestFiles/set.yaml");
            manager.Set("SampleModule", "SampleKey", "SampleValue");
            manager.Set("SampleModule", "SampleKey", "SampleUpdateValue");

            var actual = System.IO.File.ReadAllLines(@"./TestFiles/set.yaml");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void SetThrowsArgumentExceptionIfNoModuleProvided()
        {
            var manager = new Electrolyte.Core.Settings.Manager(_log, string.Empty);
            manager.Set(string.Empty, string.Empty, string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void SetThrowsArgumentExecptionIfNoKeyProvided()
        {
            var manager = new Electrolyte.Core.Settings.Manager(_log, string.Empty);
            manager.Set("module", string.Empty, string.Empty);
        }
    }
}
