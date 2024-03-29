using Models;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager("John Doe", 1, 5000, 1500);
            manager1.DisplayInfo();

            Programmer programmer1 = new Programmer("Johny Doe", 2, 3500, 2200); 
            programmer1.DisplayInfo();
        }
    }
}
