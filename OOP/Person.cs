
namespace OOP
{

    public class Person
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }

        public Person(string name, int yearOfBirth)
        {
            Name = name;
            YearOfBirth = yearOfBirth;
        }

        public string Description => $"{Name} was born in {YearOfBirth}";
    }
}
