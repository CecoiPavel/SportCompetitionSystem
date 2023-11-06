using SportCompetitionSystem.Domain.Abstractions.Base;

namespace SportCompetitionSystem.Domain
{
    internal class SeniorSportsMan : SportsMan
    {
        public SeniorSportsMan(
            string name,
            int age,
            string country,
            string sport,
            int place)
            : base(name, age, country, sport, place)
        {
            Type = MemberType.Senior;
        }

        public override int WonBonus()
        {
            if (Place == 1)
            {
                return 10000;
            }
            if (Place == 2)
            {
                return 7000;
            }
            if (Place == 3)
            {
                return 5000;
            }
            if (Place >= 4 && Place <= 10)
            {
                return 1000;
            }
            else
            {
                return 0;
            }
        }

        public override int RetirementStatus()
        {
            if (Age <= 24)
            {
                return Age + 16;
            }
            if (Age >= 24 && Age <= 30)
            {
                return Age + 10;
            }
            else
            {
                return Age + 5;
            }
        }
    }
}