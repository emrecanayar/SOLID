namespace DependencyInversionPrincipleIdealCode
{
    class MailService
    {
        public void SendMail(IMailServer mailServer, string to, string body)
        {
            mailServer.Send(to, body);
        }
    }

    //Burada görüldüğü üzere araya bir interface koyduk ve sınıfları bundan implement ettik.
    interface IMailServer
    {
        void Send(string to, string body);
    }
    class Gmail : IMailServer
    {
        public void Send(string to, string body)
        {
            Console.WriteLine($"Gmail ile mail gönderildi : {body},{to}");
        }
    }
    class Yandex : IMailServer
    {
        public void Send(string to, string body)
        {
            Console.WriteLine($"Yandex ile mail gönderildi : {body},{to}");
        }
    }
    class Hotmail : IMailServer
    {
        public void Send(string to, string body)
        {
            Console.WriteLine($"Hotmail ile mail gönderildi : {body},{to}");
        }
    }
}
