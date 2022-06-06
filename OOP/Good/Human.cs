using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Human : IMammal
    {
        public bool HaveTail => false;

        public string Hair => "Włosy";

        public SEX Sex { get; }

        public string Nutrition => "Cudzożywne";

        public string Name { get; }

        public Human(SEX sex, string name) {
            Sex = sex;
            Name = name;
        }

        public string GetDescription() {
            return "Name: " + Name + "\n" +
                   "Sex: " + Sex + "\n" +
                   "Type of Hair: " + Hair;
        }

    }
}
