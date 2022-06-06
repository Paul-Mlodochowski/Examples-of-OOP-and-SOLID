using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Good.Interfaces
{
    public class CommunicateBetweenSoldiers : ITypeCommunicator
    {
        public void Communicate(ISoldier soldier1, ISoldier soldier2) {
            Console.WriteLine($"Here {soldier1.GetPersonalData().Name}, Soldier {soldier2.GetPersonalData().Name} I need your positon, copy");
        }
    }
}
