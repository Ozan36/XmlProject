using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Konsola TCMB Güncel Kur Bilgileri başlığını yazdırma
            Console.WriteLine("------------------TCMB 21/03/2025 GÜNCEL KUR BİLGİLERİ-------------------");

            // TCMB'nin güncel döviz kurlarını içeren XML dosyasının URL'sini belirliyoruz.
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";

            // XmlDocument sınıfından bir nesne oluşturuyoruz.
            // Bu nesne, XML verilerini yüklemek ve işlemek için kullanılacak.
            var xmlDoc = new XmlDocument();

            // Belirtilen URL'den XML verisini yüklüyoruz.
            xmlDoc.Load(today);

            // XML verisinden USD (Dolar) için BanknoteBuying (Banknot Alış) değerini seçiyoruz
            // ve bu değeri dolarAlis değişkenine atıyoruz.
            string dolarAlis =
                xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;

            // Konsola güncel Dolar alış fiyatını yazdırma
            Console.WriteLine("GÜNCEL DOLAR KURU ALIŞ FİYATI: " + dolarAlis);

            // XML verisinden USD (Dolar) için BanknoteSelling (Banknot Satış) değerini seçiyoruz
            // ve bu değeri dolarSatis değişkenine atıyoruz.
            string dolarSatis =
                xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;

            // Konsola güncel Dolar satış fiyatını yazdırma
            Console.WriteLine("GÜNCEL DOLAR KURU SATIŞ FİYATI: " + dolarSatis);

            // XML verisinden EUR (Euro) için BanknoteBuying (Banknot Alış) değerini seçiyoruz
            // ve bu değeri euroAlis değişkenine atıyoruz.
            string euroAlis =
                xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;

            // Konsola güncel Euro alış fiyatını yazdırma
            Console.WriteLine("GÜNCEL EURO KURU ALIŞ FİYATI: " + euroAlis);

            // XML verisinden EUR (Euro) için BanknoteSelling (Banknot Satış) değerini seçiyoruz
            // ve bu değeri euroSatis değişkenine atıyoruz.
            string euroSatis =
                xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

            // Konsola güncel Euro satış fiyatını yazdırma
            Console.WriteLine("GÜNCEL EURO KURU SATIŞ FİYATI: " + euroSatis);

            Console.Write("--------------------------------------------");
            Console.ReadLine();
        }
    }
}
