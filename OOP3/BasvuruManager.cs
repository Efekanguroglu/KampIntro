using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
        
    {                               //Method İnjection
        public void BasvuruYap(IKrediManager krediManager , ILoggerService loggerService)           //!!!IKrediManager krediManager yazarsak  bi görevli sanki hangi kredi diye soruyormuş gibi olur!!!!!
        {

                                                        //Başvuru bilgilerini değerlendirme       //krediyi bağımsız hale getirdik gönderdiğimiz
                                                                   //****değere göre alır konut gönder konut çalışır ihtiyaç gönder ihtiyaç çalışır**

            
           // KonutKrediManager konutKrediManager = new KonutKrediManager();      //     ******sadece konut kredisine göre alırlar bu da yanlış***
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler )//soru= Aynı veri türünde  0 1 10000 tane de olabilecek bir yapı ??
                                                                           //belli sayıda  o sayı da belirsizse vrei grubu oluşturmak için?  ===List<>
        {
            foreach (var kredi in krediler)  // Üsttekini tek tek dolaşacak
            {
                kredi.Hesapla();
            }
        }
    }
}
