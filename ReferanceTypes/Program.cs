using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,boolean gibi değişkenler değer tiptir. (value types) Değer tipler stackte oluşur.
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("Sayı 1 :" + sayi1);

            //ekran çıktısı 20

            //arrays,class, interface referans tiplerdir. (referance type). Referans tipler stackte oluşup değerler heapte tutulur.  
            //Her new dediğimizde heapte veri oluşur ve adres değeri oluşur. Değerler heapte tutulur. Refereans tiplerde en son girilen değerler geçerlidir.

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("Sayılar1[0] =" + sayilar1[0]);

            //ekran çıktısı 1000

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Deniz";

            person2 = person1;
            person1.FirstName = "Burak";

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "123456780";

            Employee employee = new Employee();

            Person person3 = customer;
            customer.FirstName = "Ahmet";

            Console.WriteLine(person3.FirstName);

            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

        }
    }
        //base class: Person
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        class Customer :Person
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee :Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
