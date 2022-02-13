using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Efekan";
            int yas = 36;
            Kurs kurs1 = new Kurs();

        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
