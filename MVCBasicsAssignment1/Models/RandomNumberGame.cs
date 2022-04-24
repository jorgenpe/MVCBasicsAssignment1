using System;
namespace MVCBasicsAssignment1.Models
{
    public class RandomNumberGame
    {
        private static string randomNumber;
        private Random random = new Random();

        public RandomNumberGame()
        {
            randomNumber = random.Next(1,101).ToString();
        }

        public string GetRandomNumber()
        {
            return randomNumber;
        }
         public void SetRandomNumber() { randomNumber = random.Next(1, 101).ToString(); }
    
    }
}
