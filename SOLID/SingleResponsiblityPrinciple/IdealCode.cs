namespace SingleResponsiblityPrinciple;

/*
 
 Şimdi buradaki sınıf mekanızmalarına bakacak olursak burada NotIdealCode sınıfında yer alan alanları Single Responsiblity Prensibine uygun hale getirmiş olduk.

Database sınıfı içerisinde teknik olarak yer olacak olan Connect , Disconnect metotlarını ve State propertysini tanımladık.

Person için ise bir PersonService sınıfı oluşturduk. Bu sınıf içerisine person ile ilgili verileri getiren GetPersons() adında bir metot oluşturulduk. Bu sayede dabase işlemlerini yapan sınıfı ve person ile ilgili işlemleri yapan sınıfı ayırmış olduk.

Her sınıf kendi içerisindeki yapılardan sorumlu olmuş oldu. Single Responsiblity Prensibinine göre her sınıfın kendine ait bir işi olmalı ve sadece bu iş için geliştirilmeli aynı zamanda sadece bir iş güncellenmelid,r. Bizde bunun neticisinde temelde birbirinden farklı iki ayrı işi iki ayrı sınıfa ayırmış olduk.
 
 */


class Database
{
    public void Connect()
    {
        //...
        Console.WriteLine("Veritabanı bağlantısı sağlanmıştır.");
    }
    public void Disconnect()
    {
        //...
        Console.WriteLine("Veritabanı bağlantısı kesilmiştir.");
    }
    public string State { get; set; }
}

class PersonService
{
    public List<Person> GetPersons()
    {
        return new() {
            new(){ Name = "Hilmi", Surname = "Celayir" },
            new(){ Name = "Mustafa", Surname = "Yıldız" },
            new(){ Name = "Cafer", Surname = "Muiddinoğlu" }
        };
    }
}