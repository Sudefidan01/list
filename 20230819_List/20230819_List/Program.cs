using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230819_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List Tanım
            //List<> Koleksiyonu
            //c# programlama dili içerisinde sık kullanılan koleksiyonlardan bir tanesidir
            //List<> koleksiyonu içerisinde istediğiniz türden değer(ler) barındırabiliriz
            //Koleksiyon tanımlama işlemi esnasında içerisinde kaç adet eleman barındıralacağını belirtmemize gerek yok
            //Koleksiyon içerisindeki elemanlara [index] numarası ile erişim sağlayabiliriz
            //Koleksiyon içerisine yeni bir değer eklemek için .Add(değer) şeklinde bir kullanımı vardır
            //Bu sayede koleksiyon içerisine istediğimiz kadar değer eklemesi yapabiliriz
            //Koleksiyon içerisindeki elemanları .RemoveAt(index) metodu ile silebiliriz.RemoveAt()  metodunun içerisine hangi elemanı silecekseniz o elemanın index numarasını belirtmemiz gerekmektedir
            //List<> koleksiyonu içerisindeki toplam eleman sayısına .Count() property'si ile ulaşabiliriz

            //Syntax
            // List<veritipi> takmaAd = new List<veritipi>();
            #endregion 
            List<int> sayilar=new List<int>();
            //Koleksiyon içerisine yeni bir eleman ekleyelim
            sayilar.Add(34);
            sayilar.Add(50);
            sayilar.Add(12);
            sayilar.Add(75);
            //List koleksiyonu içerisindeki elemanlara ulaşalım
            Console.WriteLine("0. indexteki 1.eleman = " + sayilar[0]);
            Console.WriteLine("1. indexteki 2.eleman = " + sayilar[1]);
            Console.WriteLine("2. indexteki 3.eleman = " + sayilar[2]);
            Console.WriteLine("3. indexteki 4.eleman = " + sayilar[3]);

            Console.WriteLine("\n\n-----------------\n");
            //List<> koleksiyonu içerisindeki elemanların değerini değiştirelim
            sayilar[1] = 70;
            Console.WriteLine("1.indexteki 2.eleman = " + sayilar[1]);

            Console.WriteLine("\n\n-----------------\n");

            //List<> koleksiyonu içerisindeki bir elemanı silelim
            sayilar.RemoveAt(0);//RemoveAt metodu index numarasına göre silme işlemi yapar

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n-----------------\n");

            sayilar.Remove(70);//Remove metodu , belirtilen değeri koleksiyon içerisinde arayıp bulursa siler
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

            //Not:Silme işlemi yaptıktan sonra elemanların index numaraları sırasına göre otomatik olarak değişir

            Console.WriteLine("\n\n-----------------\n");

            //List<> koleksiyonu içerisindeki eleman sayısına ulaşalım
            Console.WriteLine("Eleman Sayısı = "+sayilar.Count());
            Console.ReadKey();
        }
    }
}
