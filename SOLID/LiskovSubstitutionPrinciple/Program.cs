#region Not Ideal Code
using LiskovSubstitutionPrincipleIdealCode;

//Ideal olamayan kullanımda aşağıdaki gibi bir yapı mevcut buda istediğimiz bir yöntem değil en altaki nesneye baktığımızda Azure sınıfından üretildiğinde Translate metodu çalışmayacaktır. Buda birbirlerinine yerine referans almış olan sınıflar arasında farklılıklara ve çatlamalara neden olacaktır.
LiskovSubstitutionPrinciple.Cloud cloud = new LiskovSubstitutionPrinciple.AWS();
cloud.MachineLearning();
cloud.Translate();

cloud = new LiskovSubstitutionPrinciple.Google();
cloud.MachineLearning();
cloud.Translate();

cloud = new LiskovSubstitutionPrinciple.Azure();
cloud.MachineLearning();
if (cloud is not LiskovSubstitutionPrinciple.Azure)
{
    cloud.Translate();
}
#endregion


/*
 Burada da görüldüğü üzere Liskovun kullanımı aynı nesne üzerinden nasıl rahatça gerçekleştirilebiliyor. Görmüş oluyoruz.
 
 */
#region Ideal Code

LiskovSubstitutionPrincipleIdealCode.Cloud cloudIdealCode = new LiskovSubstitutionPrincipleIdealCode.AWS();
cloudIdealCode.MachineLearning();
(cloudIdealCode as ITranslatable)?.Translate();

cloudIdealCode = new LiskovSubstitutionPrincipleIdealCode.Google();
cloudIdealCode.MachineLearning();
(cloudIdealCode as ITranslatable)?.Translate();

cloudIdealCode = new LiskovSubstitutionPrincipleIdealCode.Azure();
cloudIdealCode.MachineLearning();
(cloudIdealCode as ITranslatable)?.Translate();
#endregion