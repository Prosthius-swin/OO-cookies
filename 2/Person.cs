using System;

namespace OO_cookies_2
{
    class Person
    {
        private string firstname;
        private string surname;
        private string dob;
        private int height;

        public Person(string pFirstname, string pSurname, string pDob, int pHeight)
        {
            firstname = pFirstname;
            surname = pSurname;
            dob = pDob;
            height = pHeight;
        }

        public string Firstname { get; set; }
        public string Surname { get; set; }

        public void GetFullName()
        {
            Console.WriteLine($"{Firstname} {Surname}");
        }

        public int Height { get; set; }

        public void HeightDifference(john
        .height, Person other)
        {
            int answer = person - other;
        }
    }
}