using System;

namespace AdventOfCode2018
{
	public class Day_Template
	{

		private DateTime startTime;
		private TimeSpan duration;

		public Day_Template()
		{
			// Set Data

			// Start Timer
			startTime = DateTime.Now;

			// Do Code Stuff

			// Get Duration
			duration = DateTime.Now - startTime;

			// Print Duration
			Console.WriteLine( $"{this.GetType().Name} Solution took: {duration.TotalMilliseconds} Milliseconds.\n" );
		}
	}
}
