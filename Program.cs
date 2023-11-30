using System.Threading.Channels;

namespace LabConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            int? input = null;
            double radian;

            do
            {
                Console.Write("Input the degress of the angle as a whole number: ");
                if (!int.TryParse(Console.ReadLine(), out int intermediateStep))
                {
                    Console.WriteLine("you must input an angle, and with no decimals");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                else
                    input = intermediateStep;
            } while (input == null);

            radian = RadianCalc(input);
            Console.WriteLine($"An angle of {input} Degrees results in a radian of {radian}");
            Console.ReadKey(true);
        }
        // The result of the method, is rounded to the first ten decimals
        public static double RadianCalc(int? input)
        {
            return Math.Round((int)input * Math.PI / 180,10);
        }
    }
}
