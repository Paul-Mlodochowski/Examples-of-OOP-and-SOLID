using OOP;


// ----  GOOD ----

Human Czlowiek = new Human(SEX.MALE, "Bartek");
Chrysaora chrysaora = new Chrysaora(24,10);
chrysaora.GrowUp();
chrysaora.ChangeSexLVLUp();
IAnimal[] animalArray = new IAnimal[2];
animalArray[0] = chrysaora;
animalArray[1] = Czlowiek;

foreach (var animal in animalArray) {
    Console.WriteLine(animal.GetDescription());
    Console.WriteLine("\n");
}
Console.WriteLine();

// ----  BAD ----


string imie = "Bartek";
string sex = "MALE";
string hair = "Włosy";

string jellyFish_Name = "Chrysaora";
int NumberOfTentacles = 24;
int Jelly_size = 10;
string JellySex = "MALE";

Jelly_size += 10;
if(JellySex.Equals("MALE"))
JellySex = "NONE";


Console.WriteLine("Name: " + imie + "\nSex: " + sex + "\nType of Hair: " + hair);
Console.WriteLine("Name: " + jellyFish_Name + "\n" +
                   "Sex: " + JellySex + "\n" +
                   "Number of tentacles: " + NumberOfTentacles + "\n"+
                   "Size: " + Jelly_size);