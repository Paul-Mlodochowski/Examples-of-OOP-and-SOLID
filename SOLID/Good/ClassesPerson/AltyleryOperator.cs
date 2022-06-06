using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Good
{
    public class AltyleryOperator : ISoldier, IAltyleryOperator
    {
        private PersonalData solierData;

        public AltyleryOperator(PersonalData solierData) {
            this.solierData = solierData;
        }

        public void FireAtTarget() {
            Console.WriteLine("Fire!!");
        }

        public void gearUp() {
            Console.WriteLine("Gearing UP as operator!");
        }

        public PersonalData GetPersonalData() {
            return solierData;
        }

        public void shoot() {
            Console.WriteLine("Pew Pow");
        }
    }
}
