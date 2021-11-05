﻿using System;

namespace P1_4_1204004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu Persegi Panjang\n 1. Hitung Luas\n 2. Hitung Keliling\n 3. Hitung Panjang Diagonal\n-----------------------------");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            if (pilihan == 1){
                Console.WriteLine("Menghitung Luas");
                Console.WriteLine("Masukkan Panjang");
                int panjang = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Masukkan Lebar");
                int lebar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Luassnya adalah {0}", luas(panjang,lebar));
            }else if (pilihan == 2){
                Console.WriteLine("Menghitung Luas");
                Console.WriteLine("Masukkan Panjang");
                int panjang = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Masukkan Lebar");
                int lebar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kelilingnya adalah {0}", keliling(panjang,lebar));
            }else if(pilihan == 3){
                Console.WriteLine("Menghitung Luas");
                Console.WriteLine("Masukkan Panjang");
                double panjang = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Masukkan Lebar");
                double lebar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Luassnya adalah {0}", panjangdiagonal(panjang,lebar));
            }else{
                Console.WriteLine("Pilihan hanya 1 2 3");
            }

        static int luas(int panjang, int lebar){
            return panjang*lebar;
        }
        static int keliling(int panjang, int lebar){
            return 2*panjang + 2*lebar;
        }
        static double panjangdiagonal(double panjang, double lebar){
            double kuadrat_lebar = Math.Pow(lebar,2);
            double kuadrat_panjang = Math.Pow(panjang, 2);
            double kuadrat_total = kuadrat_panjang + kuadrat_lebar;
            double total = Math.Sqrt(kuadrat_total);
            return total;
        }
    }
}}
