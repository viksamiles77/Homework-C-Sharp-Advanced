using Models;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            // Filter all cars that have origin from Europe and print them in console.

            var euCars = CarsData.Cars.Where(x => x.Origin == "Europe");
            foreach (var car in euCars)
            {
                Console.WriteLine($"Model: {car.Model}, Origin: {car.Origin}");
            }

            Console.WriteLine("=========================");
            // Filter all cars that have more than 6 Cylinders not including 6,
            // after that Filter all cars that have exactly 4 Cylinders and have
            // HorsePower more than 110.0.Join them in one result and print them in
            // console.

            var filteredCars = CarsData.Cars
                .Where(x => x.Cylinders > 6 && x.Cylinders != 6)
                .Union(CarsData.Cars.Where(x => x.Cylinders == 4 && x.HorsePower > 110.0));
            foreach (var car in filteredCars)
            {
                Console.WriteLine($"Model: {car.Model}, Cylinders: {car.Cylinders}, HorsePower: {car.HorsePower}");
            }
            
            Console.WriteLine("=========================");
            // Count all cars based on their Origin and print the result in console.
            // Example outpur "US 10 models\n Eu 15 Models";

            var carCountByOrigin = CarsData.Cars
                .GroupBy(x => x.Origin)
                .Select(x => $"{x.Key} {x.Count()} models.");
            foreach (var count in carCountByOrigin)
            {
                Console.WriteLine(count);
            }
            Console.WriteLine("=========================");
            //Filter all cars that have more then 200 HorsePower and Find out how much
            //is the lowest, highes and average Miles per galon and print them in console;

            var fastCars = CarsData.Cars
                .Where(x => x.HorsePower > 200);
            var highestMpg = fastCars.Max(x => x.MilesPerGalon);
            var averageMpg = fastCars.Average(x => x.MilesPerGalon);
            var lowestMpg = fastCars.Min(x =>  x.MilesPerGalon);
            Console.WriteLine($"Highest MPG: {highestMpg}, Average MPG: {averageMpg}, Lowest MPG: {lowestMpg}.");
            
            Console.WriteLine("=========================");
            // Find the top 3 fastest accelerating cars:
            // Order cars by their AccelerationTime in ascending order.
            // Take the top 3 cars from the ordered list.
            // Print the model of each of these top 3 cars.

            var fastest3Cars = CarsData.Cars
                .OrderBy(x => x.AccelerationTime).Take(3);
            foreach (var car in fastest3Cars)
            {
                Console.WriteLine($"Model: {car.Model}, Acceleration Time: {car.AccelerationTime}");
            }
            
            Console.WriteLine("=========================");
            // Calculate the total weight of cars with more than 6 cylinders:
            // Filter cars that have more than 6 cylinders. Calculate the total weight of these cars.
            // Print the total weight.

            var totalWeight = CarsData.Cars
                .Where(x => x.Cylinders > 6).Sum(x => x.Weight);
            Console.WriteLine($"Total weight of cars with more than 6 cylinders: {totalWeight}kg");
            
            Console.WriteLine("=========================");
            // Find the average MilesPerGalon for cars with even number of cylinders:
            // Filter cars that have an even number of cylinders.
            // Calculate the average MilesPerGalon for these cars.
            // Print the average MilesPerGalon.

            var averageMpgEvenCyl = CarsData.Cars
                .Where(x => x.Cylinders % 2 == 0)
                .Average(x => x.MilesPerGalon);
            Console.WriteLine($"Average MPG of cars with even number of cylinders: {averageMpgEvenCyl}");
        }
    }
}
