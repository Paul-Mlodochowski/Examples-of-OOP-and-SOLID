using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Chrysaora : IJellyFish
    {
        public int NumberOfTentacles { get;}
        public int Size { get; set; }

        private SEX Sex { get; set; }

        public string Nutrition => "Małe bakterioe";

        public string Name => "Chrysaora";

        public Chrysaora(int numberOfIentacles, int size, SEX sex) {
            NumberOfTentacles = numberOfIentacles;
            Size = size;
            Sex = sex;
        }
        public Chrysaora(int numberOfIentacles, int size) {
            NumberOfTentacles = numberOfIentacles;
            Size = size;
            Sex = SEX.MALE;
        }
        public void ChangeSexLVLUp() { // Ta meduza wg wikipedi zmienia płec fazowo
            var SexNumber = (int) Sex;
            switch (SexNumber) {
                case 0:
                    Sex = SEX.NONE;
                    break;
                case 1:
                    Sex = SEX.FEMALE;
                    break;
                case 2:
                    Sex = SEX.MALE;
                    break;
                default:
                    Console.Error.WriteLine("Nie ma takiej płci");
                    break;
            }
        }

        public SEX GetSex() {
            return Sex;
        }
        public void GrowUp() {
            Size+=10;
            Console.WriteLine("Growing up");
        }
        public string GetDescription() {
            return "Name: " + Name + "\n" +
                   "Sex: " + Sex + "\n" +
                   "Number of tentacles: " + NumberOfTentacles + "\n"+
                   "Size: " + Size;
        }
    }
}
