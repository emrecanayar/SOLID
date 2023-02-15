namespace InterfaceSegregationPrincipleIdealCode
{

    /*
     
     Burada görüldüğü üzere interfacelerin her birini anlamlı parçalar haline böldük ve ilgili classlara ihtiyacı olan interfaceleri teker teker implemente ettik. Bu sayede kullanılmayan metot veya operasyon bizim classlarımız içersinde yer almadı. Daha temiz ve amacına uygun bir kod bloğu geliştirmiş olduk.

    Interface Segragation Prensinbibin en temel bakıs acısı ve yaklasımı bu şekildedir.
     */
    interface IPrint
    {
        void Print();
    }
    interface IScan
    {
        void Scan();
    }
    interface IFax
    {
        void Fax();
    }
    interface IPrintDuplex
    {
        void PrintDuplex();
    }
    class HPPrinter : IPrint, IScan, IFax, IPrintDuplex
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
    class SamsungPrinter : IPrint, IFax
    {
        public void Fax()
        {
            Console.WriteLine("Fax işlemi gerçekleştirildi.");
        }

        public void Print()
        {
            Console.WriteLine("Print işlemi gerçekleştirildi.");
        }
    }
    class LexmarkPrinter : IFax, IPrint, IScan
    {
        public void Fax()
        {
            Console.WriteLine("Fax işlemi gerçekleştirildi.");
        }

        public void Print()
        {
            Console.WriteLine("Print işlemi gerçekleştirildi.");
        }

        public void Scan()
        {
            Console.WriteLine("Scan işlemi gerçekleştirildi.");
        }
    }

}
