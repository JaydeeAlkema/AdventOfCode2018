using System;
using System.Collections.Generic;

namespace AdventOfCode2018
{
	class Day3
	{
		public void Part1()
		{
			// Set Data
			DateTime startTime;
			TimeSpan duration;

			string[] dataArray = System.IO.File.ReadAllLines( "../../Days/Inputs/Day3_Input.txt" );
			char[] dataSplit = new char[] { '#', '@', ',', ':', 'x' };
			var positions = new HashSet<(int x, int y)>();
			var overlaps = new HashSet<(int x, int y)>();

			// Start Timer
			startTime = DateTime.Now;

			// Do code stuff

			// Parse raw data to claim struct
			foreach( var data in dataArray )
			{
				string[] splitData = data.Split( dataSplit, StringSplitOptions.RemoveEmptyEntries );
				int posX = int.Parse( splitData[1] );
				int posY = int.Parse( splitData[2] );
				int width = int.Parse( splitData[3] );
				int height = int.Parse( splitData[4] );

				for( int x = posX; x < width + posX; x++ )
				{
					for( int y = posY; y < height + posY; y++ )
					{
						if( !positions.Add( (x, y) ) )
						{
							overlaps.Add( (x, y) );
						}
					}
				}
			}

			// Get Duration
			duration = DateTime.Now - startTime;

			// Print Duration
			Console.WriteLine( $"Part 2 Solution took: {duration.TotalMilliseconds} Milliseconds." );
			Console.WriteLine( $"Part 2 Output: {overlaps.Count}" );
		}
	}
}