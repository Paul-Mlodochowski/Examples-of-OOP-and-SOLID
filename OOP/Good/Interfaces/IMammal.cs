using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IMammal : IAnimal
    {
        abstract bool HaveTail { get; }
        abstract string Hair { get; }
        abstract SEX Sex { get; }

    }
}
