using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            // ex1
            string FirstName;
            string LastName;
            double Age;
            string Sex;
            string PESEL;
            string EmployeeNumber;

            //ex2

            char letter1 = 'A';
            char letter2 = 'B';
            char letter3 = 'C';

            Console.WriteLine($"{letter3}, {letter2}, {letter1}");

            //ex3

            double side1;
            double side2;

            Console.WriteLine("Proszę podać długość pierwszego boku");
            double.TryParse(Console.ReadLine(), out side1);

            Console.WriteLine("Proszę podać długość drugiego boku");
            double.TryParse(Console.ReadLine(), out side2);

            double diagonal = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));

            Console.WriteLine($"Długość przekątnej to: {diagonal}");

            //ex4

            double var1;
            string var2;
            double var3;
            
            var1 = 10;
            var2 = "Szkoła Dotneta";
            var3 = 2.5;


            //ex5
            string PhoneNumber;
            string EmailAddress;
            double height;
            double weight;

            Console.WriteLine("Podaj swoje imię");
            FirstName= Console.ReadLine();

            Console.WriteLine("Podaj swoje nazwisko");
            LastName = Console.ReadLine();

            Console.WriteLine("Podaj swój numer telefonu");
            PhoneNumber = Console.ReadLine();

            Console.WriteLine("Podaj swój adres email");
            EmailAddress = Console.ReadLine();

            Console.WriteLine("Podaj swój wzrost w cm");
            double.TryParse(Console.ReadLine(), out height);

            Console.WriteLine("Podaj swoją wagę w kg");
            double.TryParse(Console.ReadLine(), out weight);


            Console.WriteLine($"Witaj {FirstName} {LastName}. Proszę upewnij się, że dane, które podałeś są prawidłowe: \r\n Numer telefonu: {PhoneNumber}");
            Console.WriteLine($" Adres Email: {EmailAddress} \r\n Wzrost: {height} \r\n Waga: {weight}");












        }
    }
}
