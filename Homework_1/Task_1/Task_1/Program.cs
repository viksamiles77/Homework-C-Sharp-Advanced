using Models;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDocument document = new MyDocument("Programming is like solving a puzzle where every line of code adds a piece, and debugging is finding that one missing piece to make it all work seamlessly.");

            WebPage webPage = new WebPage("In programming, creativity meets logic to craft digital solutions.");

            Console.WriteLine(document.Search("puzzle"));
            Console.WriteLine(webPage.Search("logic"));





        }
    }
}
