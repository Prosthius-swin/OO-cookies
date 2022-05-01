using System;

namespace OO_cookies_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("person1", "surname1", "01/01/1990", 170);
            Person person2 = new Person("person2", "surname2", "10/10/2010", 200);
            Person person3 = new Person("person3", "surname3", "23/07/1934", 150);

            Subject Maths = new Subject("Maths", 2022);
            Subject PE = new Subject("Physical Education", 2022);
            Subject Eng = new Subject("English", 2022);
            Subject RE = new Subject("Religion", 2022);
            Subject Sci = new Subject("Science", 2022);

            person1.GetFullName();
            person2.GetFullName();
            person3.GetFullName();

            Console.WriteLine();

            person1.GetHeightDifference(person2);
            person2.GetHeightDifference(person3);
            person3.GetHeightDifference(person1);

            Console.WriteLine();

            person1.AddSubject(Maths);
            person1.AddSubject(PE);
            person1.AddSubject(Eng);
            person1.AddSubject(RE);
            person1.AddSubject(Sci);

            Console.WriteLine();

            foreach(Subject i in person1.ListSubjects()) 
            {
                Console.Write($"{i.subjectName} " );
            }
        }
    }
}
