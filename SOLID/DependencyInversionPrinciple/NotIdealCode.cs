namespace DependencyInversionPrinciple
{

    /*
     Dependency Inversion Principle , bir sınıfın herhangi bir türe olan bağımlılık durumuna karşı dikkatimizi çeken ve bu bağımlılığın mümkün mertebe tersine çevrilmesini öneren ilkedir.

    Bu prensip: geliştiricinin herhangi bir türe bağımlı olmadığını, bilakis türlerin/yani nesnelerin geliştiriceye bağımlı olduğunu savunur.

    Şimdi burada MailService , eğer ki içerisinde direkt Gmail kullanılıyorsa bu durumda Gmail'e bağlımı demektir. Böylece yapacağımız bütün mail işlemlerini sadece Gmail ile yapabilecektir.

    Bu bağımlılık , ihtiyace bianen diğer mail servislerini kullanma gereği hissedildiği zaman kodda değişikliğe sebep olacaktır.

    Dependecny Inversion prensibi gereği bağımlıkları tersine çevirecek bir yaklaşım sergilersek eğer artık Mail Service herhangi bir server'a bağımlı olmayacak tüm mail serverları karşılayabilecek IMailServer arayüzüyle çalışacaktır.

    Böylece Mail service'de herhangi bir mail server kullanılabilecektir. Yani artık mail serverladan hangisi çağrılırsa o iş yapacaktır. Bu da mail serverların Mail Service bağlı olduğu anlamına gelecektir.

    Bu prensipte en önemli nokta => Bu prensibi uygularken nesnelerin iletişimini soyut / abstraction yapılar üzerinden gerçekleştiriyoruz. (Interface vb.)
     */

    //Buradaki MailService sınıfı şuan Gmail sınıfına bağımlı olmuş oldu. Bu yaklaşımın ideal tasarımını IdealCode sınıfı üzerinde bulabilirsiniz.
    class MailService
    {
        public void SendMail(Gmail gmail)
        {
            gmail.Send("...");
        }
    }

    class Gmail
    {
        public void Send(string mail)
        {
            Console.WriteLine($"Gmail ile mail gönderildi : {mail}");
        }
    }
    class Yandex
    {
        public void SendMail(string mail, string to)
        {
            Console.WriteLine($"Yandex ile mail gönderildi : {mail},{to}");
        }
    }
    class Hotmail
    {
        public void Send(string mail)
        {
            Console.WriteLine($"Hotmail ile mail gönderildi : {mail}");
        }
    }
}
