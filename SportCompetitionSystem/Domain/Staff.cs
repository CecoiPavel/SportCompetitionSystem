﻿using SportCompetitionSystem.Domain.Abstractions.Base;

namespace SportCompetitionSystem.Domain
{
    internal class Staff : BaseUser
    {
        public string Role { get; set; }

        private  int SalaryBonus = 1000;
        public Staff()
        {

        }
        public Staff(
            string name,
            int age,
            string country,
            string sport,
            string role) : base(name, age, country, sport)
        {
            Role = role;
            Type = MemberType.Staff;
        }

        public override int RetirementStatus()
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
            return SalaryBonus * Age;
        }
        public void StaffDisplay()
        {
            //DisplayDetails();

            Console.Write($" Role: {Role}");
            Console.Write($" Retirement age: {RetirementStatus()}");
            //Console.Write($" Salary: \u001b[32m {Salary()}$ \u001b[0m");
        }
    }
}
