using System;

namespace OO_cookies_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John", "Smith", "01/01/1990", 170);
            Person josh = new Person("Josh", "Smith", "10/10/2010", 200);

            john.Firstname = "John";
            john.Surname = "Smith";
            john.GetFullName();
            
            john.Height = 170;
            josh.Height = 200;
        }
    }
}
