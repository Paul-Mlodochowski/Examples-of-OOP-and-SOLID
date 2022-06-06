using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Good
{
    public class CommunicateToCallAlltylery : ITypeCommunicator
    {
        public void Communicate(ISoldier soldier1, ISoldier soldier2) {
            Console.WriteLine($"Soldier {soldier1.GetPersonalData().Name}, I need alltylery to positon xyz");
            if (soldier2 is IAltyleryOperator) {
                var soldier_operator = soldier2 as AltyleryOperator;
                soldier_operator.FireAtTarget();
               }
            else
                Console.WriteLine("Wrong Person");
        }
    }
}
