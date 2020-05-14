using System;


namespace Lab8_2_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathem x = new Mathem(4);
            Console.WriteLine($"Our value is {x.Rez}\n");
            x.Notify += Message;
            x.Add(8);
            x.Minus(8);
            x.Multiply(5);
            x.Division(2);
            x.Multiply(0);

        }
        private static void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
