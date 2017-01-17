using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
   


    class Program
    {
        static void Main(string[] args)
        {
            //DogStuff();
            Warrior gromm = new Warrior("Grommash");
            Warrior soap = new Warrior("Soap McTavish");

            soap.Attack(gromm);
            Console.WriteLine(soap);
            Console.WriteLine(gromm);
            soap.Attack(gromm);
            gromm.Attack(soap);
            soap.Attack(gromm);
            soap.Attack(gromm);
            Console.WriteLine(soap);
            Console.WriteLine(gromm);

        }

        private static void DogStuff()
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

            var moo = new Dog("Moo");
            var spaghetti = new Dog("Spaghetti");
            spaghetti.HappyBirthday();
            var rex = new Dog("Rex");

            Console.WriteLine(fred);
            fred.AddFriend(rex);
            fred.AddFriend(moo);
            fred.AddFriend(spaghetti);
            fred.AddFriend(spaghetti);
            fred.GetDogFriends();
            fred.RemoveFriend(spaghetti);
            fred.GetDogFriends();
        }
    }
}
