using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relativespeedcarculator
{
    class Program
    {
        public static int input = 0;
        public static double output = 0;
        public static int Knot = 0;
        public static double kph = 0;
        public static double range = 0;
        
        static void Main(string[] args)
        {
            
            string carculationfactor = "None";
            Console.WriteLine("Pls enter the (relative speed(Knot):range(Km)");
            carculationfactor = Console.ReadLine();
            string[] lines = carculationfactor.Split(':');
            Knot = Convert.ToInt32(lines[0]);
            kphconvertion(Knot);
            range = Convert.ToDouble(lines[1]);
            maincarrulation(kph, range);
            Console.WriteLine();
            Console.WriteLine(output + " seconds required to collision");
            Console.WriteLine();
            Console.WriteLine("Press any key to countinue ...");
            Console.ReadKey();
        }
        static void kphconvertion(double knot)
        {
            kph = (knot * 1.852)/3600;
            return;
        }
        static void maincarrulation(double speed ,double range)
        {
           output = Math.Round((output = range / speed), 2);
           return;
        }

    }
}
