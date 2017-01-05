using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmailLoggerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSend()
        {
            var s = LogUtil.MailLogger.Send("1dttyopmail@yopmail.com", "from csharp", "from csharp");
            Assert.AreEqual(true, s);
        }

        [TestMethod]
        public void TestSendTohMailServer()
        {
            var s = LogUtil.MailLogger.SendTohMailServer("user3@local.com", "from csharp to hMail", "from csharp to hMail");
            Assert.AreEqual(true, s);
        }
    }
}
