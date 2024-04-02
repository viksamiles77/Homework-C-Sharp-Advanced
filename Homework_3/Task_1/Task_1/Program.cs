namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInConsole printer = new PrintInConsole();
            printer.Print("Hello, World!");

            List<string> strings = new List<string> { "Good Morning!", "Good Evening!", "Good Night!" };
            printer.PrintCollection(strings);

            List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
            printer.PrintCollection(ints);
        }
    }
}
