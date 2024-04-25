namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var folderPath = "Files";
            var filePath = $@"{folderPath}\names.txt";
            
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                FileStream file = File.Create(filePath);
                file.Close();
            }

            Console.WriteLine("Names written in the file:");
            string[] namesFromFile = File.ReadAllLines(filePath);
            foreach (var name in namesFromFile)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nEnter some names (type 'x' when finished):");
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                string inputName;
                while ((inputName = Console.ReadLine()) != "x")
                {
                    writer.WriteLine(inputName);
                }
            }

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                string letterFilePath = $@"{folderPath}\namesStartingWith_{letter}.txt";
                var filteredNames = namesFromFile.Where(name => name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase)).ToArray();

                if (filteredNames.Length > 0 )
                {
                    using(StreamWriter writer = new StreamWriter(letterFilePath))
                    {
                        foreach (var name in filteredNames)
                        {
                            writer.WriteLine(name);
                        }
                    }
                    Console.WriteLine($"File created with names starting with {letter}");
                }
            }
        }
    }
}
