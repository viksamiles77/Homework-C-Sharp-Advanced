namespace Models
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        protected Employee(string name, int employeeId)
        {
            Name = name;
            EmployeeId = employeeId;
        }
        public abstract double CalculateSalary();
        public abstract void DisplayInfo();
    }
}
