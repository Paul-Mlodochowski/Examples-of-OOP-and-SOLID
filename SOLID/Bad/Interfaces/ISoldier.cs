using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Bad
{
    public interface ISoldier
    {
        public int Id { get; }
        public string Name { get; }
        public string Nationality { get; }
        public int Age { get; set; }

        void shoot();
        void gearUp();
        void heal(ISoldier soldier);
        void FireAtTarget();
    }
    
}
