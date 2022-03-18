using System;

public class Program
{
	private double tambah (double a, double b){
 	
	return ( a + b );
	}
	
	private double kurang (double a, double b ){
	return ( a - b );
	}
	
	private double kali (double a, double b ){
	return ( a * b );
	}
	
	private double bagi (double a, double b ){
	return (a / b );
	}
	
	public void Main()
	{
		
		double bil1, bil2;
		char pilihan;
		Console.WriteLine("Pilih Menu Calculator: ");
		Console.WriteLine("1. Penambahan");
		Console.WriteLine("2. Pengurangan");
		Console.WriteLine("3. Perkalian");
		Console.WriteLine("4. Pembagian");
		Console.WriteLine("Pilih nomor 1-4");
		pilihan = Convert.ToChar(Console.ReadLine());
		Console.WriteLine("\n");


		if ( pilihan == '1') {
			Console.WriteLine("Inputkan Nilai");
			Console.WriteLine("Inputkan Nilai a : ");
			bil1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Inputkan Nilai b : ");
			bil2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Hasilnya Penambahan : "+tambah(bil1,bil2));	
		}
		
		else if ( pilihan == '2') {
			Console.WriteLine("Inputkan Nilai");
			Console.WriteLine("Inputkan Nilai a");
			bil1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Inputkan Nilai b");
			bil2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Hasil perkalian : "+kurang(bil1,bil2));
		}
		
		else if ( pilihan == '3') {
			Console.WriteLine("Inputkan Nilai");
			Console.WriteLine("Inputkan Nilai a");
			bil1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Inputkan Nilai b");
			bil2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Hasilnya Pembagian: "+kali(bil1,bil2));	
		}
		
		else if ( pilihan == '4') {
			Console.WriteLine("Inputkan Nilai");
			Console.WriteLine("Inputkan Nilai a");
			bil1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Inputkan Nilai b");
			bil2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Hasil Pembagian: "+bagi(bil1,bil2));
		}
	}
}
