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
			Console.WriteLine( $"Part 1 Solution took: {duration.TotalMilliseconds} Milliseconds." );
			Console.WriteLine( $"Part 1 Output: {overlaps.Count}" );
		}

		public void Part2()
		{
			// Set Data
			DateTime startTime;
			TimeSpan duration;

			string[] dataArray = System.IO.File.ReadAllLines( "../../Days/Inputs/Day3_Input.txt" );
			char[] dataSplit = new char[] { '#', '@', ',', ':', 'x' };
			var positions = new HashSet<(int x, int y)>();
			var overlaps = new HashSet<(int x, int y)>();
			var ids = new HashSet<int>();
			int noOverlapID = 0;

			// Start Timer
			startTime = DateTime.Now;

			// Do code stuff

			// Store all ID's in HashSet.
			foreach( var data in dataArray )
			{
				ids.Add( int.Parse( data.Substring( 1, data.IndexOf( ' ' ) ) ) );
			}

			var map = new Dictionary<(int x, int y), List<int>>();
			foreach( var data in dataArray )
			{
				string[] splitData = data.Split( dataSplit, StringSplitOptions.RemoveEmptyEntries );
				int ID = int.Parse( splitData[0] );
				int posX = int.Parse( splitData[1] );
				int posY = int.Parse( splitData[2] );
				int width = int.Parse( splitData[3] );
				int height = int.Parse( splitData[4] );

				for( int x = posX; x < width + posX; x++ )
				{
					for( int y = posY; y < height + posY; y++ )
					{
						if( !map.TryGetValue( (x, y), out List<int> list ) )
						{
							list = new List<int>();
						}

						list.Add( ID );
						map[(x, y)] = list;
					}
				}
			}

			// Loop through the entire map and remove those with a higher count than one.
			foreach( var pos in map.Values )
			{
				if( pos.Count > 1 )
				{
					ids.RemoveWhere( ( int i ) => pos.Contains( i ) );
				}
			}

			// Get Duration
			duration = DateTime.Now - startTime;

			// Print Duration
			Console.WriteLine( $"Part 2 Solution took: {duration.TotalMilliseconds} Milliseconds." );
			Console.WriteLine( $"Part 2 Output: {new List<int>( ids )[0]}" );
		}
	}
}