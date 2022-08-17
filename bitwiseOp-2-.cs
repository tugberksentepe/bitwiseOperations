class Program
    {
        
        static void Main(string[] args)
        {

            //BITWISE İŞLEMLER - EGZERSİZLER KISIM 2 (İKİ) -

            //Soru1: 32 bitlik bir sayıyı rotate edelim. 

            uint a = 0xffffffff;    //a değerini bu şekilde aldığımızda değişiklik olmuyor. Neden? 
            //uint a = 1;
            uint b = 0x80000000; //Maske oluşturuyoruz en yüksek bit değerinin 1 mi 0 mı olduğunu görebilmek için
            for (int i = 0; i < 32; i++)
            {
                Console.WriteLine(a);
                if ((a & b) != 0)
                {
                    a = a << 1;
                    a++;
                    //a yı 1 arttırmak yerine alternatif çözüm : a=a|1;
                }
                else a <<= 1;
            }
            Console.WriteLine(a);

            //----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            //Soru 2: A sayısının Bit bazlı değilini almak:

            //1010 binary sayısını
            //0101 haline getirmek istiyoruz.
            
            a = 0xffffffff;
            //a = 1; 
            b = 1;
            uint c = 1;
            uint d = 0xfffffffe;

            for (int i = 0; i < 32; i++)
            {
                
                if ((a & b) == 0)
                {
                    //bit'i bir yap
                    a = a | c;
                }
                else 
                { 
                    //bit 0 olacak
                    a = a & d;  
                }
                b <<= 1;
                c = c << 1;
                d = d << 1;d++;
            }
            Console.WriteLine(a);

            //----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");


            //Soru 3: b sayısına a sayısının değerini yükleyeyim bit bit.

            a = 0xf;
            b = 0x80000000;

            // b = a; işlemini bit işlemleriyle kendimiz yapalım.

            c = 1;
            b = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((a & c) != 0) { b = b | c; }
                c <<= 1;
            }
            Console.WriteLine(a);
            Console.WriteLine(b);


            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------"); 

            //Soru4: En yüksek seviyeli 5 biti 1 arttıracak kod nasıl olmalıdır?

            //Ondalık sayı sistemninde bir örnekle anlatalım işlemimizi:

            //345678944566
            //000010000000      Eğer bu ikisini toplarsak istediğimiz sonucu elde ederiz.
            
            // 1. ÇÖZÜM:
         
            a = 0xefffffff;
            Console.WriteLine(a);
            b = 0x08000000; // Maskemiz

            a = a + b;
            Console.WriteLine(a);

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            //2. Çözüm UZUN ÇÖZÜM : Zihin gelişimi için

            //Önce en yüksek seviyeli 5 biti alalım
            b = a & 0xf8000000;
            b = b >> 27;
            //Buna 1 eklemek istiyorum 
            b++;
            //Eski haline getirdik.
            b <<= 27;
            a = a & 0x07ffffff; //b=a işlemini yaptıpğımız için burada a yı eski haline getirdik.
            a = a | b;

        }
    }