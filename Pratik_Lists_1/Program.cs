//kisiler adında liste oluşturuyorum. Add ile isimleri gireceğim.﻿
List<string> kisiler = new List<string>();

kisiler.Add("Bülent Ersoy");
kisiler.Add("Ajda Pekkan");
kisiler.Add("Ebru Gündeş");
kisiler.Add("Hadise");
kisiler.Add("Hande Yener");
kisiler.Add("Tarkan");
kisiler.Add("Funda Arar");
kisiler.Add("Demet Akalın");

//foreach döngüsü ile girdiğim isimleri ekranda yazdırıyorum.
foreach (string kisi in kisiler)
{
    Console.WriteLine(kisi);
}
