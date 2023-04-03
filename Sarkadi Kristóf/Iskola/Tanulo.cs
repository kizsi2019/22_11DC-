using System;

namespace if
{
	class Tanulo
	{
		public int Ev { get; set; }
		public string Osztaly { get; set; }
		public string Nev { get; set; }
	
		public Tanulo(string sor)
		{
			string[] adatok = sor.Split(';');
			Ev = int.Parse(adatok[0]);
			Osztaly = adatok[1];
			Nev = adatok[2];
		}
		
		public int NevHossza
		{
			get
			{
				return Nev.Replace(" ", "").Length;
			}
		}
	}
}
