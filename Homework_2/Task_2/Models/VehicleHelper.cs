namespace Models
{
    public static class VehicleHelper
    {
        public static void Drive(this Car car)
        {
            Console.WriteLine("Driving");
        }

        public static void Wheelie(this MotorBike motorBike)
        {
            Console.WriteLine("Driving on one wheel.");
        }

        public static void Sail(this Boat boat)
        {
            Console.WriteLine("Sailing");
        }

        public static void Fly(this Airplane airplane)
        {
            Console.WriteLine("Flying");
        }
    }
}
