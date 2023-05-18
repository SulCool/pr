using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace gladiators
{
    class Gladiator : Upravl
    {
        public int hp;
        public int str;
        protected string name;
        protected int star;
        public int upgr;
        string[] name_array = new string[] { "Марк Атилиус", "Фламма", "Крикс", "Лентул Батиат", "Гай Ганник", "Карпофор", "Коммод", "Спикулус", "Герардеска Манутиус", "Спартак", "Публипор", "Каст", "Эномай" };

        public Gladiator()
        {
            star = Dice.Next(1, 5);
            switch (star)
            {
                case 1:
                    hp = Dice.Next(70, 100);
                    str = Dice.Next(20, 30);
                    name = name_array[Dice.Next(0, 13)];
                    upgr = 0;
                    break;
                case 2:
                    hp = Dice.Next(90, 140);
                    str = Dice.Next(30, 40);
                    name = name_array[Dice.Next(0, 13)];
                    upgr = 0;
                    break;
                case 3:
                    hp = Dice.Next(140, 160);
                    str = Dice.Next(40, 50);
                    name = name_array[Dice.Next(0, 13)];
                    upgr = 0;
                    break;
                case 4:
                    hp = Dice.Next(160, 180);
                    str = Dice.Next(50, 70);
                    name = name_array[Dice.Next(0, 13)];
                    upgr = 0;
                    break;
                default:
                    Console.WriteLine("что то не так");
                    break;
            }
        }
        public string Info()
        {

            return $"имя [{name}] здорoвье[{hp}] сила[{str}] звезда [{star}] улучшение[{upgr}]";

        }
        public string Infof()
        {
            return $"гладиатор имя [{name}] здорoвье[{hp}] сила[{str}]";
        }
        public virtual void Hit1(Gladiator target)
        {
            target.TakeDamage1(str);
            Console.WriteLine();
        }
        public void TakeDamage1(int dmg)
        {
            hp -= dmg;
        }
        public bool Lose()
        {
            return hp <= 10;
        }
    }
}


