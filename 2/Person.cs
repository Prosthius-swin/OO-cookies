using System;
using System.Collections.Generic;

namespace OO_cookies_2
{
    class Person
    {
        Random rnd = new Random();
        private string firstname { get; set; }
        private string surname { get; set; }
        private string dob { get; set; }
        private int height { get; set; }
        private int ID { get; set; }
        private List<Subject> subjectsList = new List<Subject>();

        public Person(string pFirstname, string pSurname, string pDob, int pHeight)
        {
            firstname = pFirstname;
            surname = pSurname;
            dob = pDob;
            height = pHeight;
            ID = rnd.Next(1001, 9999);
        }

        public void GetFullName()
        {
            Console.WriteLine($"{firstname} {surname}");
        }

        public void GetHeightDifference(Person other)
        {
            int heightDifference = height - other.height;

            Console.WriteLine($"The height difference is {heightDifference}cm.");
        }

        public void AddSubject(Subject newSubject)
        {
            subjectsList.Add(newSubject);

            Console.WriteLine($"{firstname} {surname} is now enrolled in {newSubject.subjectName}.");
        }

        public List<Subject> ListSubjects() {
            return subjectsList;
        }
    }
}
