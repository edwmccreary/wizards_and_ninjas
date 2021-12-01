using System;

namespace wizards_and_ninjas
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;
        public int Health
        {
            get {return health;}
        }
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name,int str,int intel,int dex,int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }

        public void Change_Health(int change){
            health += change;
            if (health < 0){
                health = 0;
            }
        }

        public void Set_Health(int amt){
            health = amt;
        }

        public virtual int Attack(Human target)
        {
            int damage = 3*Strength;
            target.Change_Health(-1*damage);
            if(target.Health == 0){
                Console.WriteLine(target.Name + " is dead!");
            }
            else{
                Console.WriteLine(target.Name + " lost " + damage + " health");
            }
            return target.Health;
        }

    }
}