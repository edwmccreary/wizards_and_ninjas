using System;

namespace wizards_and_ninjas
{
    class Samurai : Human
    {
        private int max_health = 200;
        public Samurai(string name) : base (name)
        {
            health = max_health;
        }

        public override int Attack(Human target)
        {
            int target_health = base.Attack(target);
            Console.WriteLine($"{target.Name} has {target.Health} health left.");
            if(target_health < 50){
                Console.WriteLine($"{Name}'s blade sliced {target.Name} in half! {target.Name}'s lifeless body fell to the floor in pieces.");
                target.Set_Health(0);
            }
            return target.Health;
        }

        public void Meditate(){
            Console.WriteLine($"{Name} has gone into a deep meditation. {Name} regained full health");
            Set_Health(max_health);
        }
    }
}