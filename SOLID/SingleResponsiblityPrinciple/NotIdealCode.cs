using SingleResponsiblityPrinciple;

namespace SingleResponsiblityPrincipleNotIdealCode;

//Single Responsiblity Prensibine aykırı olarak geliştirilen koda örnek vermek amaçlı oluşturulmuştur.
class Database
{
    /*
     Bu sınıfın tasarımı Single Responsiblity Prensibine aykırıdır. Çünkü içerisine baktığımızda veri tabanı connect ve disconnect metotlarının yanında başka bir işi yapan GetPersons() metoduna yer almaktadır.

    GetPersons() metodunu incelediğimizde bunun aslında veri tabanı ile direkt olarak alakası yok daha çok veri tabanında var olan bir veriye getirmekle ilgileniyor. İşte bu sebepten dolayı bu metodun bu sınıf içerisinde yer alması uygun değil.
     
    Dışarından bakan bir kişi burası için bu sınıf temel veritabanı işlemlerini yapan bir sınıf mı yoksa persons ile ilgili bir sınıf mı diye sorabilir. İşte bunun cevabını biz net olarak veremediğimiz için bu sınıf doğal olarak Single Responsiblity Prensibine aykırıdır.

    Biz doğru yaklaşım için IdealCode classına bir göz atalım.
     
     */
    public void Connect()
    {
        Console.WriteLine("Veritabanı bağlantısı sağlanmıştır.");
    }
    public void Disconnect()
    {
        Console.WriteLine("Veritabanı bağlantısı sağlanmıştır.");
    }
    public string State { get; set; }

    public List<Person> GetPersons()
    {
        return new() {
        new(){ Name = "Hilmi", Surname = "Celayir" },
        new(){ Name = "Mustafa", Surname = "Yıldız" },
        new(){ Name = "Cafer", Surname = "Muiddinoğlu" }
    };
    }
}
