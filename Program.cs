using System;

namespace Lab_11_version_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Movie List Application!");  // intro line- only used once
            
            string userContinue;
            do
            {
                bool isInvalid;
                do
                {
                    var result = GetNumberSafely(); // continue method
                    MovieChoice(result);
                    Console.WriteLine("Would you like to continue? (y/n)");
                    userContinue = Console.ReadLine().ToLower();
                    isInvalid = userContinue != "y" && userContinue != "n";
                    if (isInvalid)
                    {
                        Console.WriteLine("Please enter a 'y' or 'n'!" + "\n");
                    }
                } while (isInvalid);
            } while (userContinue == "y");



            Console.WriteLine("Goodbye!"); // goodbye
            Console.ReadLine();
        }
        private static int GetNumberSafely()
        {
            int result;
            string userMovie;
            bool isValid;

            
            do
            {
                Console.WriteLine("What category are you interested in?"); // user input section
                Console.WriteLine("For Scifi, enter 1");
                Console.WriteLine("For Animated, enter 2");
                Console.WriteLine("For Horror, enter 3");
                Console.Write("For Drama, enter 4" + "\n\n" + "Enter your choice here: ");

                userMovie = Console.ReadLine();
                isValid = int.TryParse(userMovie, out result);
            } while (!isValid);

            return result;
        }

        private static bool MovieChoice(int response) // calling methods to main
        {
            if (response == 1)
            {
                var Scifi = new Movie();
                Scifi.GetSciFi();
            }
            else if (response == 2)
            {
                var Animated = new Movie();
                Animated.GetAnimated();
            }
            else if (response == 3)
            {
                var Horror = new Movie();
                Horror.GetHorror();
            }
            else if (response == 4)
            {
                var Drama = new Movie();
                Drama.GetDrama();
            }
            else
            {
                Console.WriteLine("Please enter a valid number!"); // safety number validity
            }
            return false;
        }
    }
}
