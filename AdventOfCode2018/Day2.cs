using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018
{
	public class Day2
	{
		public void Part1()
		{
			// Set Data
			DateTime startTime;
			TimeSpan duration;

			List<string> data = new List<string>();
			List<string> sortedData = new List<string>();

			string[] dataArray = System.IO.File.ReadAllLines( "../../Day2_Input.txt" );
			foreach( string dataText in dataArray )
			{
				data.Add( dataText.Trim() );
			}

			// Start Timer
			startTime = DateTime.Now;

			// Do Code Stuff
			foreach( string ID in data )
			{
				List<string> sortedID = ID.Select( c => c.ToString() ).ToList();

				bool swap;
				string temp; //change this too

				// Sort the sortedID list with BubbleSort.
				do
				{
					swap = false;

					for( int index = 0; index < ( sortedID.Count - 1 ); index++ )
					{
						if( string.Compare( sortedID[index], sortedID[index + 1] ) < 0 ) //if first number is greater then second then swap
						{
							//swap

							temp = sortedID[index];
							sortedID[index] = sortedID[index + 1];
							sortedID[index + 1] = temp;
							swap = true;
						}
					}

				} while( swap == true );

				sortedID.Reverse();
				sortedData.Add( string.Join( "", sortedID.ToArray() ) );

				// Check for double letters.
				// Check if there isn't a third letter, if not, increment a counter for double letters.

				// Check for Triple letters.
				// Increment counter for tripple letters.
			}

			// Get Duration
			duration = DateTime.Now - startTime;

			// Print Duration
			Console.WriteLine( $"{this.GetType().Name} Solution took: {duration.TotalMilliseconds} Milliseconds.\n" );
		}
	}
}
