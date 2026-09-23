namespace Topic_4___User_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item, name;
            string topping;
            double price;
            double diameter;

            Console.Write("Enter your name:");
            name = Console.ReadLine();

            Console.Write("Enter your favourite pizza topping:");
            topping = Console.ReadLine();

            Console.WriteLine(name + "'s favourite pizza topping is " + topping);

            Console.ReadLine();

            //task 2
            Console.Write("enter name of item: ");
            item = Console.ReadLine();

            Console.Write("Enter the price of the item : ");
            double.TryParse(Console.ReadLine(), out price);

            Double total = price * 3;

            Console.WriteLine("The cost of buying three" + item + " is " + total.ToString("C"));

            Console.ReadLine();

            //Task 3
            Console.Write("enter the diameter of the circle: ");
            double.TryParse(Console.ReadLine(), out diameter);

            double radius = diameter / 2;

            Console.WriteLine("the radius is " + radius);





         
        }
    }
}
