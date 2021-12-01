using System;

namespace wizards_and_ninjas
{
    class Ninja : Human
    {
        public Ninja(string name) : base (name)
        {
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            Random rand = new Random();
            int damage = 5*Dexterity;
            if(rand.Next(6)==0){
                damage += 10;
            }
            target.Change_Health(-1*damage);
            
            Console.WriteLine($"{target.Name} lost {damage} health.");
            if(target.Health == 0){
                Console.WriteLine($"{target.Name} is dead.");
            }
            return target.Health;
        }

        public void Steal(Human target){
            Console.WriteLine($"{Name} steals 5 health from {target.Name} and gains 5 health.");
            target.Change_Health(-5);
            Change_Health(5);
        }
    }

}