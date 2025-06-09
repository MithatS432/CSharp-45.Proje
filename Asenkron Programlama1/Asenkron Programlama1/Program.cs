using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asenkron_Programlama1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Veri çekme işlemi başlatıldı...\n");

            // Görevleri aynı anda başlatıyoruz
            Task<string> haberTask = HaberVerisiniGetirAsync();
            Task<string> havaTask = HavaDurumunuGetirAsync();

            // Aynı anda çalışırken bekliyoruz
            string haber = await haberTask;
            string hava = await havaTask;

            Console.WriteLine($"\nHaber: {haber}");
            Console.WriteLine($"Hava Durumu: {hava}");

            Console.WriteLine("\nTüm veriler başarıyla alındı.");
        }

        static async Task<string> HaberVerisiniGetirAsync()
        {
            await Task.Delay(2000); // Ağ gecikmesini simüle ediyoruz
            return "Bugün teknoloji gündeminde yapay zekâ var.";
        }

        static async Task<string> HavaDurumunuGetirAsync()
        {
            await Task.Delay(1500);
            return "İstanbul'da hava bugün parçalı bulutlu, 22°C.";
        }
    }
}
