﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2018
{
	public class Day1
	{

		private DateTime startTime;
		private TimeSpan duration;

		List<int> data = new List<int>();
		HashSet<int> frequencies = new HashSet<int>();
		int frequency = 0;

		public Day1( int part )
		{
			// Input
			string[] dataArray = System.IO.File.ReadAllLines( "../../Day1_Input.txt" );
			foreach( string dataText in dataArray )
			{
				data.Add( Convert.ToInt32( dataText.Trim() ) );
			}

			// Start Timer
			startTime = DateTime.Now;

			// Do Code Stuff
			if( part == 1 )
			{
				Part1();
			}
			else if( part == 2 )
			{
				Part2();
			}

			// Get Duration
			duration = DateTime.Now - startTime;

			// Print Duration
			Console.WriteLine( $"{this.GetType().Name} Solution took: {duration.TotalMilliseconds} Milliseconds.\n" );
			Console.WriteLine( $"{this.GetType().Name} Ouput: {frequency}" );
		}

		private void Part1()
		{
			for( int i = 0; i < data.Count; i++ )
			{
				frequency += data[i];
			}
		}

		private void Part2()
		{
			while( true )
			{
				for( int i = 0; i < data.Count; i++ )
				{
					frequency += data[i];
					if( !frequencies.Add( frequency ) )
					{
						return;
					}
				}
			}
		}
	}
}








