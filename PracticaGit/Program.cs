using System; 

namespace Primer
{   
    internal class program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;
            //Pedimos el valor de a
            Console.WriteLine("Inserte un valor para a:");
            a = Int32.Parse(Console.ReadLine());
            //pedimos el valor de b
            Console.WriteLine("Inserte un valor para b:");
            b = Int32.Parse(Console.ReadLine());
            //Imprimemos y llamamos el metodo con el cual sumamos las variables
            Console.WriteLine($"Multiplicar {a} x {b} es igual a {AddNumbers(a, b)} ");
        }
        
        //Metodo para sumar las variables 
        public static int AddNumbers(int a, int b)
        {

            return a*b;
        }
    }
}