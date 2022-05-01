using System;

namespace OO_cookies_2
{
    class Subject
    {
        public string subjectName { get; set; }
        public int yearOfDelivery { get; set; }

        public Subject(string pSubjectName, int pYearOfDelivery)
        {
            this.subjectName = pSubjectName;
            yearOfDelivery = pYearOfDelivery;
        }
    }
}