using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExercise
{
	class Program
	{
		public struct Number
		{
			public decimal Amount;
		}

		static void Main(string[] args)
		{
			Number number = new Number();
			number.Amount = 5.56m;
			Console.WriteLine(number.Amount);
			Console.ReadLine();
		}
	}
}
