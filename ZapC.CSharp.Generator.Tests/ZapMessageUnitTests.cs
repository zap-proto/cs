using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZapC.CSharp.Generator.Tests
{
    [TestClass]
    [TestCategory("Coverage")]
    public class ZapMessageUnitTests
    {
        [TestMethod]
        public void ParseError()
        {
            var msg = new ZapMessage(@"f:\code\invalid.zap:5:1: error: Parse error.");
            Assert.AreEqual(@"f:\code\invalid.zap:5:1: error: Parse error.", msg.FullMessage);
            Assert.IsTrue(msg.IsParseSuccess);
            Assert.AreEqual(@"f:\code\invalid.zap", msg.FileName);
            Assert.AreEqual(5, msg.Line);
            Assert.AreEqual(1, msg.Column);
            Assert.AreEqual(0, msg.EndColumn);
            Assert.AreEqual("error", msg.Category);
            Assert.AreEqual("Parse error.", msg.MessageText);
        }

        [TestMethod]
        public void ColumnSpan()
        {
            var msg = new ZapMessage(@"f:\code\invalid.zap:10:7-8: error: Duplicate ordinal number.");
            Assert.IsTrue(msg.IsParseSuccess);
            Assert.AreEqual(@"f:\code\invalid.zap", msg.FileName);
            Assert.AreEqual(10, msg.Line);
            Assert.AreEqual(7, msg.Column);
            Assert.AreEqual(8, msg.EndColumn);
            Assert.AreEqual("error", msg.Category);
            Assert.AreEqual("Duplicate ordinal number.", msg.MessageText);
        }

        [TestMethod]
        public void NoSuchFile()
        {
            var msg = new ZapMessage(@"C:\ProgramData\chocolatey\lib\zap\tools\zap-tools-win32-0.7.0\zap.exe compile: doesnotexist.zap: no such file");
            Assert.IsFalse(msg.IsParseSuccess);
            Assert.AreEqual(@"C:\ProgramData\chocolatey\lib\zap\tools\zap-tools-win32-0.7.0\zap.exe compile: doesnotexist.zap: no such file", msg.FullMessage);
        }

        [TestMethod]
        public void NoId()
        {
            var msg = new ZapMessage(@"empty.zap:1:1: error: File does not declare an ID.  I've generated one for you.  Add this line to your file: @0xc82955a0c779197d;");
            Assert.IsTrue(msg.IsParseSuccess);
            Assert.AreEqual("empty.zap", msg.FileName);
            Assert.AreEqual(1, msg.Line);
            Assert.AreEqual(1, msg.Column);
            Assert.AreEqual("error", msg.Category);
            Assert.AreEqual("File does not declare an ID.  I've generated one for you.  Add this line to your file: @0xc82955a0c779197d;", msg.MessageText);
        }

        [TestMethod]
        public void AnnoyingNTFSAlternateDataStream1()
        {
            var msg = new ZapMessage(@"3:2:1:1: error: File does not declare an ID.  I've generated one for you.  Add this line to your file: @0xc82955a0c779197d;");
            Assert.IsTrue(msg.IsParseSuccess);
            Assert.AreEqual("3:2", msg.FileName);
            Assert.AreEqual(1, msg.Line);
            Assert.AreEqual(1, msg.Column);
            Assert.AreEqual("error", msg.Category);
            Assert.AreEqual("File does not declare an ID.  I've generated one for you.  Add this line to your file: @0xc82955a0c779197d;", msg.MessageText);
        }

        [TestMethod]
        public void AnnoyingNTFSAlternateDataStream2()
        {
            var msg = new ZapMessage(@"c:\3:2:1:1: error: File does not declare an ID.  I've generated one for you.  Add this line to your file: @0xc82955a0c779197d;");
            Assert.IsTrue(msg.IsParseSuccess);
            Assert.AreEqual(@"c:\3:2", msg.FileName);
            Assert.AreEqual(1, msg.Line);
            Assert.AreEqual(1, msg.Column);
            Assert.AreEqual("error", msg.Category);
            Assert.AreEqual("File does not declare an ID.  I've generated one for you.  Add this line to your file: @0xc82955a0c779197d;", msg.MessageText);
        }

        [TestMethod]
        public void AnnoyingNTFSAlternateDataStream3()
        {
            var msg = new ZapMessage(@"\\?\c:\3:2:1:1: error: File does not declare an ID.  I've generated one for you.  Add this line to your file: @0xc82955a0c779197d;");
            Assert.IsTrue(msg.IsParseSuccess);
            Assert.AreEqual(@"\\?\c:\3:2", msg.FileName);
            Assert.AreEqual(1, msg.Line);
            Assert.AreEqual(1, msg.Column);
            Assert.AreEqual("error", msg.Category);
            Assert.AreEqual("File does not declare an ID.  I've generated one for you.  Add this line to your file: @0xc82955a0c779197d;", msg.MessageText);
        }

        [TestMethod]
        public void AnnoyingNTFSAlternateDataStream4()
        {
            var msg = new ZapMessage(@"1:2-3:10:7-8: error: Duplicate ordinal number.");
            Assert.IsTrue(msg.IsParseSuccess);
            Assert.AreEqual(@"1:2-3", msg.FileName);
            Assert.AreEqual(10, msg.Line);
            Assert.AreEqual(7, msg.Column);
            Assert.AreEqual(8, msg.EndColumn);
            Assert.AreEqual("error", msg.Category);
            Assert.AreEqual("Duplicate ordinal number.", msg.MessageText);
        }
    }
}
