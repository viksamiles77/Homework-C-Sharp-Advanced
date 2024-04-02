namespace Task_1
{
    public class PrintInConsole
    {
        public void Print<T>(T item)
        {
            Console.WriteLine(item);
        }

        public void PrintCollection<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
