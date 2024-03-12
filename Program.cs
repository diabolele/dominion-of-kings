using System.ComponentModel;
using System.Numerics;

namespace dominion_of_kings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //The Dominion of Kings pag 57 

            Console.WriteLine("The Dominion of Kings");
            // estate is 1 point , duchy is 3 point province is 6 point
            //ask every user ho many of the possidement they have
            Console.WriteLine("How many estate you have?");
           
            
            int estate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many duchy you have?");
            int duchy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many province you have?");
            int province = Convert.ToInt32(Console.ReadLine());
            int total = estate * 1 + duchy * 3 + province * 6;
            Console.WriteLine(" your Total point is " + total);
        }
    }
}
