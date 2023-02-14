namespace OpenClosedPrinciple
{

    /*
     Öncelikle bir kod; genişlemeye açık, değişime kapalı olduğu taktirde ideal koddur!
     

     Buradaki kod yapısını incelediğimizde göreceğimiz olay şu; Biz sistemimizde şuan için iki bankayla çalışmış görünüyoruz ve bu sisteme ihtiyaç doğrultusunda yeni bankalar eklenebilir.

    Görüldüğü üzere her bankanın kendine has para gönderme yöntemleri ve metotları bulunuyor. Dolayısıyla ben Garanti ile para göndermek istediğimde başka bir kod parçacığı oluşturup kullanıyorum. Halkbank için para göndermek istediğimde başka bir kod parçacığı oluşturup kullanıyorum. Hatta ve hatta sisteme yeni bir banka ekleyecek olursam ona has kodlarında olacağını düşünürsek eğer ben o bankayıda kullanmaya karar verirsem bu seferde kodu değiştirip para gönderme işlemini o şekilde oluşturmam gerekecektir.


    Yukarıda anlatığımız olayı özetleyecek olursak farklı bankalardan para gönderme işlemlerini gerçekleştirmek istediğimde her defasında kodda değişiklik yapmak zorunda kalıyorum. Oysaki SOLID prensbileri içerisinde bulunan O harfi yani Open/Closed Prensibi bana der ki sen kodu ideal bir yaklaşımla oluşturmak istiyorsan o kod genişlemeye açık değişime her zaman kapalı olmalıdır. Bu sebepten ötürü sen bu sistemi genişletilebilir halde yazacaksın sisteme yeni bir banka geldiğinde bile kodu değiştirmeden o bankayı da kolaylıkla sisteme dahil edeceksin diyor. Şimdi bunu net bir şekilde görebilmek adına IdealCode sınıfına göz atabiliriz.
     
     */

    class ParaGonderici
    {
        public void Gonder(int tutar)
        {
            //Garanti garanti = new();
            //garanti.HesapNo = "...";
            //garanti.ParaGonder(tutar);
            Halkbank halkban = new();
            halkban.GonderilecekHesapNo("123456789");
            halkban.Gonder(tutar);
        }
    }

    class Garanti
    {
        public string HesapNo { get; set; }
        public void ParaGonder(int tutar)
        {
            Console.WriteLine($"Para Gönderimi Garanti ile gerçekleştirilmiştir : {tutar}");
        }
    }
    class Halkbank
    {
        string _hesapNo;
        public void GonderilecekHesapNo(string hesapNo)
        {
            Console.WriteLine($"Para gönderilecek hesap numarası : ${hesapNo}");
        }
        public void Gonder(int tutar)
        {
            Console.WriteLine($"Para Gönderimi Halk Bank ile gerçekleştirilmiştir : {tutar}");
        }
    }


}
