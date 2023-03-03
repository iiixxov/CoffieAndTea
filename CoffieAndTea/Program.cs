// See https://aka.ms/new-console-template for more information

namespace i02_1_TemplateMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TeaWithHook teaHook = new TeaWithHook(); 
            CoffieWithHook coffeeHook = new CoffieWithHook();

            Console.WriteLine("\nMaking tea…"); 
            teaHook.prepareRecipe();

            Console.WriteLine("\nMaking coffee…"); 
            coffeeHook.prepareRecipe();
        }
    }
}

