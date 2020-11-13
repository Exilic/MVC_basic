using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Text;
namespace MVCBasicsAssignment.Models
{
    public class RandomNumber
    {

        public static string Evaluate(string userGuess, int random, int trial)
        {
            string message = "";
            int guess = Int32.Parse(userGuess);
            if (guess > random)
            {
                message = "Your guess number " + trial + " was too high. Try a lower number." + guess + " " + random;
            } else if (guess < random)
            {
                message = "Your guess number " + trial + " was too low. Try a higher number." + guess + " " + random;
            } else
            {
                message = "Yes, you guessed the right number " + random + " on try " + trial + "__" + guess + " " + random;
            }

            return message;
        }
    }
}
