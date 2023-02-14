#region Ideal Code


//Örnek olarak garanti bankasından para gönderme işlemi yapalım.
OpenClosedPrincipleIdealCode.ParaGonderici paraGondericiGaranti = new();
paraGondericiGaranti.Gonder(new OpenClosedPrincipleIdealCode.Garanti(), 100, "GarantiHesap001");


//Örnek olarak halk bankasından para göndereme işlemi yapalım
OpenClosedPrincipleIdealCode.ParaGonderici paraGondericiHalbank = new();
paraGondericiHalbank.Gonder(new OpenClosedPrincipleIdealCode.Halkbank(), 120, "HalkBankHesap002");

//Yine daha sonradan eklenen Finansbank için para gönderme işlemi yapacaksak aynı işlemi tekrardan kullanabiliriz.
OpenClosedPrincipleIdealCode.ParaGonderici paraGondericiFinansBank = new();
paraGondericiFinansBank.Gonder(new OpenClosedPrincipleIdealCode.FinansBank(), 140, "FinansBankHesap001");


//Evet burada gördüğümüz üzere dilediğimiz bankadan bu şekilde kodları değiştirmeden herhangi bir banka için gönderme işlemi yaparken diğerinin içerisinde herhangi bir değişilik yapmadan bu Open/Closed Principle sayesinde bu işlemi gerçekleştirebiliyoruz.

//Sisteme herhangi yeni bir banka eklendiğinde yine onu IBank interfaceinden türettikten sonra ParaGonderici sınıfı içerisinde IBank nesnesini sisteme yeni eklemiş olduğumuz bankanın sınıfından türeterek yukarıdaki gibi diğerlerine karışmadan gönderebiliriz.


Console.Read();
#endregion