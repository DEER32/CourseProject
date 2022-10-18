using Microsoft.VisualStudio.TestTools.UnitTesting;
using PC_SHOP.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_SHOP.Pages.Tests
{
    [TestClass()]
    public class RegPageTests
    {
        [TestMethod()]
        // Верный пароль
        public void PassCheckTest_CorrectTrue()
        {
            string pwd = "Q@za_54321";
            bool acrual = Pages.RegPage.PassCheck(pwd);
            Assert.IsTrue(acrual);
        }
        [TestMethod()]
        // 8 символов - True
        public void PassCheckTest_8SymblsTrue()
        {
            string pwd = "Ne@543ma";
            bool acrual = Pages.RegPage.PassCheck(pwd);
            Assert.IsTrue(acrual);
        }
        [TestMethod()]
        // 8 символов - false
        public void PassCheckTest_8SymblsFalse()
        {
            string pwd = "Ne@543";
            bool acrual = Pages.RegPage.PassCheck(pwd);
            Assert.IsFalse(acrual);
        }
        [TestMethod()]
        // есть цифры - true
        public void PassCheckTest_HasNumbersTrue()
        {
            string pwd = "Ma@667sk_a";
            bool acrual = Pages.RegPage.PassCheck(pwd);
            Assert.IsTrue(acrual);
        }
        [TestMethod()]
        // есть цифры - false
        public void PassCheckTest_HasNumbersFalse()
        {
            string pwd = "Ma@s_a";
            bool acrual = Pages.RegPage.PassCheck(pwd);
            Assert.IsFalse(acrual);
        }
        [TestMethod()]
        // спец. символы - true
        public void PassCheckTest_SpecSymblsTrue()
        {
            string pwd = "Op99$d_l";
            bool acrual = Pages.RegPage.PassCheck(pwd);
            Assert.IsTrue(!acrual);
        }
        [TestMethod()]
        // спец. символы - false
        public void PassCheckTest_SpecSymblsFalse()
        {
            string pwd = "OP99d543";
            bool acrual = Pages.RegPage.PassCheck(pwd);
            Assert.IsFalse(acrual);
        }
        [TestMethod()]
        // есть строчне буквы - true
        public void PassCheckTest_HasUpprLettersTrue()
        {
            string pwd = "Ka!9G&_a";
            bool acrual = Pages.RegPage.PassCheck(pwd);
            Assert.IsTrue(acrual);
        }
        [TestMethod()]
        // есть строчне буквы - false
        public void PassCheckTest_HasUpprLettersFalse()
        {
            string pwd = "KA!9G&_A";
            bool acrual = Pages.RegPage.PassCheck(pwd);
            Assert.IsFalse(acrual);
        }
        [TestMethod()]
        // есть строчне буквы - true
        public void PassCheckTest_HasLwrLettersTrue()
        {
            string pwd = "P@s$W0r_d";
            bool acrual = Pages.RegPage.PassCheck(pwd);
            Assert.IsTrue(!acrual);
        }
        [TestMethod()]
        // есть строчне буквы - false
        public void PassCheckTest_HasLwrLettersFalse()
        {
            string pwd = "P@S$W0R_D";
            bool acrual = Pages.RegPage.PassCheck(pwd);
            Assert.IsFalse(acrual);
        }
    }
}