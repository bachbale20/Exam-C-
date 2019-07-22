using System.Security.Cryptography;

namespace Test.exercise_1
{
    public class People
    {
        public People(string name, bool gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }
        public People()
        {
        }

        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
    }
}
