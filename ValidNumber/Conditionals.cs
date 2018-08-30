using System;

namespace ValidNumber
{
    public class Conditionals
    {
        public static void Exercise1()
        {
            Console.WriteLine("Please Enter a value between 1-10");
            var userInput = Console.ReadLine();

            try
            {
                var convertedInput = Convert.ToInt32(userInput);
                if (convertedInput >= 1 && convertedInput <= 10)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not a valid input.", userInput);
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Please enter a number.");
            var input1 = Console.ReadLine();
            Console.WriteLine("Please enter a second number.");
            var input2 = Console.ReadLine();

            try
            {
                var num1 = Convert.ToInt32(input1);
                var num2 = Convert.ToInt32(input2);

                var max = (num1 > num2) ? num1 : num2;
                Console.WriteLine("Max number is {0}", max);
                //Note: this does not identify if num1 and num2 are equal

            }
            catch (FormatException)
            {
                Console.WriteLine("Input was not valid.");
            }

        }

        public static void LandscapeOrPortrait()
        {
            try
            {
                Console.WriteLine("Please enter the image width.");
                var width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the image length.");
                var length = Convert.ToInt32(Console.ReadLine());

                var imageType = (width > length) ? "Landscape" : "Portrait";

                Console.WriteLine("The image is a {0}", imageType);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numbers for the width and length input.");
            }
        }

        public static void SpeedCamera()
        {
            try
            {
                Console.WriteLine("Please enter the Speed Limit:");
                var speedLimit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the car speed?");
                var carSpeed = Convert.ToInt32(Console.ReadLine());

                var kmperdemeritpoint = 5;

                if (carSpeed <= speedLimit)
                    Console.WriteLine("Ok");
                else
                {
                    var demerit = (carSpeed - speedLimit) / kmperdemeritpoint;
                    if (demerit > 12)
                        Console.WriteLine("License Suspended.");

                    else
                    {
                        Console.WriteLine("Demerit Points: " + demerit);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("The entry was not valid.");
            }


        }
    }
}
