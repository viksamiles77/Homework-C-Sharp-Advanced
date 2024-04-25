namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = "Exercise";
            string filePath = @$"{folderPath}\calculations.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    string result = Calculate(num1, num2);

                    Console.WriteLine($"Result: {result}");

                    string timeStamp = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                    file.WriteLine($"{timeStamp} --> {result}");
                }
            }
        }

        static string Calculate(double num1, double num2)
        {
            double result = num1 + num2;
            return $"{num1} + {num2} = {result}";
        }
    }
}
