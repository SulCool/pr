using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gladiators
{
    internal class Lion : Gladiator
    {
        string[] name_array = new string[] { "Райан", "Вольтрон", "Лев храброе сердце", "Бонифаций", "Принц джон", "Алекс", "Львёнок", "Аслан", "Кайон", "Симба", "Шрам", "Шампават", "Цавр" };
        public Lion()
        {
            hp = 140;
            str = 60;
            name = name_array[Dice.Next(0, 13)];
        }
        new public string Info()
        {
            return $"льва имя [{name}] сила [{str}] здоровье [{hp}]";
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
