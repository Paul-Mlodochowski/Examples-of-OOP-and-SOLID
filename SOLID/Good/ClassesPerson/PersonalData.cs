namespace SOLID.Good
{
    public class PersonalData {
        public int Id { get; }
        public string Name { get; }
        public string Nationality {get; }
        public int Age { get; set; }

        public PersonalData() {

        }
        public PersonalData(int Id, string Name, string Nationality, int Age) {
            this.Id = Id;
            this.Name = Name;
            this.Nationality = Nationality;
            this.Age = Age;

        }

    }
}