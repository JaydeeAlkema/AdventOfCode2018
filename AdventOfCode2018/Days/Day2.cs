using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2018
{
	public class Day2
	{
		public void Part1()
		{
			// Set Data
			DateTime startTime;
			TimeSpan duration;

			List<string> sortedData = new List<string>();

			int doubles = 0;
			int triples = 0;

			Dictionary<char, int> charDictionary = new Dictionary<char, int>();
			string[] dataArray = System.IO.File.ReadAllLines( "../../Day2_Input.txt" );

			// Start Timer
			startTime = DateTime.Now;

			// Do Code Stuff
			foreach( var ID in dataArray )
			{
				foreach( var ch in ID.ToCharArray() )
				{
					charDictionary.TryGetValue( ch, out int i );
					charDictionary[ch] = i + 1;
				}

				if( charDictionary.ContainsValue( 2 ) ) doubles++;
				if( charDictionary.ContainsValue( 3 ) ) triples++;

				charDictionary.Clear();
			}

			// Get Duration
			duration = DateTime.Now - startTime;

			// Print Duration
			Console.WriteLine( $"Part 1 Solution took: {duration.TotalMilliseconds} Milliseconds." );
			Console.WriteLine( $"Part 1 Output: {doubles * triples} " );
		}

		public void Part2()
		{
			// Set Data
			DateTime startTime;
			TimeSpan duration;

			List<string> sortedData = new List<string>();
			string[] dataArray = System.IO.File.ReadAllLines( "../../Day2_Input.txt" );
			StringBuilder chars = new StringBuilder();
			int diff = 0;

			// Start Timer
			startTime = DateTime.Now;

			// Do Code Stuff
			foreach( var lines1 in dataArray )
			{
				foreach( var lines2 in dataArray )
				{
					for( int i = 0; i < lines1.Length; i++ )
					{
						if( lines1[i] != lines2[i] )
						{
							if( ++diff > 1 )
							{
								break;
							}
						}
						else
						{
							chars.Append( lines1[i] );
						}
					}
					if( diff == 1 )
					{
						// Get Duration
						duration = DateTime.Now - startTime;

						// Print Duration
						Console.WriteLine( $"Part 2 Solution took: {duration.TotalMilliseconds} Milliseconds." );
						Console.WriteLine( $"Part 2 Output: {chars}" );

						return;
					}

					diff = 0;
					chars.Clear();
				}
			}


		}
	}
}
