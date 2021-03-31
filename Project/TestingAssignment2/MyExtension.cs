using System;
using System.Globalization;

namespace TestingAssignment2
{
    public static class MyExtension
    {
        /// <summary>
        /// Change lowercase from uppercase
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return lowercase string.</returns>
        public static string ChangeToLowerCase(this string input)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    output += (char)(input[i] - 'A' + 'a');
                }
                else
                    output += input[i];
            }
            return output;
        }
        /// <summary>
        /// Change to uppercase
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return uppercase string.</returns>
        public static string ChangeToUpperCase(this string input)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    output += (char)(input[i] - 'a' + 'A');
                }
                else
                    output += input[i];
            }
            return output;
        }
        /// <summary>
        /// Change string to title case
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return string in title case letter</returns>
        public static string ChangeToTitleCase(this string input)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            var output = textInfo.ToTitleCase(input);
            return output;
        }
        /// <summary>
        /// Find lowercase character in string
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return no. of lowercase letters.</returns>
        public static string FindLowerCaseChar(this string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                //char c = input[i];
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    count++;
                }
                else
                    continue;
            }
            if (count != 0)
            {
                return "There are only " + count + " character in uppercase";
            }
            else
            {
                return "All are in lowercase.";
            }
        }
        /// <summary>
        /// Change first letter into capital letter
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return string with first letter capital letter</returns>
        public static string FirstLetterCapital(this string input)
        {
            if (input.Length > 0)
            {
                char[] c = input.ToCharArray();
                if (char.IsUpper(c[0]))
                {
                    c[0] = char.ToLower(c[0]);
                }
                else
                {
                    c[0] = char.ToUpper(c[0]);
                }
                return new string(c);
            }
            else
            {
                return input;
            }
        }
        /// <summary>
        /// Find total uppercase letters in string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return no. of uppercase letters.</returns>
        public static string FindUpperCaseChar(this string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {                
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    count++;
                }
                else
                    continue;
            }
            if (count != 0)
            {
                return "There are only " + count + " character in lower";
            }
            else
            {
                return "All are in uppercase.";
            }
        }
        /// <summary>
        /// Convert string to int
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return true if possible otherwise return false.</returns>
        public static bool FindStrToNum(this string input)
        {
            int no = 0;
            bool convertToNo = int.TryParse(input, out no);
            return convertToNo;

        }
        /// <summary>
        /// Remove last character from string. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return string without last character.</returns>
        public static string RemoveLastChar(this string input)
        {
            string output = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                output += input[i];
            }
            return output;
        }
        /// <summary>
        /// Give the totla word in the input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return no. of words in the string.</returns>
        public static int TotalCount(this string input)
        {
            int l = 0;
            int wrd = 1;           
            while (l <= input.Length - 1)
            {
                /* check whether the current character is white space or new line or tab character*/
                if (input[l] == ' ' || input[l] == '\n' || input[l] == '\t')
                {
                    wrd++;
                }
                l++;
            }
            return wrd;
        }
        /// <summary>
        /// Try to convert string to int.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>It shuold return result of string.</returns>
        public static int ConvertStrToInt(this string input)
        {
            int outputData = int.Parse(input);
            return outputData;
        }
    }
}
