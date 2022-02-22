using System;

namespace Constructers
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1,FirstName="Efekan",LastName="Güroğlu",City="Muğla"};
            Customer customer2 = new Customer(2,"Ahmet","Kargan","İstanbul"); // Customer kızdı çünkü 22.satırda Customer e () ın içine herhangi bir şey yazmadık
            Customer customer3 = new Customer();                                                             // o yüzden buradaki Customer kızdı
            customer3.Id = 3;

           // Method()  açınca parametreleri söyler

        }
        // static void Method(int id,string firstName,string lastName,string city)
        //{

        //}
    }


    class Customer

    { // default constructor
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city) // böyle yazınca da 9. satırdaki customer kızdı
                                                                                // onun için üstüne bir tane daha ctor açman gerekir 29.satır
        {
            Id = id;
            FirstName = firstName;    //bunu yapmamızın amacı yuakrda kullandığımız küçük harfler başlayanları class içindeki get set değerlerine işlersek                         
            LastName = lastName;                            //yukardaki değerlerde kullanabiliriz
            City = city;
        } 
        public int Id { get; set; }
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
