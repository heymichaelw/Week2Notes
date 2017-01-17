using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    //class definition
    class Dog
    {
        int Age;
        public string name;

        public Dog(string _name)
        {
            Age = 0;
            name = _name;
        }

        public void HappyBirthday()
        {
            Age++;
        }

        public int GetAge()
        {
            return Age;
        }

        public int GetAgeDogYears()
        {
            return Age * 7;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var fred = new Dog("Fred");
            fred.HappyBirthday();
            fred.HappyBirthday();
            fred.HappyBirthday();
            var age = fred.GetAge();
            var agedogyears = fred.GetAgeDogYears();
            Console.WriteLine(age);
            Console.WriteLine(agedogyears);
            Console.WriteLine(fred.name);
        }
    }
}
