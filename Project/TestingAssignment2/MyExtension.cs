using System;
using System.Globalization;

namespace TestingAssignment2
{
    public static class MyExtension
    {

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
        public static string ChangeToTitleCase(this string input)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            var output = textInfo.ToTitleCase(input);
            return output;
        }
        public static string FindLowerCaseChar(this string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];


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
        public static bool FindStrToNum(this string input)
        {
            int no = 0;
            bool convertToNo = int.TryParse(input, out no);
            return convertToNo;

        }
        public static string RemoveLastChar(this string input)
        {
            string output = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                output += input[i];
            }
            return output;
        }
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
        public static int ConvertStrToInt(this string input)
        {
            int outputData = int.Parse(input);
            return outputData;
        }
    }
}
