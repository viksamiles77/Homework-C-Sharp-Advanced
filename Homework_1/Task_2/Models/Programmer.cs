namespace Models
{
    public class Programmer : Employee
    {
        public double Salary { get; set; }
        public double BonusWork { get; set; }
        public Programmer(string name, int employeeId, double salary, double bonusWork) : base(name, employeeId)
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
            Console.WriteLine($"ID: {EmployeeId} || Name: {Name} || Role: Programmer || Salary: {Salary}$ || Bonus: {BonusWork}$ || TOTAL: {CalculateSalary()}$");
        }
    }
}
