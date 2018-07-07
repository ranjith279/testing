using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MessageStore.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var modelRepo = new Mock<IMessageRepository>();
            modelRepo.VerifyAll();
        }
    }
}
