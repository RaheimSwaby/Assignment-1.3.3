namespace Assignment_1._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        { 


            int[] numbers = { 2, 5, 7 };

            Array.Sort(numbers);
            Array.Reverse(numbers);

            Console.WriteLine("\nNumbers stored in reverse order:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nNumbers stored in the original order:");
            Array.Sort(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

           
        }
    }
}
        
    

