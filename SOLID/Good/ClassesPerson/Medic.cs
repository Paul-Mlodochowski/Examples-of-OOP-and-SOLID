using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Good
{
    public class Medic : ISoldier, IMedic
    {
        private PersonalData solierData;

        public Medic(PersonalData solierData) {
            this.solierData = solierData;
        }

        public void gearUp() {
            Console.WriteLine("Gearing UP! as medic");
        }

        public PersonalData GetPersonalData() {
            return solierData;
        }

        public void heal(ISoldier soldier) {
            Console.WriteLine($"Healing {soldier.GetPersonalData().Name}");
        }

        public void shoot() {
            Console.WriteLine("Pew Pow");
        }
    }
}
