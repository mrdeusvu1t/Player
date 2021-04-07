using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Player
{
	public class Playlist
	{
		private static int _id;
		private readonly List<Song> _playlist;
		public readonly int Id;

		public string Duration
		{
			get
			{
				int min = 0;
				int sec = 0;

				foreach (Song s in _playlist)
				{

					min += s.DurMin;
					sec += s.DurSec;
				}

				return $"{min}:{sec}";
			}
		}		

		public string Title { get; set; }

		public Playlist(string title)
		{
			Id = ++_id;
			Title = title;
			_playlist = new List<Song>();
		}

		public void AddSong(Song song)
		{
			_playlist.Add(song);
		}

		public void DeleteSong(int id)
		{
			foreach (Song s in _playlist)
			{
				if (s.Id == id)
				{
					_playlist.Remove(s);
					return;
				}
			}
		}

		public void SearchSong(string title)
		{
			foreach (Song s in _playlist)
			{
				if (s.Title == title)
				{
					Console.WriteLine(s.ToString());
					return;
				}
			}
			Console.WriteLine("Песня не найдена.");
		}

		public void Sequential()
		{
			Console.WriteLine("Запуск плейлиста.");
			foreach (Song s in _playlist)
			{
				Console.WriteLine($"Играет: {s.Title}");
				Thread.Sleep(1000);
			}
			Console.WriteLine("Плейлист закончился.");
		}

		public void Random()
		{
			Random r = new Random();
			Console.WriteLine("Запуск плейлиста.");
			for (int i = 0; i < _playlist.Count; i++)
			{
				Console.WriteLine($"Играет: {_playlist[r.Next(0, _playlist.Count - 1)].Title}");
				Thread.Sleep(1000);
			}
			Console.WriteLine("Плейлист закончился.");
		}

		public void DisplayPlaylist()
		{
			foreach (Song s in _playlist)
			{
				Console.WriteLine(s.Title);
			}
		}
	}
}
