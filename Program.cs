using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FizzBuzzDellProject
{
    class Program
    {
        static void Main(string[] args)
        {
			//Regex regex = new Regex("");





			Console.WriteLine(FizzBuzz(1));  //1

			Console.WriteLine(FizzBuzz(2));  //2

			Console.WriteLine(FizzBuzz(3));  //Fizz

			Console.WriteLine(FizzBuzz(5));  //buzz

			Console.WriteLine(FizzBuzz(-3)); //Fizz
			for (int i = 1; i < 100; i++)
			{
				Console.WriteLine(i + ";" + FizzBuzz(i));
			}

			Console.WriteLine(FizzBuzz(105));
		}

		public static string FizzBuzz(int num)
		{
			Dictionary<int, string> dict = new Dictionary<int, string>();

			dict.Add(3, "Fizz");
			dict.Add(5, "Buzz");
			dict.Add(7, "Hello");
			dict.Add(9, "World");

			//if the user input is not div by any number
			if (!dict.ContainsKey(num))
				return num.ToString();
			 

			//if user input is div by one of the keys
			else /*if( dict.ContainsKey(num) == true )*/
				



			if (num % 3 == 0 && num % 5 == 0 && num % 7 == 0)
				return "FizzBuzz Hello";

			else if (num % 3 == 0 && num % 5 == 0)
				return "FizzBuzz";

			else if (num % 7 == 0)
				return "Hello";

			else if (num % 3 == 0)
				return "Fizz";

			else if (num % 5 == 0)
				return "buzz";
			else
				return num.ToString();
		}
	}

}




