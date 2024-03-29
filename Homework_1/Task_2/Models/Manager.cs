namespace Models
{
    public class Manager : Employee
    {
        public double Salary { get; set; }
        public double BonusWork { get; set; }
        public Manager(string name, int employeeId, double salary, double bonusWork) : base (name, employeeId)
        {
            Salary = salary;
            BonusWork = bonusWork;
        }
        public override double CalculateSalary()
        {
            return Salary + BonusWork;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {EmployeeId} || Name: {Name} || Role: Manager || Salary: {Salary}$ || Bonus: {BonusWork}$ || TOTAL: {CalculateSalary()}$");
        }
    }
}
