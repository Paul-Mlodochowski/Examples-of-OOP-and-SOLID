using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Bad
{
    public class Soldier : ISoldier {


        public int Id { get; }

        public string Name { get; }

        public string Nationality { get; }

        public int Age { get; set; }

        public Soldier(int id, string Name, string Nationality, int age) {
            Id = id;
            this.Name = Name;
            this.Nationality = Nationality;
            Age = age;
        }
        public void FireAtTarget() {
            throw new NotImplementedException();
        }

        public void gearUp() {
            Console.WriteLine("Gearing UP! as soldier");
        }


        public void heal(ISoldier soldier) {
            throw new NotImplementedException();
        }

        public void shoot() {
            Console.WriteLine("Pew Pow");
        }
    }
}
