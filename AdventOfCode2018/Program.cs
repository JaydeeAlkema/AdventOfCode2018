using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018
{
	public class Program
	{
		static void Main( string[] args )
		{
			Day1 day1 = new Day1();
			Day2 day2 = new Day2();
			Day3 day3 = new Day3();

			Console.WriteLine( "\n############### DAY 1 ###############" );
			day1.Part1();
			Console.WriteLine();
			day1.Part2();
			Console.WriteLine( "______________________________________\n" );

			Console.WriteLine( "\n############### DAY 2 ###############" );
			day2.Part1();
			Console.WriteLine();
			day2.Part2();
			Console.WriteLine( "______________________________________\n" );

			Console.WriteLine( "\n############### DAY 3 ###############" );
			day3.Part1();
			Console.WriteLine();
			day3.Part2();
			Console.WriteLine( "______________________________________\n" );

		}
	}
}
