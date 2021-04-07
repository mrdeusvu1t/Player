using System;

namespace Player
{
	class Program
	{
		static void Main(string[] args)
		{
			Song s1 = new Song("Song1", 100, @"D:\music\");
			Song s2 = new Song("Song2",  50, @"D:\music\");
			Song s3 = new Song("Song3", 150, @"D:\music\");
			Song s4 = new Song("Song4",  70, @"D:\music\");
			Song s5 = new Song("Song5",  30, @"D:\music\");


			Console.WriteLine($"ID: {s1.Id}");
			Console.WriteLine($"ID: {s2.Id}");
			Console.WriteLine($"ID: {s3.Id}");
			Console.WriteLine($"ID: {s4.Id}");
			Console.WriteLine($"ID: {s5.Id}");

			Playlist p1 = new Playlist("Playlist1");

			p1.AddSong(s1);
			p1.AddSong(s2);
			p1.AddSong(s3);

			Player.PlaySequential(p1);

			p1.AddSong(s4);
			p1.AddSong(s5);

			Player.PlayRandom(p1);

			p1.SearchSong("Song4");

			p1.DisplayPlaylist();

			p1.DeleteSong(3);

			Console.WriteLine();
			p1.DisplayPlaylist();

			Console.ReadLine();
		}
	}
}
