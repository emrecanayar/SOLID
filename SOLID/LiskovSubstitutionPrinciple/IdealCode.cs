namespace LiskovSubstitutionPrincipleIdealCode
{
    /*
     Buraya baktığımızda Cloud abstract sınıfı içerisinde hepsinde ortak olarak çalışan MachineLearning metodunu bıraktık ve Translate metodu içinde bu metot hepsinde yer almadığı için ITranslatable adında bir interface oluşturduk. Translate işleminin gerçekleştiği yerde Cloud sınıfından türetilen sınıfın yanında ITranslate interface nide implemente edeceğiz. 

    Bu sayede sınıflar içerisinde boş metot kalmamış olacak. Translate işlemi yapan sınıflar interfaceden implement olarak bu ihtiyaçlarını gidermiş olacaklar. 
     
     */


    abstract class Cloud
    {
        public abstract void MachineLearning();
    }
    interface ITranslatable
    {
        void Translate();
    }
    class AWS : Cloud, ITranslatable
    {
        public void Translate()
           => Console.WriteLine("AWS Translate");
        override public void MachineLearning()
            => Console.WriteLine("AWS Machine Learning");
    }

    class Azure : Cloud
    {
        override public void MachineLearning()
            => Console.WriteLine("Azure Machine Learning");
    }

    class Google : Cloud, ITranslatable
    {
        public void Translate()
           => Console.WriteLine("Google Translate");

        override public void MachineLearning()
            => Console.WriteLine("Google Machine Learning");
    }

}
