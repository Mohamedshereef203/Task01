namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            Console.WriteLine(" Task01 Estimate for carpet cleaning service\n\n"); 
            Console.WriteLine("=======================================\n");
            Console.Write("Enter Number of small Carpets : ");
            int smallCarpet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number of large Carpets : ");
            int largeCarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small carpet : $25");
            Console.WriteLine("Price per large carpet : $35");
            double cost = (smallCarpet * 25) + (largeCarpet * 35);
            double tax =  (cost * 0.06);
            double total = cost + tax;
            Console.WriteLine("=======================================");
            Console.WriteLine($"cost : {cost:C}");
            Console.WriteLine($"Tax (%6) : {tax:C}"); 
            Console.WriteLine("=======================================");
            Console.WriteLine($"Total estimate : {total:C}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
