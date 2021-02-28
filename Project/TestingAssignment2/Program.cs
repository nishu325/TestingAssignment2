using System;

namespace TestingAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyExtension.ChangeToTitleCase("hello world program"));
            Console.WriteLine(MyExtension.ChangeToLowerCase("SYSTEM"));
            Console.WriteLine(MyExtension.ChangeToUpperCase("pc"));
            Console.WriteLine(MyExtension.FirstLetterCapital("computer"));
            Console.WriteLine(MyExtension.RemoveLastChar("LaptoP"));
            Console.WriteLine(MyExtension.TotalCount("Key board mouse"));
            Console.WriteLine(MyExtension.FindLowerCaseChar("sonG"));
            Console.WriteLine(MyExtension.FindUpperCaseChar("SONg"));
            Console.WriteLine(MyExtension.ConvertStrToInt("100"));
            Console.WriteLine();
            string strToNum = "charger";
            bool output = MyExtension.FindStrToNum(strToNum);
            if(output==true)
            {
                Console.WriteLine("Possible");
            }
            else
            {
                Console.WriteLine("Not possible");
            }            
            Console.ReadKey();
        }
    }
}
