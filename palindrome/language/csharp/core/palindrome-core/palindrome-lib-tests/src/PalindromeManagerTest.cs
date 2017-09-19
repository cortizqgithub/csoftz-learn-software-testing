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
using System.Collections.Generic;
using Xunit;

namespace CSoftZ.Palindrome.Test
{
    /// <summary>
    /// Unit tests for PalindromeManager class.
    /// </summary>
    public class PalindromeManagerTest
    {
        private PalindromeManager palindromeManager;

        public PalindromeManagerTest()
        {
            palindromeManager = new PalindromeManager();
        }

        [Fact]
        public void CheckIsPalindromeGivenZeroNumReturnsFalse()
        {
            int zero = 0;
            bool isPalindromeZero = palindromeManager.EvaluateIsPalindrome(zero);
            Assert.Equal(false, isPalindromeZero);
        }

        [Fact]
        public void CheckIsPalindromeGivenNegativeNumReturnsFalse()
        {
            int neg = -1;
            bool isPalindromeNeg = palindromeManager.EvaluateIsPalindrome(neg);
            Assert.Equal(false, isPalindromeNeg);
        }

        [Fact]
        public void CheckIsPalindromeGivenOneNumReturnsTrue()
        {
            int one = 1;
            bool isPalindromeOne = palindromeManager.EvaluateIsPalindrome(one);
            Assert.Equal(true, isPalindromeOne);
        }

        [Fact]
        public void CheckIsPalindromeGiven111NumReturnsFalse()
        {
            int num = 111;
            bool isPalindrome = palindromeManager.EvaluateIsPalindrome(num);
            Assert.Equal(false, isPalindrome);
        }

        [Fact]
        public void CheckTwoNumbersArePalindromes()
        {
            Assert.Equal(true, palindromeManager.EvaluateIsPalindrome(7));
            Assert.Equal(true, palindromeManager.EvaluateIsPalindrome(585));
        }

        [Fact]
        public void CheckTwoNumbersAreNotPalindromes()
        {
            Assert.Equal(false, palindromeManager.EvaluateIsPalindrome(2));
            Assert.Equal(false, palindromeManager.EvaluateIsPalindrome(19));
        }

        [Fact]
        public void CheckIsPalindromeGiven585NumReturnsTrue()
        {
            int num = 585;
            bool isPalindrome = palindromeManager.EvaluateIsPalindrome(num);
            Assert.Equal(true, isPalindrome);
        }

        [Fact]
        public void CheckIsPalindromeGiven2NumReturnsFalse()
        {
            int num = 2;
            bool isPalindrome = palindromeManager.EvaluateIsPalindrome(num);
            Assert.Equal(false, isPalindrome);
        }

        [Fact]
        public void EvaluateNumberPalindromeInRange1To10Has5Items()
        {
            List<PalindromeInfo> infoList = palindromeManager.EvaluatePalindromeInRange(1, 10);
            Assert.Equal(5, infoList.Count);
        }

        [Fact]
        public void EvaluateNumberPalindromeInRange1To1000000Has19Items()
        {
            List<PalindromeInfo> infoList = palindromeManager.EvaluatePalindromeInRange(1, 1000000);
            Assert.Equal(19, infoList.Count);
        }

        [Fact]
        public void EvaluateInRangeInvalidParametersNegative()
        {
            List<PalindromeInfo> infoList = palindromeManager.EvaluatePalindromeInRange(-1, -1);
            Assert.Equal(0, infoList.Count);
        }

        [Fact]
        public void EvaluateInRangeInvalidParametersFirstGreaterThanSecond()
        {
            List<PalindromeInfo> infoList = palindromeManager.EvaluatePalindromeInRange(2, 1);
            Assert.Equal(0, infoList.Count);
        }

        [Fact]
        public void EvaluateInRangeInvalidParametersUpperGreaterThanOneMillion()
        {
            List<PalindromeInfo> infoList = palindromeManager.EvaluatePalindromeInRange(1, 1000001);
            Assert.Equal(0, infoList.Count);
        }
    }
}
