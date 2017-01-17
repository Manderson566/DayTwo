using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // NewMethod();
            Warrior grom = new Warrior("Grommesh");
            Warrior soap = new Warrior("Soap McTavish");

            soap.Attack(grom);
            Console.WriteLine(soap);
            Console.WriteLine(grom);
        }
        public void Attack (Warrior enemy)
        {

        }

        private static void NewMethod()
        {
            Console.WriteLine("hi");
            var peanut = new Dog("Peanut");
            peanut.HappyBirthday();
            peanut.HappyBirthday();
            peanut.HappyBirthday();
            var age = peanut.GetAge();
            var ageDogYears = peanut.GetAgeDogYears();
            Console.WriteLine(age);
            Console.WriteLine(ageDogYears);
            Console.WriteLine(peanut.name);
            Console.ReadLine();

            var casey = new Dog("Casey");
            var billy = new Dog("Billy");
            var fido = new Dog("Fido");

            var casey = new Dog("Casey");
            peanut.RemoveFridend(fido);
        }
    }
}