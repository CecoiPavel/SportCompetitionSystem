using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCompetitionSystem.Domain.Abstractions.Interfaces
{
    internal interface ILeaderbord
    {
        void Leaderbord(List<SeniorSportsMan> seniorslist);
    }
}
