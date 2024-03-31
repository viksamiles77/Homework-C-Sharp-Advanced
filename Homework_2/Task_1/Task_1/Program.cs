using Models;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What do you want to search by?");
            Console.WriteLine("1) ID\n2) Name\n3) Age");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Write("Enter the ID: ");
                    var idInput = int.Parse(Console.ReadLine());
                    var userById = UserDatabase.SearchById(idInput);
                    UserDatabase.PrintUsers(userById, user => user.Id == idInput);
                    
                    break;
                case "2":
                    Console.Write("Enter the name: ");
                    var nameInput = Console.ReadLine();
                    var userByName = UserDatabase.SearchByName(nameInput);
                    UserDatabase.PrintUsers(userByName, user => user.Name == nameInput);
                    break;
                case "3":
                    Console.Write("Enter the age: ");
                    var ageInput = int.Parse(Console.ReadLine());
                    var userByAge = UserDatabase.SearchByAge(ageInput);
                    UserDatabase.PrintUsers(userByAge, user => user.Age == ageInput);
                    break;
                default:
                    Console.WriteLine("Please enter 1, 2 or 3!");
                    break;
            }

        }
    }
}
