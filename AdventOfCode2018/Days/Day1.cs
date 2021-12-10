using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2018
{
	public class Day1
	{
		public void Part1()
		{
			// Input
			DateTime startTime;
			TimeSpan duration;

			List<int> data = new List<int>();
			int frequency = 0;

			string[] dataArray = System.IO.File.ReadAllLines( "../../Days/Inputs/Day1_Input.txt" );
			foreach( string dataText in dataArray )
			{
				data.Add( Convert.ToInt32( dataText.Trim() ) );
			}

			// Start Timer
			startTime = DateTime.Now;

			// Do Code Stuff
			for( int i = 0; i < data.Count; i++ )
			{
				frequency += data[i];
			}

			// Get Duration
			duration = DateTime.Now - startTime;

			// Print Duration
			Console.WriteLine( $"Part 1 Solution took: {duration.TotalMilliseconds} Milliseconds." );
			Console.WriteLine( $"Part 1 Ouput: {frequency}" );
		}

		public void Part2()
		{
			// Input
			DateTime startTime;
			TimeSpan duration;

			List<int> data = new List<int>();
			int frequency = 0;
			bool found = false;

			string[] dataArray = System.IO.File.ReadAllLines( "../../Days/Inputs/Day1_Input.txt" );
			foreach( string dataText in dataArray )
			{
				data.Add( Convert.ToInt32( dataText.Trim() ) );
			}

			// Start Timer
			startTime = DateTime.Now;

			// Do Code Stuff
			var frequencies = new HashSet<int>();
			while( !found )
			{
				for( int i = 0; i < data.Count; i++ )
				{
					frequency += data[i];
					if( !frequencies.Add( frequency ) )
					{
						found = true;
					}
				}
			}

			// Get Duration
			duration = DateTime.Now - startTime;

			// Print Duration
			Console.WriteLine( $"Part 2 Solution took: {duration.TotalMilliseconds} Milliseconds." );
			Console.WriteLine( $"Part 2 Ouput: {frequency}" );
		}
	}
}








