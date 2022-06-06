using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IAnimal
    {
         abstract string Nutrition { get; }
         abstract string Name { get; }
         abstract string GetDescription();

    }
}
