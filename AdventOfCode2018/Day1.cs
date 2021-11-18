﻿using System;

namespace AdventOfCode2018
{
	public class Day1
	{

		private DateTime startTime;
		private TimeSpan duration;

		int[] data;
		const int SIZE = 4096;

		public Day1()
		{
			// Set Data
			data = new int[SIZE * SIZE];

			// Start Timer
			startTime = DateTime.Now;

			// Do Code Stuff
			for( int x = 0; x < SIZE; x++ )
			{
				for( int y = 0; y < SIZE; y++ )
				{
					int index = x * SIZE + y;

					data[index] = 1;
				}
			}

			// Get Duration
			duration = DateTime.Now - startTime;

			// Print Duration
			Console.WriteLine( $"{this.GetType().Name} Solution took: {duration.TotalMilliseconds} Milliseconds.\n" );
		}
	}
}
