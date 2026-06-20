using Zap.Rpc;
using Zap_test.Zap.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zap.Net.Runtime.Tests
{
    [TestClass]
    [TestCategory("Coverage")]
    public class CapabilityReflectionTests
    {
        [TestMethod]
        public void ValidateCapabilityInterface()
        {
            Assert.ThrowsException<ArgumentNullException>(() => CapabilityReflection.ValidateCapabilityInterface(null));
            CapabilityReflection.ValidateCapabilityInterface(typeof(ITestInterface));
            Assert.ThrowsException<InvalidCapabilityInterfaceException>(() => CapabilityReflection.ValidateCapabilityInterface(typeof(CapabilityReflectionTests)));
        }

        [TestMethod]
        public void IsValidCapabilityInterface()
        {
            Assert.ThrowsException<ArgumentNullException>(() => CapabilityReflection.IsValidCapabilityInterface(null));
            Assert.IsTrue(CapabilityReflection.IsValidCapabilityInterface(typeof(ITestInterface)));
            Assert.IsFalse(CapabilityReflection.IsValidCapabilityInterface(typeof(CapabilityReflectionTests)));
        }
    }
}
