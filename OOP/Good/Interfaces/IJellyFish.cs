namespace OOP
{
    public interface IJellyFish : IAnimal
    {
        abstract int NumberOfTentacles { get;}
        abstract int Size { get; set; }
        abstract SEX GetSex();
        abstract void GrowUp();
    }
}
