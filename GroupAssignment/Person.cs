using System;
using System.Collections.Generic;
using System.Text;

namespace GroupAssignment
{
    class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string EmailAdress { get; set; }
        public string HomeAdress { get; set; }
        public string HomePhoneNumber { get; set; }
        public string PrivatePhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
