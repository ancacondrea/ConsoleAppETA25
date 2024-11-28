namespace ConsoleAppETA25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            /* int number;
             number = 10;
             bool AiFostLaVot=true;
             const double Pi = 3.14159;

             int i = default;
             float f = default;
             decimal d = default;
             bool b = default;
             char c = default;
             string str = default; 
             Guid guid = default;

             Console.WriteLine(number);
             Console.WriteLine(AiFostLaVot);
             Console.WriteLine(Pi);
             Console.WriteLine();
             Console.WriteLine(i);
             Console.WriteLine(f);
             Console.WriteLine(d);
             Console.WriteLine(b);
             Console.WriteLine(c);
             Console.WriteLine(str);
             Console.WriteLine(guid);*/

            Console.WriteLine("Please input First name?");
            string firstName= Console.ReadLine();

            Console.WriteLine("Please input last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please input your age?");
            int age= Convert.ToInt16(Console.ReadLine());
            var coputedAged = age + 20;

            Console.WriteLine("Gender?");
            string gender = Console.ReadLine();


            Console.WriteLine($"Your details are :\n"+
                $" -Nume {firstName}\n"+
                $" -Last {lastName}\n" +
                $" -Gender {gender}\n" +
                $" -you will be  {coputedAged} in 20 years" );

            Console.ReadKey();
        }
    }
}
