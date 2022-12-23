using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTests.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            string password = "ASqw12$$";
            bool expected = true;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_4Symbols_ReturnsTrue()
        {
            string password = "ASqw12$$";
            bool expected = true;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }
        public void Check_4Symbols_Returns2True()
        {
            string password = "ASDq123$";
            bool expected = true;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }
    }
}