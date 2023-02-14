namespace OpenClosedPrincipleIdealCode
{
    //Burada her şeyden önce bütün bankalarda yer alan ve hepsinde işlem olarak gerçekleştirelecek olan para transferi metodunu bir interface tanımlayarak oluşyuruyoruz. Bu prensibe uygun bir şekilde kod yazmak istiyorsak aynı amaca yönelik olan işlemeri tek bir interface altında toplamamız gerekmektedir. Daha sonra bunu gerekli bütün bankalara implemente edeceğiz. Bu sayede bütün bankaların paraTransfer metodunu tek bir yerden kontrol etmiş olacağız.
    interface IBanka
    {
        bool ParaTransferi(int tutar, string hesapNo);
    }

    //En nihayetinde ParaGönderici diye bir sınıf oluşturuyporuz ve burada Gonder adındaki metot sayesinde  parametre olarak geçilen IBanka interface i sayesinde bu interfaceden türeyen bütün classlarımızı buraya parametre olarak verebiliriz. Bu durum da hangi bankaya kullanacaksak onun classından bir nesne oluşturup parametre olarak verdiğimizde o banka adına para gönderme işlemini gerçekleştirecektir. Bunun kullanımı için Program.cs classına bakabilirsiniz.
    class ParaGonderici
    {
        public void Gonder(IBanka banka, int tutar, string hesapNo)
        {
            banka.ParaTransferi(tutar, hesapNo);
        }
    }

    //Burada görüldüğü üzere Garanti bankasının işlemleri için IBanka interface sinden implemente edilmiştir.
    class Garanti : IBanka
    {
        public string HesapNo { get; set; }
        public void ParaGonder(int tutar)
        {
            Console.WriteLine($"Para Gönderimi Garanti ile gerçekleştirilmiştir : {tutar}");
        }

        public bool ParaTransferi(int tutar, string hesapNo)
        {
            try
            {

                HesapNo = hesapNo;
                ParaGonder(tutar);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }


    //Burada görüldüğü üzere Halbank bankasının işlemleri için IBanka interface sinden implemente edilmiştir.
    class Halkbank : IBanka
    {
        string _hesapNo;
        public void GonderilecekHesapNo(string hesapNo)
        {
            Console.WriteLine($"Para gönderilecek hesap numarası : {hesapNo}");
        }
        public void Gonder(int tutar)
        {
            Console.WriteLine($"Para Gönderimi Halk Bank ile gerçekleştirilmiştir : {tutar}");
        }

        public bool ParaTransferi(int tutar, string hesapNo)
        {
            try
            {
                GonderilecekHesapNo(hesapNo);
                Gonder(tutar);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    //Garanti ve Halkbanka sı için geliştirmelerimizi tamamlamıştık. İşte yeni bir banka sisteme eklendiğinde burada da görüldüğü üzere diğer bankaların geliştirmeri değiştirilmeden yeni gelen banka aşağıdaki gibi sisteme dahil edilmiştir. Bu sayede kod değişikliğinin önüne geçmiş olduk ve kodun genişlemesine olanaj sağlamış olduk. Tekrardan söylemek gerekirse burada yapılan işlemler görüldüğü üzere diğer bankaların işlemlerini hiç ama hiç etkilememiştir.
    class FinansBank : IBanka
    {
        public bool ParaTransferi(int tutar, string hesapNo)
        {
            try
            {
                Console.WriteLine($"Para gönderilecek hesap numarası : {hesapNo}");
                Console.WriteLine($"Para Gönderimi Finans Bank ile gerçekleştirilmiştir : {tutar}");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}