using System;
using System.Text.RegularExpressions;
using Test.exercise_1;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            ///Exercise 1:
            var people = new People("Mary",  true, 25);
            if (people.Gender.Equals(true))
            {
                Console.WriteLine("Person details: " + "Name = {0}, Gender = Male, Age= {2}", people.Name, people.Gender, people.Age);
            }
            people.Age += 10;
            Console.WriteLine("Person details(apter incrementing age): " + "Name = {0}, Gender = Male, Age= {2}", people.Name, people.Gender, people.Age);
            
            ///Exercise 2:
            Console.WriteLine("Enter a String: ");
            var _string = Console.ReadLine();
            Console.WriteLine("Enter a word to search: ");
            var _word = Console.ReadLine();
            var _found = Regex.Matches(_string,_word).Count;
            Console.WriteLine("Word found {0} times in the string", _found);
        }
    }
}