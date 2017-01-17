using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwo
{
    enum State
    {
        Alive, Dead, Graveyard
    }

    class Warrior
    {
        private int hp;
        public string name;
        public State currentState = State.Alive;

        public Warrior(string _name)
        {
            name = _name;
            hp = 10;
        }
        public void LowerHP()
        {
            if (hp < 1)
            {
                Console.WriteLine($"{name} Player is dead");
            }
            else
            hp -= 3;
        }

        public void Attack(Warrior enemy)
        {
            enemy.LowerHP();
        }
        public override string ToString()
        {
            return ($"{name} = {hp}");
        }
    }
}
