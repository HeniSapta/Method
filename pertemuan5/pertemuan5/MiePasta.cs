using System;

namespace Praktikum4
{
    public class MiePasta : Makanan
    {
        private string bentuk;
        private string rasa;

        public MiePasta(string bahanUtama, string bentuk, string rasa) : base(bahanUtama)
        {
            this.bentuk = bentuk;
            this.rasa = rasa;
        }

        public override string Resep()
        {
            return "Ini adalah resep mie pasta.";
        }

        public void Rebus(int waktu)
        {
            Console.Write($"Rebus mie pasta selama {waktu} menit dengan tambahan bumbu {rasa}\n");
        }

        public override void PersiapanBahan()
        {
            Console.WriteLine($"Siapkan {bahanUtama} sebagai bahan utama.");
            Console.WriteLine($"Tambahkan bumbu {rasa} ke dalam air rebusan mie.");
        }
    }
}