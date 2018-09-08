using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram; 

namespace Anagram.Tests
{
    [TestClass]
    public class AnagramProgramTests
    {
        [TestMethod]
        public void ReturnSortedWord_alphabeticalOrder_True()
        {
            AnagramProgram testProgram = new AnagramProgram(); 
            string expectedString = "abcdef";
            string unsorted = "bcefda";
            string testString = testProgram.ReturnSortedWord(unsorted);
            Assert.AreEqual(expectedString, testString); 

        }
    }
}