using System;

namespace Euler9
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double a, b, c, p;

			for (int i = 1; i < 1000; i++) {
				for (int j = 1; j < 1000; j++) {
					c = Math.Sqrt((i * i) + (j * j));
					if (((i * i) + (j * j)) == c*c) {
						a = i;
						b = j;
						p = a + b + c;
						if (p == 1000) {
							Console.WriteLine("The Pythagorean Triple whose sum equals 1000 is: " + a + ", " + b + ", " + c);
							return;
						}
					}
				}
			}						
		}
	}
}
