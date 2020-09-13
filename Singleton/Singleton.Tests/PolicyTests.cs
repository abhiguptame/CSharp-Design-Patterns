using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Singleton;

namespace Singleton.Tests
{
    [TestClass]
    public class PolicyTests
    {
        [TestMethod]
        public void IsPolicyASingleton()
        {
            Assert.AreSame(Policy.Instance, Policy.Instance);
        }
    }
}
