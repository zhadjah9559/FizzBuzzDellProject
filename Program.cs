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
			Console.WriteLine(FizzBuzz(-44));  //-44 is outside of constraints

			Console.WriteLine(FizzBuzz(0));    //0

			Console.WriteLine(FizzBuzz(1));    //OOP

			Console.WriteLine(FizzBuzz(3));    //OOP | Fizz

			Console.WriteLine(FizzBuzz(5));    //OOP | Buzz

			Console.WriteLine(FizzBuzz(7));    //OOP | Hello

			Console.WriteLine(FizzBuzz(9));    //OOP | Fizz | World

			Console.WriteLine(FizzBuzz(21));   //OOP | Fizz | Hello

			Console.WriteLine(FizzBuzz(15));   //OOP | Fizz | Buzz

			Console.WriteLine(FizzBuzz(45));   //OOP | Fizz | Buzz | World 

			Console.WriteLine(FizzBuzz(105));  //105 is outside of Constraints

			Console.WriteLine("========================== \n");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine( FizzBuzz(i));
            }
        }

		public static string FizzBuzz(int num)
		{
			//Adhereing to the constraints of the program. 
			//No negative numbers and all numbers in between 0 and 100
			if(num < 0 || num > 100)
            {
				return $"{num} is outside of constraints";
            }

		    //The Dictionary's keys will help keep track of which numbers 
			//are divisible. Making it easy to use the keys to access the values
			//of the the divisible numbers.
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

			//if nothing is divisible or zero is the input
			if (divisibleKeys.Count == 0 || num == 0)
				return num.ToString();

			//if there is at least one divisible number 
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




