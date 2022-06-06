using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Good
{
    public class Soldier : ISoldier
    {
        private PersonalData solierData;

        public Soldier(PersonalData solierData) {
            this.solierData = solierData;
        }

        public void gearUp() {
            Console.WriteLine("Gearing UP! as soldier");
        }

        public PersonalData GetPersonalData() {
            return solierData;
        }

        public void shoot() {
            Console.WriteLine("Pew Pow");
        }
    }
}
