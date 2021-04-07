using System;
using System.Collections.Generic;
using System.Text;

namespace Player
{
	public class Song
	{
		private static int _id;
		private readonly int _duration;
		private readonly string _path;
		private readonly int Id;
		

		public string Title { get; set; }

		public int Duration
		{
			get => _duration;
		}

		public int DurSec {
		get
			{
				return _duration % 60;
			}
		}

		public int DurMin
		{
			get
			{
				return _duration / 60;
			}
		}

		public string Time
		{
			get
			{
				return $"{DurMin}:{DurSec}";
			}
		}

		public Song(string title, int duration, string path)
		{
			Id = ++_id;
			Title = title;
			_duration = duration;
			_path = path;
		}

		public override string ToString()
		{
			return $"Title: {Title}\nDuration: {Duration}\nPath: {_path}"; 
		}
	}
}
