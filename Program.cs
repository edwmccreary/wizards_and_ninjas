using System;

namespace wizards_and_ninjas
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Harry = new Wizard("Harry Potter");
            Human Steve = new Human("Steve");
            Samurai Shiro = new Samurai("Shiro");
            Ninja Naruto = new Ninja("Naruto");
            Steve.Attack(Shiro);
            Shiro.Meditate();
            Shiro.Attack(Harry);
            Naruto.Steal(Shiro);
            Naruto.Attack(Shiro);
        }
    }
}
