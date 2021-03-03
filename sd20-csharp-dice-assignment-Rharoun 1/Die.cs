using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame
{
    public class Die
    {
        // Attributes
        public int maxEyes;
        public int eyes;

        /**
         * Constructor
         */
        public Die()
        {
            maxEyes = 6;
            eyes = 1;
        }

        /**
         * This methode will randomize the dice.
         * You can get the randomized eyes by using the GetEyes() method
         */
        public void ThrowDice()
        {
            Random rnd = new Random();
            eyes = rnd.Next(1, 7);
            // TODO #5 Make the randomizer and set a random number in the eyes variable.
        }

        public int GetEyes()
        {
            return eyes;

        }
    }
}