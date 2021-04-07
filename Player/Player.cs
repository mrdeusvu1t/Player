using System;
using System.Collections.Generic;
using System.Text;

namespace Player
{
	public class Player
	{
		public static void PlaySequential(Playlist p)
		{
			p.Sequential();
		}

		public static void PlayRandom(Playlist p)
		{
			p.Random();
		}

	}
}
