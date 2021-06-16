using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace FizzBuzzDellProject
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(FizzBuzz(0));    //0

			Console.WriteLine(FizzBuzz(1));    //OOP

			Console.WriteLine(FizzBuzz(105));  //OOP | Fizz | Buzz | Hello

			Console.WriteLine(FizzBuzz(45));   //OOP | Fizz | Buzz | World 

			Console.WriteLine(FizzBuzz(21));   //OOP | Fizz | Hello

			Console.WriteLine(FizzBuzz(189));  //OOP | Fizz | Hello | World

			Console.WriteLine(FizzBuzz(105));  //OOP | Buzz | Hello 

			Console.WriteLine("========================== \n");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine( FizzBuzz(i));
            }
        }

		public static string FizzBuzz(int num)
		{
			Dictionary<int, string> dict = new Dictionary<int, string>();
			dict.Add(1, "OOP");
			dict.Add(3, "Fizz");
			dict.Add(5, "Buzz");
			dict.Add(7, "Hello");
			dict.Add(9, "World");

			List<int> keys = dict.Keys.ToList();
			List<int> divisibleKeys = new List<int>();

			//find all the keys that are divisible by the number
			foreach(var key in keys)
            {
				if (num % key == 0)
					divisibleKeys.Add(key);
            }

			//if nothing is divisible
			if (divisibleKeys.Count == 0 || num == 0)
				return num.ToString();

			//if there is a divisible number
			else 
            {
				StringBuilder returnStatement = new StringBuilder();

				returnStatement.Append( num );

				//Append all the values from the keys and then return the string
				foreach (var key in divisibleKeys)
				{
					returnStatement.Append( " | " + dict[key]  );
				}

				return returnStatement.ToString();
			}
		}
	}
}




