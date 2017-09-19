/*----------------------------------------------------------------------------*/
/* Source File:   PALINDROMEMANAGERTEST.CS                                    */
/* Description:   Utility to manipulate palindrome numbers (Unit Tests)       */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          Sep.18/2017                                                 */
/* Last Modified: Sep.19/2017                                                 */
/* Version:       1.2                                                         */
/* Copyright (c), 2017 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 Sep.18/2017 COQ  File created.
 -----------------------------------------------------------------------------*/

using CSoftZ.Palindrome.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSoftZ.Palindrome.Test
{
    /// <summary>
    /// Unit tests for PalindromeManager class.
    /// </summary>
    [TestClass]
    public class PalindromeManagerTest
    {
        private PalindromeManager palindromeManager;

        public PalindromeManagerTest()
        {
            palindromeManager = new PalindromeManager();
        }

        [TestMethod]
        public void CheckIsPalindromeGivenZeroNumReturnsFalse()
        {
            int zero = 0;
            bool isPalindromeZero = palindromeManager.EvaluateIsPalindrome(zero);
            Assert.AreEqual(false, isPalindromeZero);
        }

        [TestMethod]
        public void CheckIsPalindromeGivenNegativeNumReturnsFalse()
        {
            int neg = -1;
            bool isPalindromeNeg = palindromeManager.EvaluateIsPalindrome(neg);
            Assert.AreEqual(false, isPalindromeNeg);
        }

        [TestMethod]
        public void CheckIsPalindromeGivenOneNumReturnsTrue()
        {
            int one = 1;
            bool isPalindromeOne = palindromeManager.EvaluateIsPalindrome(one);
            Assert.AreEqual(true, isPalindromeOne);
        }

        [TestMethod]
        public void CheckIsPalindromeGiven111NumReturnsFalse()
        {
            int num = 111;
            bool isPalindrome = palindromeManager.EvaluateIsPalindrome(num);
            Assert.AreEqual(false, isPalindrome);
        }

        [TestMethod]
        public void CheckTwoNumbersArePalindromes()
        {
            Assert.AreEqual(true, palindromeManager.EvaluateIsPalindrome(7));
            Assert.AreEqual(true, palindromeManager.EvaluateIsPalindrome(585));
        }

        [TestMethod]
        public void CheckTwoNumbersAreNotPalindromes()
        {
            Assert.AreEqual(false, palindromeManager.EvaluateIsPalindrome(2));
            Assert.AreEqual(false, palindromeManager.EvaluateIsPalindrome(19));
        }

        [TestMethod]
        public void CheckIsPalindromeGiven585NumReturnsTrue()
        {
            int num = 585;
            bool isPalindrome = palindromeManager.EvaluateIsPalindrome(num);
            Assert.AreEqual(true, isPalindrome);
        }

        [TestMethod]
        public void CheckIsPalindromeGiven2NumReturnsFalse()
        {
            int num = 2;
            bool isPalindrome = palindromeManager.EvaluateIsPalindrome(num);
            Assert.AreEqual(false, isPalindrome);
        }

        [TestMethod]
        public void EvaluateNumberPalindromeInRange1To10Has5Items()
        {
            List<PalindromeInfo> infoList = palindromeManager.EvaluatePalindromeInRange(1, 10);
            Assert.AreEqual(5, infoList.Count);
        }

        [TestMethod]
        public void EvaluateNumberPalindromeInRange1To1000000Has19Items()
        {
            List<PalindromeInfo> infoList = palindromeManager.EvaluatePalindromeInRange(1, 1000000);
            Assert.AreEqual(19, infoList.Count);
        }

        [TestMethod]
        public void EvaluateInRangeInvalidParametersNegative()
        {
            List<PalindromeInfo> infoList = palindromeManager.EvaluatePalindromeInRange(-1, -1);
            Assert.AreEqual(0, infoList.Count);
        }

        [TestMethod]
        public void EvaluateInRangeInvalidParametersFirstGreaterThanSecond()
        {
            List<PalindromeInfo> infoList = palindromeManager.EvaluatePalindromeInRange(2, 1);
            Assert.AreEqual(0, infoList.Count);
        }

        [TestMethod]
        public void EvaluateInRangeInvalidParametersUpperGreaterThanOneMillion()
        {
            List<PalindromeInfo> infoList = palindromeManager.EvaluatePalindromeInRange(1, 1000001);
            Assert.AreEqual(0, infoList.Count);
        }
    }

}
