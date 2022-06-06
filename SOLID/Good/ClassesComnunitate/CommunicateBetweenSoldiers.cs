using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Good.Interfaces
{
    public class CommunicateBetweenSoldiers : ITypeCommunicator
    {
        public void Communicate(ISoldier s1, ISoldier s2) {
            Console.WriteLine($"Here {s1.GetPersonalData().Name}, Soldier {s2.GetPersonalData().Name} I need your positon, copy");
        }
    }
}
