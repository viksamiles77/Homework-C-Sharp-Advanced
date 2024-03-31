using System;

namespace Models
{
    public static class UserDatabase
    {
        public static List<User> Users { get; set; } = new List<User>();

        static UserDatabase()
        {
            Users.Add(new User(1, "Viktor", 19));
            Users.Add(new User(2, "Martin", 25));
            Users.Add(new User(3, "Nikola", 22));
            Users.Add(new User(4, "Dragan", 39));
            Users.Add(new User(5, "Slave", 44));
            Users.Add(new User(8, "Stefan", 21));
            Users.Add(new User(6, "Aleksandar", 28));
            Users.Add(new User(7, "Luka", 23));
        }

        public static List<User> SearchById(int id)
        {
            return Users.Where(u => u.Id == id).ToList();
        }

        public static List <User> SearchByName(string name)
        {
            return Users.Where(u => u.Name == name).ToList();
        }

        public static List<User> SearchByAge(int age)
        {
            return Users.Where(u => u.Age == age).ToList();
        }

        public static void PrintUsers(List<User> users, Func<User, bool> predicate)
        {
            foreach (var user in users.Where(predicate))
            {
                Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
            }
        }
    }
}
