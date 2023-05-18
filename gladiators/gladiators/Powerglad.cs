using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gladiators
{
    internal class Powerglad : Gladiator
    {
        string[] name_array = new string[] { "Алукард", "Фелиций", "Габриэль", "Гленн", "Гилберт", "Сесилия", "Фрио", "Эверин", "Рубейн", "Джанет", "Элеонора", "Иоган", "Кайлос" };
        public Powerglad()
        {
            hp = 180;
            str = 80;
            name = name_array[Dice.Next(0, 13)];
        }
        new public string Info()
        {
            return $"элитного гладиатора имя {name} сила {str} здоровье {hp}";
        }
        public override void Hit1(Gladiator target)
        {
            Info();
            Console.WriteLine("делает свой ход");
            target.TakeDamage1(str);
            Console.WriteLine();
        }
    }
}
