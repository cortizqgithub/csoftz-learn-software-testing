/*----------------------------------------------------------------------------*/
/* Source File:   PALINDROMEINFO.JAVA                                         */
/* Description:   Given an integer number, stores the string representation   */
/*                out of it as well its binary representation.                */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          Sep.19/2017                                                 */
/* Last Modified: Sep.19/2017                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2017 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 Sep.10/2017 COQ  File created.
 -----------------------------------------------------------------------------*/

using System;

namespace CSoftZ.Palindrome.Domain
{
    public class PalindromeInfo
    {
        public string Number { get; set; }
        public string NumberAsBinary { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public PalindromeInfo()
        {
            this.Number = "";
            this.NumberAsBinary = "";
        }

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="number">Value of integer as String</param>
        /// <param name="numberAsBinary">Value of integer as binary String</param>
        public PalindromeInfo(string number, string numberAsBinary)
        {
            this.Number = number ?? throw new ArgumentNullException(nameof(number));
            this.NumberAsBinary = numberAsBinary ?? throw new ArgumentNullException(nameof(numberAsBinary));
        }
    }
}
