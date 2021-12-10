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
			List<Claim> claims = new List<Claim>();
			var positions = new HashSet<(int x, int y)>();
			var overlaps = new HashSet<(int x, int y)>();

			// Start Timer
			startTime = DateTime.Now;

			// Do code stuff

			// Parse raw data to claim struct
			foreach( var data in dataArray )
			{
				string[] splitData = data.Split( new char[] { '#', '@', ',', ':', 'x' } );
				Claim _claim = new Claim
				{
					ID = int.Parse( splitData[1] ),
					x = int.Parse( splitData[2] ),
					y = int.Parse( splitData[3] ),
					width = int.Parse( splitData[4] ),
					height = int.Parse( splitData[5] )
				};
				claims.Add( _claim );
			}

			foreach( var claim in claims )
			{
				for( int x = claim.x; x < claim.width + claim.x; x++ )
				{
					for( int y = claim.y; y < claim.height + claim.y; y++ )
					{
						if( !positions.Add( (x, y) ) )
						{
							overlaps.Add( (x, y) );
						}
					}
				}
			}

			// Loop through all the claims and calculate total square inches that are overlapping

			// Get Duration
			duration = DateTime.Now - startTime;

			// Print Duration
			Console.WriteLine( $"Part 1 Solution took: {duration.TotalMilliseconds} Milliseconds." );
			Console.WriteLine( $"Part 1 Output: {overlaps.Count}." );
		}

		public void Part2()
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

public struct Claim
{
	public int ID;
	public int x;
	public int y;
	public int width;
	public int height;
}