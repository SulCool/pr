using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gladiators
{
    internal class Gob : Gladiator
    {
        string[] name_array = new string[] { "Залжес", "Милюгель", "Плюмналюк", "Вархабо", "Плюмзажинер", "Прозолин", "Милижах", "Лихзаступ", "Дилювикс", "Грубитяп", "Мисрали", "Миктобахс", "Мисворрикс" };

        public Gob()
        {
            hp = 80;
            str = 30;
            name = name_array[Dice.Next(0, 13)];
        }
        new public string Info()
        {
            return $"гоблина имя [{name}] здоровье [{hp}] сила [{str}]";
        }
        public override void Hit1(Gladiator target)
        {
            Info();
            target.TakeDamage1(str);
            Console.WriteLine();
        }
    }

}
