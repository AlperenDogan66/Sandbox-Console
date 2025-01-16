namespace Dino1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2;

            getal1 = 5;

            getal2 = getal1;

            void VerhoogParameters(int a)
        {
            a++;
            Console.WriteLine($"In methode {a}");
                
        }

            VerhoogParameters(getal1);
            Console.WriteLine();
        }

        
    }
}
