using System;
using System.Collections.Generic;
using System.Text;

namespace Annnna_Husman_te17a_prov
{
    class Böcker
    {
        static Random generator = new Random(); // skapar en random generator som metoderna nedanför använder 
        public int NewPrice = generator.Next(200, 400);
        public int NewRarity = generator.Next(1, 100);
        public int actualValue = generator.Next(100, 700);

       public static bool NextBool(this Random Cursed, int truePercentage = 50) // mitt försök till att använda en random gen till att se om en bok är cursed eller inte, vilket tydligen stör classen för någon anlending då den blir röd runt "böcker" 
        {
            return Cursed.NextDouble() < truePercentage / 100.0;  // den skriver ut i procent enheter hur stor sannolikhet det är att den är cursed 
        }

    
       
        
       








    }
}
