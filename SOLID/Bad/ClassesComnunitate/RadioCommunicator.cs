using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Bad
{
    public class RadioCommunicator
    {    

        public void CommunucateToSoldier(ISoldier soldier1, ISoldier soldier2) {
            Console.WriteLine($"Here {soldier1.Name}, Soldier {soldier2.Name} I need your positon, copy");
        }
        public void CommunucateToAltylery(ISoldier soldier1, AltyleryOperator soldier2) {
            Console.WriteLine($"Soldier {soldier1.Name}, I need alltylery to positon xyz");
            soldier2.FireAtTarget();
            
        }
    }
}
