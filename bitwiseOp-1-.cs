
class Program{

    static void Maind(string[] args)
    {
        /* BITWISE İŞLEMLER - GİRİŞ KISIM 1 (BİR) -
         *
         * and, or, sola sağa kaydırma işlemleri (shift), döndürme 
         *
         * Int yani tam sayılarda negatif kavramı:
         *      Tam sayılar bakış açısına göre değişir. Baştan işaretli veya işaretsiz diye kabul edilir. Bu durum programlama dillerinde
         *      int a; a = 100;
         *      uintb = 123; ( Negatif sayıları yapısında barındırmaz )
         *      short c = -1;
         *      ushort d = 1;
         *      byte e = 1;
         *      sbyte f = -1; (Negatif yazabilmek için bu şekilde yazmak gerek)
         *      
         *      Ne olduğunda unsigned (işaretsiz) forma yazılır?
         *          Eğer örnek verecek olursak 8 bitlik bir sayı signed formda ise en soldaki sayı sign yani işaret biti olur.
         *          ve sakladığımız veri için oradaki alan küçülür 7 bitlik olur.
         */

         /* SHIFT İŞLEMLERİ
         *
         * 991 sola doğru shift edilirse 910 olur 
         * 023 sola doğru shift edilirse 230 
         * 0011 sola doğru shift edilirse 0110
         *
         * 2 (iki) ile çarpmak anlamına gelir.
         */


         /* AND - OR İŞLEMLERİ (Mantık matematiği)
         * 
         *  Karşılıklı bitleri and veya or işlemlerine tabi tutar.
         * 
         *      1 or x = 1      0 or x = x 
         *      1 and x = x     0 and x = 0
         *      
         *  00000000000000000000000000000010    ->  32 bitlik 1 sayısının 2. bit'ini 1 yapmak istiyoruz.
         *  xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx        Or işleminden
         *  xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx1x        çıkar
         */


        //  3. ve 7. bitleri 0 yapalım
        //  111111111111111111111111 1011 1011
        uint b = 0xffffffbb;
        Console.WriteLine(a & b);
        if ((a & 1) == 1) Console.WriteLine("Tek"); else Console.WriteLine("Çift");


        Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
//----------------------------------------------------------------------------------------------------------------------------------------------

        uint a = 131231235; //Binary karşılığı nedir?
        b = 1;
        for (int i = 0; i < 32; i++)
        {
            if ((a & b) == 0) Console.Write("0");
            else Console.Write("1");
            b = b << 1; // Sola doğru shift edildi
        }

        //YUKARIDAKİ ALGORİTMANIN BİR EKSİĞİ BULUNUR O DA AŞAĞIDA 

        a = 0xffffff00; //Bu şekilde olduğunda tersten yazıyor ÇÖZÜMÜ :
        //b = 1;
        b = 0x80000000; //Bu şekilde yaparsak doğru yazar
        for (int i = 0; i < 32; i++)
        {
            if ((a & b) == 0) Console.Write("0");
            else Console.Write("1");
            b = b >> 1; // Sağa doğru shift edildi
        }

        Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
//----------------------------------------------------------------------------------------------------------------------------------------------

        //Bir A sayısının içinde kaç tane 1 vardır?
        a = 0xffffff00;
        b = 0x80000000;
        int adt = 0;
        for (int i = 0; i < 32; i++)
        {
            if ((a & b) != 0) adt++;
            b = b >> 1; 
        }
        Console.WriteLine(adt);

    }
}
