﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum4
{
    public class Pasta : Makanan
    {
        private string bentuk;

        public Pasta(string bahanUtama, string bentuk) : base(bahanUtama)
        {
            this.bentuk = bentuk;
        }

        public override string Resep()
        {
            return "Ini adalah resep pasta.";
        }

        public void Rebus(int waktu)
        {
            Console.WriteLine($"Rebus {bentuk} selama {waktu} menit.");
        }

        public override void PersiapanBahan()
        {
            Console.WriteLine($"Siapkan {bahanUtama} sebagai bahan utama.");
            Console.WriteLine($"bentuk {bahanUtama} menjadi {bentuk}.");
        }
    }
}