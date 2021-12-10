using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018
{
	class Day3
	{
		public void Part1()
		{
			// Set Data
			DateTime startTime;
			TimeSpan duration;

			// Start Timer
			startTime = DateTime.Now;

			// Do code stuff

			// Get Duration
			duration = DateTime.Now - startTime;

			// Print Duration
			Console.WriteLine( $"Part 1 Solution took: {duration.TotalMilliseconds} Milliseconds." );
		}
	}
}
