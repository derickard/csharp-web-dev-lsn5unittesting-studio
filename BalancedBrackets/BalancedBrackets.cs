using System;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */
        public static bool HasBalancedBrackets(string str)
        {
            int openBrackets = 0;
            int closeBrackets = 0;
            foreach (char ch in str.ToCharArray())
            {
                if (ch == '[')
                {
                    openBrackets++;
                }
                else if (ch == ']')
                {
                    if(openBrackets == 0)
                    {
                        return false;
                    }
                    closeBrackets++;
                }
            }
            return openBrackets == closeBrackets;
        }

        //public static bool HasBalancedBrackets(string str)
        //{
        //    List<string> listMatch = new List<string>();

        //    if (str.Length > 0)
        //    {
        //        // Get all brackets into an list
        //        var arr = Regex.Matches(str, @"[\[\]]").OfType<Match>().Select(m => m.Groups[0].Value).ToArray();
        //        listMatch = arr.ToList();

        //        // No brackets returns true
        //        if(listMatch.Count == 0)
        //        {
        //            return true;
        //        }

        //        // Make sure first bracket is opening bracket
        //        List<string> distinct = listMatch.Distinct().ToList();

        //        return listMatch.Count % 2 == 0 && Equals(distinct[0], "[");
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

    }
}
