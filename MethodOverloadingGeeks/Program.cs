using System;

namespace Program
{
	class MethodOverloading
	{


		//Will be discussing on Method
		//Method one

		static int Sum(int x, int y)
		{
			int result = x + y;

			return result;

		}

		//Method two.
		//method with return type and without parameter.
		//do not make use of Return type(int, string e.t.c) if there will be not return type.
		static void PrintSentence()
		{
			Console.WriteLine("Hello, Dear i am PrintSentenc");
		}

		//method three
		//method with return type but no parameter list.
		static int Subt()
		{
			int w = 16;
			int r = 10;

			int result = w - r;

			return result;
		}

		public static void Main(string[] args) {

			int f = 12;

			int m = 13;

			int c = Sum(f,m);

			int d = Subt();

			Console.WriteLine("The value of C is : " + " " + c);

			Console.WriteLine("");

			PrintSentence();

			Console.WriteLine("");

			Console.WriteLine("The sub value is " + " " + d);

		
		}
	}
}