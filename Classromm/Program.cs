

using Classromm.Entities;

using System.Globalization;



namespace Classromm
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new();

            Console.WriteLine();

            Console.WriteLine("  =====================================");
            Console.WriteLine("               app employee");
            Console.WriteLine("  =====================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             Enter the number ");
            Console.Write("                 of the employess: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"        Employee #{i} data: ");
                Console.Write("             Outsourced (y/n)?: ");
                string ch = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine(".........................................");
                Console.Write("         Name: ");
                string name = Console.ReadLine();
                Console.Write("         Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("             Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch =="y")
                {
                    Console.Write("         Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();

            Console.WriteLine("          ***********************************");
            Console.WriteLine("                       PAYMENTS");
            Console.WriteLine();
            
            foreach(Employee emp in list)
            {
                Console.WriteLine($"        {emp.Name} - $ {emp.Payment().ToString("f2", CultureInfo.InstalledUICulture)}");
            }

        }
    }
}