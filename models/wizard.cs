using System;

namespace wizards_and_ninjas
{

    class Wizard : Human
    {
        public Wizard(string name) : base (name)
        {
            health = 50;
            Intelligence = 25;
        }

        public override int Attack(Human target)
        {
            int damage = 5*Intelligence;
            health += damage;
            target.Change_Health(-1*damage);
            
            Console.WriteLine($"{target.Name} lost {damage} health. {Name} regained {damage} health.");
            if(target.Health == 0){
                Console.WriteLine($"{target.Name} is dead.");
            }
            return target.Health;
        }

        public void Heal(Human target){
            int amt = 10*Intelligence;
            Console.WriteLine($"{Name} cast a healing spell on {target.Name}, {target.Name} regained {amt} health.");
            target.Change_Health(amt);

        }
    }

}