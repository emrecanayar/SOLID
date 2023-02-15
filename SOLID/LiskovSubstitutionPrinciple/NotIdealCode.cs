namespace LiskovSubstitutionPrinciple
{

    /*
     
     Liskov Substitution Principle ortak bir referanstan türeyen nesnelerin hiçbir şeyi bozulmadan, patlamadan, çatlamadan birbirleriyle değiştirilmesi gerektiğini yani birbirlerinin yerine geçebilmesi gerektiğini öneren bir prensiptir.

    Eğer bir sınıf , herhangi bir interface veya abstract class ile sözleşme yapıyorsa o zaman bu sözleşmenin gereğini karşılamalı ve gerekli tüm memberları içerisinde tanımlamalıdır. Lakin sınıf aldığı bu memberlardan boş ve işlevsiz olanlar varsa işte orada bir problem var demektir.

    Hiçbir alt sınıf impelemente oldugu arayüzden aldığı metotları ihmal etmemelidir. Kısacası bir interface veya abstract class içerisinde yer alan metotlar bu interface den yada abstract sınıftan türeyen sınıflar içerisinde tamamen kullanılmalıdır. Kullanılmayan metotlar Not Implement Exception türünde hatalar döndürmemelidir.

    Böyle bir durumda nesneler birbirlerini yerine geçebilir fakat ister istemez kodda patlamalar meydana gelir. Şimdi aşağıdaki ideal olmayan kod yapısını bir incleyelim ve konuyu daha rahat anlamaya calısalım.


     */

    //Şimdi burada görüldüğü üüzere Cloud adına bir abstract sınıfımız var ve bu sınıftan türeyen AWS,Azure  ve Google sınıflarımız mevcut. Abstract classın içerisinde yer alan Translate ve MachineLearning metotları görüldüğü üzere abstract olarak işaratlenmiş yani bu sınıftan türeyen bütün sınıfların içerisinde kesinlike kullanılması gerektiği aktarılmış. Şimdi bu duruma göre türeyen sınıflara bakalım.
    abstract class Cloud
    {
        public abstract void Translate();
        public abstract void MachineLearning();
    }

    //Burada hep translate hem de machineLearning yapısı mevcut olduğundan dolayı burada herhangi bir sorun olmadna her iki metot içerisine de doldurmuş olduk.
    class AWS : Cloud
    {
        override public void Translate()
            => Console.WriteLine("AWS Translate");
        override public void MachineLearning()
            => Console.WriteLine("AWS Machine Learning");
    }

    //Fakat burada Azure da sadece Machine Learning için bir metotun içerisini doldurmuş olduk. Azure içerisinde Translate servisi olmadıgından dolayı burada translate metotunun içerisini dolduramadık ve geriye NotImplementException şeklinde hata dönmek zorun kaldık. İşte bu durum Liskov un istediği bir durum değil Liskov diyorki eğer sen bu abstract class dan bir sınıf türeteceksen içerisindeki her metotu yada her alanı kullanman gerekmektedir. Ama burada gördüğümüz üzere Translate() metodu kullanılmamış oluyor.
    class Azure : Cloud
    {
        override public void Translate()
            => throw new NotImplementedException();

        override public void MachineLearning()
            => Console.WriteLine("Azure Machine Learning");
    }

    //Burada hep translate hem de machineLearning yapısı mevcut olduğundan dolayı burada herhangi bir sorun olmadna her iki metot içerisine de doldurmuş olduk.
    class Google : Cloud
    {
        override public void Translate()
            => Console.WriteLine("Google Translate");

        override public void MachineLearning()
            => Console.WriteLine("Google Machine Learning");
    }

    //Günün sonunda bu nesneleri birbirlerinin yerine referans olarak kullanmaya kalktığımızda Translate metodunda patlamalar catlamalar meydana gelir. Bunun düzeltmek için ise nasıl bir yapı kurmamız gerekiyor öğrenmek için IdealCode sınıfına bakabilirsiniz.
}
