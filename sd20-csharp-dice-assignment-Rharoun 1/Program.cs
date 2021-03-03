using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Let op deze opdracht is in het Engels.
             * 
             * De opdracht beschrijving: Er moet een kleine dobbelsteen generator gemaakt worden.
             * Deze dobbelsteen applicatie is echter nog niet helemaal af en deze moet jij af maken.
             * In de applicatie vind je verschillende TODO's. Op deze plekken moet jij de code aanvullen of
             * repareren.
             * BELANGRIJK: Zorg ervoor dat je voor elke TODO een commit maakt met een juiste bericht. 
             * De TODO comment mag je weg halen na het repareren van de code.
             * TODO #5 Staat in de Dice class.
             */


            Console.WriteLine("Hello Dice player what's your name?");
            // TODO #1 Let the player fill in his/her name and store that in a variable

            string Name = Console.ReadLine();



            // TODO #2 Use the filled in name to say hello to the player
            Console.WriteLine("Oh hello there. player " + Name);


            Console.WriteLine("How many dice do you want to throw?");
            // TODO #3 Create a list/array variable with the amount of dice the player want to throw. Don't forget to fill the list with the Die object class.




            /* figure out how to add the Readline to a Array 
             * Use the for loop to fill up the array
             * */
            bool valid = true;


            int times = 1;
            //for (int 1 = 0; 1 <dices.Length; i++) ??
            while (valid)
            {​// jupp :P met een for loop moet je throw dices aanroepen zoveel keer als times en dan het nummber storen om deze manier
                // dices[i] = GetEyes(); ik maak de random functio wel ok is af
                try
                {
                    times = Convert.ToInt32(Console.ReadLine());
                    valid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Je moet een nummer invoeren");
                }
            }


            int[] dices = new int[times];

            Console.WriteLine("When ever you are ready. You can throw the dice by pressing the 'any'-key.");
            Console.ReadKey();


            Die DieClass = new Die();


            for (int i = 0; i < times; i++)
            {
                DieClass.ThrowDice();
                dices[i] = DieClass.GetEyes();
                Console.WriteLine($"Die {​​​​​​​i}​​​​​​​: {​​​​​​​dices[i]}​​​​​​​");
            }


            int total = 0;


            foreach (int current in dices)
            {
                total += current;
            }
            Console.WriteLine($"Total number = {​​​​​​​total}​​​​​​​");
        }
    }
}