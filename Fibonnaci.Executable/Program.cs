using System;
using Fibonnaci;

namespace ExamPreparation
{
    class Program
    {
        static void Main()
        {
            try
            {
                IFibonnaciReader reader = new FibonnaciReader();

                Console.WriteLine("Please enter the number of elements to be displayed");
                var input = Console.ReadLine();
                var number = Convert.ToInt32(input);


                Console.WriteLine("Please enter the number that you would like to start with");
                var secondInput = Console.ReadLine();
                var initialValue = Convert.ToInt32(secondInput);

                var arrayOfNumbers = new double[number];
                arrayOfNumbers[1] = initialValue;

                Console.WriteLine("Your total is: ");
                
                reader.Evaluate(number, arrayOfNumbers);
                foreach (var numbers in arrayOfNumbers)
                {
                    Console.Write(numbers + " ");
                }

                Console.ReadLine();
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid format, application can only take digits");
                Console.ReadLine();
            }

            catch (OverflowException)
            {
                Console.WriteLine("The number provided is too big, please try a smaller number");
                Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
