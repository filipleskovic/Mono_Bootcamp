using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Driver
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Driver(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }   
    }
}
