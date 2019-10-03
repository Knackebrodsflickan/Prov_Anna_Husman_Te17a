using System;
using System.Collections.Generic;

namespace Anna_Husman_te17a_prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Books FirstBook = new Books(); // Här har vi då skapat en ny book, alltså en ny metod som heter Firstbook som jag kommer använda som en hållare för all information om boken
            Books SecondBook = new Books(); // gäller samma för alla 
            Books ThirdBook = new Books();
            Books FourthBook = new Books();
            

            Console.WriteLine("Would you like to name your book?");
            string namnBook = Console.ReadLine(); // Här låter jag spelarena graver in sitt namn på en utav böckerna-  skulle utvecklat viader det så man kunde sätta på varje enskild bok men hann inte 
            Console.WriteLine("Say hello to your new book with this name ingraved on it " + namnBook);
            Console.ReadLine(); 

            Console.WriteLine("please write your customers names");
            string input = Console.ReadLine(); //Här får du skriva en lista med dina egna kunder 

            List<string> Kunder = new List<string>(); // här har jag då skapat sedd lista där vi ser att vi har gjort en string som heter input som tillåter spelaren att här skriva inn ( på kunder. add input ) vilka namn dem vill ha med 
            Kunder.Add(input);

            string inputNewKund = Console.ReadLine();  // samma i princip 
            Kunder.Add(inputNewKund);

            foreach (var kund in Kunder)
            {
                Console.WriteLine(kund); // samlar alla 
            }
            Console.WriteLine("This is a list of your customers " + Kunder); // skriver ut kunderna 
            Console.ReadLine();

            Console.WriteLine("What book would you like to take a look at? Pick 1, 2, 3 or 4, and by the way! The way we measure the rarity of a book these days is through numbers! the most rare being 100, and the least rare being 1 ");
            string AnotherInput = Console.ReadLine(); //åter igen tillåter spelaren att välja från en lista - tänkte göra en array här men han inte. och sedan skriva in sitt svar 

            if(AnotherInput == "1") // om spelaren skriver 1 så ska du visa : 
            {
                Console.WriteLine("This is the price: " + NewPrice); // här kommer mina metoder fram med random gen som slumpar ut ett random number från det olika categorierna 
                Console.WriteLine("Rarity: " + NewRarity); // (( DET ÖVRE GÄLLER ÅD FÖR ALLA UTOM CATEGORY där jag har en lista och en random gen som slumpar ut från den 
                Console.WriteLine("Value: " + actualValue);
                Console.WriteLine("Category: " + Category);
                Console.ReadLine();
            }
            if ( AnotherInput == "2")
            {
                Console.WriteLine("This is the price: " + NewPrice);
                Console.WriteLine("Rarity: " + NewRarity);
                Console.WriteLine("Value: " + actualValue);
                Console.WriteLine("Category: " + Category);
                Console.ReadLine();
            }
            if (AnotherInput == "3")
            {
                Console.WriteLine("This is the price: " + NewPrice);
                Console.WriteLine("Rarity: " + NewRarity);
                Console.WriteLine("Value: " + actualValue);
                Console.WriteLine("Category: " + Category);
                Console.ReadLine();
            }
            if (AnotherInput == "4")
            {
                Console.WriteLine("This is the price: " + NewPrice);
                Console.WriteLine("Rarity: " + NewRarity);
                Console.WriteLine("Value: " + actualValue);
                Console.WriteLine("Category: " + Category);
                Console.ReadLine();
            }

            var random = new Random(); // Här ser vi den listan som min category slumpas ifrån 
            var Category = new List<string> { "thriller", "romace", "fantasy", "horror" };
            int index = random.Next(list.Count);
            Console.WriteLine(Category[index]); // Här har vi indexet 







        }
    }
}