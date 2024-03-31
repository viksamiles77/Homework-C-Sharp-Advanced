namespace Models
{
    public abstract class Vehicle
    {
        public int WheelNumber { get; set; }

        public abstract string DisplayInfo();
    }
}
