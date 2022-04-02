using System;
namespace edabitChallanages
{
	public class Program
	{

		public static void Main(string[] args)
        {
			//Console.WriteLine($"{IsEqual(10,10)}");
			Console.WriteLine($"{GiveMeSomething("Hola Mundo")}");

		}
		
		
		public static bool IsEqual(int num1, int num2)
		{
			bool Equal = false;
			if (num1 == num2)
			{
				Equal = true;
			}
			return Equal;
			
		}

		public static string GiveMeSomething(string a)
		{
			string result = "something " + a;
			return result;
		}
	}
}



