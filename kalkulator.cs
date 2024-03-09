using System;

namespace kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi Calculator");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Input nomor menu [1..4]: ");
            int menu = Convert.ToInt32(Console.ReadLine());

            if (menu >= 1 && menu <= 4)
            {
                Console.Write("Inputkan nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Tambah(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Kurang(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + Kali(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + Bagi(a, b));
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Maaf menu yang anda pilih tidak tersedia");
            }

            Console.WriteLine("Tekan sembarang key untuk keluar Aplikasi Calculator");
            Console.ReadKey();
        }

        static int Tambah(int a, int b)
        {
            return a + b;
        }

        static int Kurang(int a, int b)
        {
            return a - b;
        }

        static int Kali(int a, int b)
        {
            return a * b;
        }

        static int Bagi(int a, int b)
        {
            return a / b;
        }
    }
}
