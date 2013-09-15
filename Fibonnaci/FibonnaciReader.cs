namespace Fibonnaci
{
    public class FibonnaciReader : IFibonnaciReader
    {
        public void Evaluate(int number, double[] arrayOfNumbers)
        {
            GetValue(number, arrayOfNumbers);
        }

        private static void GetValue(int number, double[] arrayOfNumbers)
        {
            for (var i = 1; i < number - 1; i++)
            {
                var total = arrayOfNumbers[i] + arrayOfNumbers[i - 1];
                arrayOfNumbers[i + 1] = total;
            }
        }
    }
}
