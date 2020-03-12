using System;

namespace calculator
{
	class Program
	{
		public static void Main(string[] args)
		{
		kembali:
			Console.Clear();
			int pilihan = 0;
			int a = 0, b = 0;
			Console.WriteLine(" selamat anda menggunakan calculator");
			Console.WriteLine();
			Console.WriteLine("1. penambahan");
			Console.WriteLine("2. pengurangan");
			Console.WriteLine("3. perkalian");
			Console.WriteLine("4. pembagian");
			Console.WriteLine();
			Console.WriteLine("masukan pilihan : ");
			pilihan = int.Parse(Console.ReadLine());

			if (pilihan == 1)
			{
				Console.WriteLine("masukan nilai A : ");
				a = int.Parse(Console.ReadLine());
				Console.WriteLine("masukan nilai B : ");
				b = int.Parse(Console.ReadLine());
				Console.WriteLine("hasil penambahan : {0}+{1}={2}", a, b, penambahan(a, b));

			}

			if (pilihan == 2)
			{
				Console.WriteLine("masukan nilai A : ");
				a = int.Parse(Console.ReadLine());
				Console.WriteLine("masukan nilai B : ");
				b = int.Parse(Console.ReadLine());
				Console.WriteLine("hasil pengurangan : {0}-{1}={2}", a, b, pengurangan(a, b));

			}
			if (pilihan == 3)
			{
				Console.WriteLine("masukan nilai A : ");
				a = int.Parse(Console.ReadLine());
				Console.WriteLine("masukan nilai B : ");
				b = int.Parse(Console.ReadLine());
				Console.WriteLine("hasil perkalian : {0}*{1}={2}", a, b, perkalian(a, b));

			}


			if (pilihan == 4)
			{
				Console.WriteLine("masukan nilai A : ");
				a = int.Parse(Console.ReadLine());
				Console.WriteLine("masukan nilai B : ");
				b = int.Parse(Console.ReadLine());
				Console.WriteLine("hasil pembagian : {0}/{1}={2}", a, b, pembagian(a, b));

			}
			static int penambahan(int a, int b) => a + b;
			static int pengurangan(int a, int b) => a - b;
			static int perkalian(int a, int b) => a * b;
			static int pembagian(int a, int b) => a / b;
		}
	}
}

        
    

