using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Good
{
    public interface ISoldier
    {
        PersonalData GetPersonalData();
        void shoot();
        void gearUp();

    }
    public interface IMedic
    {
        void heal(ISoldier soldier);
    }
    public interface IAltyleryOperator
    {
        void FireAtTarget();
    }
}
