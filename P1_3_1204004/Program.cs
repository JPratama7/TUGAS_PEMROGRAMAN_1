﻿using System;

namespace P1_3_1204004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Nilai N");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 0 || N < 11){
                for (int i = N; i > 0;i--){
                    if (i == 1){
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah induknya", i);
                    }else{
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggalah {1}", i, i-1);
                    }
                }
            }else{
                Console.WriteLine("Nilai Tidak boleh Dibawah 0 atau diatas 10");
            }
        }
    }
}