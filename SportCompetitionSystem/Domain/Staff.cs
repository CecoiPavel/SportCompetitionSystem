using SportCompetitionSystem.Domain.Abstractions.Base;
using SportCompetitionSystem.Domain.Abstractions.Interfaces;

namespace SportCompetitionSystem.Domain
{
    internal class Staff : BaseUser, IRetirement, ISalary
    {
        public string Role { get; set; }


        private int SalaryBonus = 1000;
        public Staff()
        {

        }
        public Staff(string name, int age, string country, string sport, string role) : base(name, age, country, sport)
        {
            Role = role;
        }

        public int RetirementStatus()
        {
            if (Age >= 50)
            {

                return Age + 16;
            }
            else
            {
                return Age + 24;
            }
        }

        public int Salary()
        {
            return Age * SalaryBonus;
        }

        public void AddStaff(List<Staff> stafflist)
        {
            try
            {
                Console.WriteLine("  Insert Staff member details below:");
                Staff staff = new Staff();
                Console.Write("Name:");
                staff.Name = Console.ReadLine();
                Console.Write("Age: ");
                staff.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Country: ");
                staff.Country = Console.ReadLine();
                Console.Write("Sport: ");
                staff.Sport = Console.ReadLine();
                Console.Write("Staff role: ");
                staff.Role = Console.ReadLine();
                stafflist.Add(staff);
                Console.WriteLine("\u001b[32m Staff member was added! \u001b[0m");
            }
            catch (Exception)
            {
                Console.WriteLine("\u001b[31mInvalid characters!\u001b[37m");
            }
            Console.ReadKey();
        }
        public void StaffDisplay()
        {
            DisplayDetails();

            Console.Write($" Role: {Role}");
            Console.Write($" Retirement age: {RetirementStatus()}");
            Console.Write($" Salary: \u001b[32m {Salary()}$ \u001b[0m");
        }
    }
