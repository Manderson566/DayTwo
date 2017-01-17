using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwo
{
    //Class Definition
    class Dog
    {
       private int Age;
        public string name;
        public List<Dog> friends = new List<Dog>();

        public Dog(string _name)
        {
            Age = 0;
            name = _name;
        }
        public void AddFriend(Dog friend)
        {
            if (friends.Contains(friend))
                {
                Console.WriteLine($"Dog {friend} is already our friend");

            }
            friends.Add(friend);
        }
        public void HappyBirthday()
        {
            Age++;
        }
        public void RemoveFridend(Dog friend)
        {
            friends.Remove(friend);
        }
        public int GetAge()
        {
            return Age;
        }
        public int GetAgeDogYears()
        {
            return Age * 7;
        }
        public void GetFirend()
        {

        }
        public void GetDogFirends()
        {
            friends.Add(friend);
            Console.WriteLine(string.Join(",", friends));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi");
            var peanut = new Dog("Peanut");
            peanut.HappyBirthday();
            peanut.HappyBirthday();
            peanut.HappyBirthday();
            var age =peanut.GetAge();
            var ageDogYears = peanut.GetAgeDogYears();
            Console.WriteLine(age);
            Console.WriteLine(ageDogYears);
            Console.WriteLine(peanut.name);
     
            Console.ReadLine();
           
            
            {
                
            }
        }
    }
}
