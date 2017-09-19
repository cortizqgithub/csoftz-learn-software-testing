/*----------------------------------------------------------------------------*/
/* Source File:   PALINDROMEMANAGER.CS                                        */
/* Description:   Utility to manipulate palindrome numbers                    */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          Sep.18/2017                                                 */
/* Last Modified: Sep.18/2017                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2017 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 Sep.18/2017 COQ  File created.
 -----------------------------------------------------------------------------*/
using System;
using CSoftZ.Palindrome.Domain;
using System.Collections.Generic;

namespace CSoftZ.Palindrome
{
    public class PalindromeManager
    {

        /// <summary>
        /// Receives string and returns the string with its letters reversed.
        /// </summary>
        private string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        /// <summary>
        /// Given the string verifies if it is a palindrome
        /// </summary>
        /// <param name="data"></param>
        /// <returns>True if Palindrome</returns>
        private bool IsPalindromeString(string data)
        {
            string reversedString = ReverseString(data);
            return data == reversedString;
        }

        /// <summary>
        ///  Evaluates if the data contained which means if is a string representation of a number
        /// and its binary representation is both palindromes.
        /// </summary>
        /// <param name="number">Data to evaluate</param>
        /// <returns>True if the string number representation is palindrome and its binary number
        /// representation is palindrome
        /// </returns>
        public bool EvaluateIsPalindrome(int number)
        {
            if (number <= 0)
            {
                return false;
            }

            return IsPalindromeString(Convert.ToString(number)) &&
                   IsPalindromeString(Convert.ToString(number, 2));
        }

        /**
             * Returns a list of Palindrome Numbers (both decimal and binary number must be a palindrome).
             * The evaluation happens in the range x through y, and both x and y must be integer and x <= y.
             * <p>
             * Given a range of numbers in (x..y) where x <= y and valid integer values.
             * <p>
             * 1 <= x <= 1000000
             * 1 <= y <= 1000000
             *
             * @param x Range start
             * @param y Range End
             * @return If x > y then an empty list is returned. If any parameter is
             * outside range then and empty list is returned as well.
             */

        /// <summary>
        ///  Returns a list of Palindrome Numbers (both decimal and binary number must be a palindrome).
        ///  The evaluation happens in the range x through y, and both x and y must be integer and x <= y.
        ///  Given a range of numbers in (x..y) where x <= y and valid integer values.
        ///
        ///      1 <= x <= 1000000
        ///      1 <= y <= 1000000
        /// </summary>
        /// <param name="x">Range Start</param>
        /// <param name="y">Range End</param>
        /// <returns>If x > y then an empty list is returned. If any parameter is
        /// outside range then and empty list is returned as well.
        /// </returns>
        public List<PalindromeInfo> EvaluatePalindromeInRange(int x, int y)
        {
            List<PalindromeInfo> infoList = new List<PalindromeInfo>();
            bool rangeStart = (x >= 1 && x <= 1000000);
            bool rangeEnd = (x >= 1 && y <= 1000000);
            if (rangeStart && rangeEnd)
            {
                while (x <= y)
                {
                    if (EvaluateIsPalindrome(x))
                    {
                        String xStr = Convert.ToString(x);
                        infoList.Add(new PalindromeInfo(xStr, ReverseString(xStr)));
                    }
                    x++;
                }
            }
            return infoList;
        }
    }
}