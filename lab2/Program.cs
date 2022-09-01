using ConsoleTables;
public class Program
{
    public static void Main(string[] args)
    {

        //1
        int num1, num2;
        Console.Write("Enter a number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter a second number: ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));

        //2
        Console.Write("Enter a number: ");
        int num3 = int.Parse(Console.ReadLine());
        int num4 = 0;
        while (num4 <= num3)
        {
            Console.WriteLine((num3 * num4));
            num4++;
        }

        //3
        /*ConsoleTable table = new ConsoleTable("Type", "Byte(s) of Memory", "Min", "Max");
        table.AddRow( )*/

        //4
        bool input;
        do
        {
            Console.Write("Please enter a number: ");
            int num5 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num6 = int.Parse((Console.ReadLine()));
            Console.Write("Now enter the function you wish to use or type ESC to quit: ");
            string Function = Console.ReadLine();

            if (Function == "+")
            {
                Console.WriteLine(num5 + "+" + num6 + "=" + (num5 + num6));
            }

            if (Function == "-")
            {
                Console.WriteLine(num5 + "-" + num6 + "=" + (num5 - num6));
            }

            if (Function == "*")
            {
                Console.WriteLine(num5 + "*" + num6 + "=" + (num5 * num6));
            }

            if (Function == "/")
            {
                Console.WriteLine(num5 + "/" + num6 + "=" + (num5 / num6));
            }
            if (Function == "esc")
            {
                
            }
        }
        while (input = true);
    }
}

