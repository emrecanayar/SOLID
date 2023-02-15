namespace InterfaceSegregationPrinciple
{
    /*
     Interface Segragation Principle, bir nesnenin yapması gereken her farklı davranışların , o davranışlara odaklanmış özel interface'ler ile eşleşmesini öneren prensiptir.

    Böylece ihtiyaç olan davranışları temsil eden interface'ler eşliğinde ilgili sınıflara kazandırabilir ve hiçbir sınıfın kullanmadığı yada kullanmayacağı imzayı metodu zorla implemente etmek zorunda kalmayacaktır.

    Sınıflara ihtiyaç duymadıkları imzaları interfacelerle zorlayarak işlevsiz metotlar eklemek Interface Segration Principle kavramına aykırıdır.

    İhtiyaç duyulmayan metotlar geliştiriciler tarafından kullanılacağı zaman kafa karşıklığına yol açabilir.

    Yahut interface'de oluşacak herhangi bir yeni değişiklik ister istemez o değişiklikle alakassı olmayan sınıflarda da kodlanması gerekecektir. Buda yine istenmeyen bir durumdur.

    Hacmi geniş olan veya davranıssal olarak farklı yetenekleri içerisinde barındıran interface'ler mümkün mertebe yeteneklerine göre parçalanarak küçültülmelidir.
     
     Şimdi aşağıdaki class yapılarını bir incleyelim ve duruma bir göz atalım.
     
     
     
     */

    //IPrinter adında bir interfaceimiz var ve bu aslında printer lar için oluşturulmuş bir arayüz. Fakat içerisine baktığımızda Print, Scan , Fax, PrintDuplex adı altında birden fazla iş yapan metotlar bulunmakta. Şimdi biz bu interface üzerinden bir class oluşturduğumuz doğal olarak beklediğimiz durum şudur. Bunun içerisinde yer alan bütün metotları kullanması gerektiğidir. Lakin bizim kullandığımız printer sınıfında bu metotların hepsine sahip olması beklenemez. Bu durumda bu interfaceden implemente ettiğimiz sınıf içerisinde kullanılmayan metotlar için NotImplementException vs gibi bildirimler kullanmamız gerekmektedir. Buda bizim için istenmeyen bir durumdur bizim için önemi olan bir interface içerisinde yer alan bütün operasyonların bundan implemente edilen bütün sınıflarda kullanılması gerektiğidir. Alttaki örneklere bakacak olursak bunun yanlış kullanımını görmüş oluyoruz. Doğru kullanımı içinde IdealCode sınıfının içerisine bakabilirsiniz.
    interface IPrinter
    {
        void Print();
        void Scan();
        void Fax();
        void PrintDuplex();
    }

    //Bu sınıf IPrinter interface inden gelen bütün metotları kullanabilme yeteneğine sahiptir. Dolayısıyla bu sınıf için herhangi bir problem yok.

    class HPPrinter : IPrinter
    {
        public void Fax()
        {
            Console.WriteLine("Fax işlemi gerçekleştirildi.");
        }

        public void Print()
        {
            Console.WriteLine("Print işlemi gerçekleştirildi.");
        }

        public void PrintDuplex()
        {
            Console.WriteLine("PrintDuplex işlemi gerçekleştirildi.");
        }

        public void Scan()
        {
            Console.WriteLine("Scan işlemi gerçekleştirildi.");
        }
    }

    //Fakat bu sınıfa baktığımızda IPrinter interfacesini implemente ettiğinde PrintDuplex ve Scan metotlarını kullanamadığını görüyoruz. İşte bu bizim istemediğimiz bir durum eğer bir interface içerisinde metotlar yer alıyorsa onu implement eden sınıf bu metotların hepsini kullanmakla yükümlüdür.
    class SamsungPrinter : IPrinter
    {
        public void Fax()
        {
            Console.WriteLine("Fax işlemi gerçekleştirildi.");
        }

        public void Print()
        {
            Console.WriteLine("Print işlemi gerçekleştirildi.");
        }

        public void PrintDuplex()
            => throw new NotSupportedException();

        public void Scan()
            => throw new NotSupportedException();
    }

    // Yine aynı şekilde bu sınıfta PrintDuplex() metodunu kullanamıyor. Bu sebepten dolayı bu da istemediğimiz durumla karşı karşıya kalıyor.
    class LexmarkPrinter : IPrinter
    {
        public void Fax()
        {
            Console.WriteLine("Fax işlemi gerçekleştirildi.");
        }

        public void Print()
        {
            Console.WriteLine("Print işlemi gerçekleştirildi.");
        }

        public void PrintDuplex()
            => throw new NotSupportedException();

        public void Scan()
        {
            Console.WriteLine("Scan işlemi gerçekleştirildi.");
        }
    }


    //Yukarıdaki aşamalara baktığımızda IPrint interfacesi içerisinde yer alan metoların bazıları bazı classlar içerisinde kullanılmıyor. İşte bizim burada yapmamız gereken birbirinden farklı sadece o işe odaklı ayrı ayrı interfaceler oluşturmak bu kodun Interface Segregation Principle uygulanmış haline IdealCode sınıfından ulaşabilirsiniz.
}