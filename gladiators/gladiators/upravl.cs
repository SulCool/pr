using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace gladiators
{
    internal class Upravl
    {
        char sw;
        protected int money = 100;
        List<Gladiator> gl = new List<Gladiator>(9);
        char rm;
        char ze;
        char ab;
        char zaeb;
        public int honor;
        char jot;
        bool konodio = true;
        char k;
        char tir;
        char v;

        public void slava()
        {
            if (honor >= 20) Console.WriteLine("Ваша слава растёт");
            if (honor >= 50) Console.WriteLine("На ваши бои смотрят бояре и округ");
            if (honor >= 70) Console.WriteLine("Вся страна ждут ваших сражений");
            if (honor >= 100) Console.WriteLine("Весь мир прознал о ваших гладиаторах");

        }
        public void upravl()
        {
            Console.WriteLine($"\n [1] нанять гладиатора \n [2] отправиться к доктору  \n [3] сходить в мастерскую \n [4] чтобы увидеть гладиаторов \n [5] утилизировать гладиатора");
            Infoplayer();
            sw = Console.ReadKey(true).KeyChar;
            switch (sw)
            {
                case '1':

                    if (money >= 100)
                    {
                        Hiring();
                    }

                    if (gl.Count > 9)
                    {
                        Console.WriteLine("В вашей кибитке, не хватит еды, больше чем на 9 гладиаторов");
                    }

                    else if (money < 100)
                    {
                        Console.WriteLine("У вас недостаточно деняк, попробуйте устроиться на работу, не знаю...");
                    }
                    break;

                case '2':
                    Hiling();
                    break;

                case '3':
                    Improve();
                    break;

                case '4':
                    if (gl.Count == 0)
                    {
                        Console.WriteLine("В вашей кибитке только тараканы(");
                    }
                    else
                    {
                        Console.WriteLine("Ого, ну вы посмотрите на этих парней/я:");
                        All();
                    }
                    break;

                case '5':
                    Remove();
                    break;
            }
        }
        public void Hiring()
        {
            money -= 100;
            Gladiator entity = new Gladiator();
            gl.Add(entity);
            Console.WriteLine($"Вы получили:{entity.Info()}");

        }
        public void All()
        {
            for (int i = 0; i < gl.Count; i++)
                Console.WriteLine($"У вас есть: {gl[i].Info()}");
        }
        public void Infoplayer()
        {
            Console.WriteLine($"Количество денег у игрока {money} слава рекрутёра {honor}");
        }
        public void Remove()
        {
            Console.WriteLine(@"Какого чудика вы хотите утилизировать?)

[1] СТЕРЕТЬ выбрано
[2] СТЕРЕТЬ всех                       ");

            rm = Console.ReadKey(true).KeyChar;
            switch (rm)
            {
                case '1':
                    Removing();
                    break;
                case '2':
                    gl.Clear();
                    break;
            }
        }
        public void Removing()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            else
            {
                All();
                Console.WriteLine($"Выберите какого чудика СТЕРЕТЬ: \n [1]  \n [2]  \n [3] \n [4] \n [5] \n [6] \n [7] \n [8] \n [9] \n");

                ze = Console.ReadKey(true).KeyChar;
                switch (ze)
                {
                    case '1':
                        gl.RemoveAt(0);
                        break;
                    case '2':
                        if (gl.Count < 1)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl.Count > 1)
                        {

                            gl.RemoveAt(1);
                        }
                        break;
                    case '3':
                        if (gl.Count < 2)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl.Count > 1)
                        {

                            gl.RemoveAt(2);
                        }

                        break;
                    case '4':
                        if (gl.Count < 3)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl.Count > 2)
                        {
                            gl.RemoveAt(3);
                        }

                        break;
                    case '5':
                        if (gl.Count < 4)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl.Count > 3)
                        {
                            gl.RemoveAt(4);
                        }
                        break;
                    case '6':
                        if (gl.Count < 5)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl.Count > 4)
                        {
                            gl.RemoveAt(6);
                        }
                        break;
                    case '7':
                        if (gl.Count < 6)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl.Count > 5)
                        {
                            gl.RemoveAt(6);
                        }

                        break;
                    case '8':
                        if (gl.Count < 7)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl.Count > 6)
                        {
                            gl.RemoveAt(7);
                        }
                        break;
                    case '9':
                        if (gl.Count < 8)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl.Count > 7)
                        {
                            gl.RemoveAt(8);
                        }
                        break;
                }
            }
        }
        public void Hiling()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            else
            {
                All();
                Console.WriteLine($"Выберите какого гладиатора облить эликсиром: \n [1]  \n [2]  \n [3] \n [4] \n [5] \n [6] \n [7] \n [8] \n [9] \n");
                ab = Console.ReadKey(true).KeyChar;
                switch (ab)
                {
                    case '1':
                        if (gl[0].hp >= 230)
                        {
                            Console.WriteLine("На вас больше не действуют эликсиры");
                        }
                        else if (money >= 50)
                        {
                            money -= 50;
                            gl[0].hp += 40;
                        }

                        else if (money < 50)
                        {
                            Console.WriteLine("Вы нищий");
                        }
                        break;

                    case '2':
                        if (gl.Count < 1)
                        {
                            Console.WriteLine(" ");
                        }

                        if (gl.Count > 1 && money >= 50)
                        {
                            money -= 50;
                            gl[1].hp += 40;
                        }
                        if (gl[1].hp >= 230)
                        {
                            Console.WriteLine("На вас больше не действуют эликсиры");
                        }
                        else if (money < 50)
                        {
                            Console.WriteLine("Вы нищий");
                        }
                        break;
                    case '3':

                        if (gl.Count < 2)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl.Count > 2 && money >= 50)
                        {
                            money -= 50;
                            gl[2].hp += 40;
                        }
                        if (gl[2].hp >= 230)
                        {
                            Console.WriteLine("На вас больше не действуют эликсиры");
                        }
                        else if (money < 50)
                        {
                            Console.WriteLine("Вы нищий");
                        }
                        break;
                    case '4':

                        if (gl.Count < 3)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl[3].hp >= 230)
                        {
                            Console.WriteLine("На вас больше не действуют эликсиры");
                        }
                        if (money >= 50 && gl.Count > 3)
                        {
                            money -= 50;
                            gl[3].hp += 40;
                        }
                        else if (money < 50)
                        {
                            Console.WriteLine("Вы нищий");
                        }
                        break;
                    case '5':

                        if (gl.Count < 4)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl[4].hp >= 230)
                        {
                            Console.WriteLine("На вас больше не действуют эликсиры");
                        }
                        if (gl.Count > 4 && money >= 50)
                        {
                            money -= 50;
                            gl[4].hp += 40;
                        }
                        else if (money < 50)
                        {
                            Console.WriteLine("Вы нищий");
                        }
                        break;
                    case '6':

                        if (gl.Count < 5)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl[5].hp >= 230)
                        {
                            Console.WriteLine("На вас больше не действуют эликсиры");
                        }
                        if (gl.Count > 5 && money >= 50)
                        {
                            money -= 50;
                            gl[1].hp += 40;
                        }
                        else if (money < 50)
                        {
                            Console.WriteLine("Вы нищий");
                        }
                        break;
                    case '7':

                        if (gl.Count < 6)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl[6].hp >= 230)
                        {
                            Console.WriteLine("На вас больше не действуют эликсиры");
                        }
                        if (gl.Count > 6 && money >= 50)
                        {
                            money -= 50;
                            gl[1].hp += 40;
                        }
                        else if (money < 50)
                        {
                            Console.WriteLine("Вы нищий");
                        }
                        break;
                    case '8':

                        if (gl.Count < 7)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl[7].hp >= 230)
                        {
                            Console.WriteLine("На вас больше не действуют эликсиры");
                        }
                        if (gl.Count > 7 && money >= 50)
                        {
                            money -= 50;
                            gl[1].hp += 40;
                        }
                        else if (money < 50)
                        {
                            Console.WriteLine("Вы нищий");
                        }
                        break;
                    case '9':

                        if (gl.Count < 8)
                        {
                            Console.WriteLine(" ");
                        }
                        if (gl[8].hp >= 230)
                        {
                            Console.WriteLine("На вас больше не действуют эликсиры");
                        }
                        if (gl.Count > 8 && money >= 50)
                        {
                            money -= 50;
                            gl[1].hp += 40;
                        }
                        else if (money < 50)
                        {
                            Console.WriteLine("Вы нищий");
                        }
                        break;
                }

            }
        }
        public void Improve()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            else
            {
                All();
                Console.WriteLine($"Выберите какого гладиатора хотите импрувнуть: \n [1]  \n [2]  \n [3] \n [4] \n [5] \n [6] \n [7] \n [8] \n [9] \n");
                zaeb = Console.ReadKey(true).KeyChar;
                switch (zaeb)
                {
                    case '1':
                        if (money < 100)
                        {
                            Console.WriteLine("Над вашей нищитой посмеялись");
                        }
                        if (gl[0].upgr >= 3)
                        {
                            Console.WriteLine("Вы уже богато одеты, больше некуда");
                        }
                        else if (money >= 100)
                        {
                            Console.WriteLine($"Вы улучшили своё оружие! - {100} золотых");
                            money -= 100;
                            gl[0].upgr += 1;
                            gl[0].str += 10;
                        }
                        break;
                    case '2':
                        if (gl.Count < 1)
                        {
                            Console.WriteLine(" ");
                        }
                        if (money < 100)
                        {
                            Console.WriteLine("Над вашей нищитой посмеялись");
                        }
                        if (gl[1].upgr >= 3)
                        {
                            Console.WriteLine("Вы уже богато одеты, больше некуда");
                        }
                        else if (money >= 100)
                        {
                            Console.WriteLine($"Вы улучшили своё оружие! - {100} золотых");
                            money -= 100;
                            gl[1].upgr += 1;
                            gl[1].str += 10;
                        }
                        break;
                    case '3':
                        if (gl.Count < 2)
                        {
                            Console.WriteLine(" ");
                        }
                        if (money < 100)
                        {
                            Console.WriteLine("Над вашей нищитой посмеялись");
                        }
                        if (gl[2].upgr >= 3)
                        {
                            Console.WriteLine("Вы уже богато одеты, больше некуда");
                        }
                        else if (money >= 100)
                        {
                            Console.WriteLine($"Вы улучшили своё оружие! - {100} золотых");
                            money -= 100;
                            gl[2].upgr += 1;
                            gl[2].str += 10;
                        }
                        break;
                    case '4':
                        if (gl.Count < 3)
                        {
                            Console.WriteLine(" ");
                        }
                        if (money < 100)
                        {
                            Console.WriteLine("Над вашей нищитой посмеялись");
                        }
                        if (gl[3].upgr >= 3)
                        {
                            Console.WriteLine("Вы уже богато одеты, больше некуда");
                        }
                        else if (money >= 100)
                        {
                            Console.WriteLine($"Вы улучшили своё оружие! - {100} золотых");
                            money -= 100;
                            gl[3].upgr += 1;
                            gl[3].str += 10;
                        }
                        break;
                    case '5':
                        if (gl.Count < 4)
                        {
                            Console.WriteLine(" ");
                        }
                        if (money < 100)
                        {
                            Console.WriteLine("Над вашей нищитой посмеялись");
                        }
                        if (gl[4].upgr >= 3)
                        {
                            Console.WriteLine("Вы уже богато одеты, больше некуда");
                        }
                        else if (money >= 100)
                        {
                            Console.WriteLine($"Вы улучшили своё оружие! - {100} золотых");
                            money -= 100;
                            gl[4].upgr += 1;
                            gl[4].str += 10;
                        }
                        break;
                    case '6':
                        if (gl.Count < 5)
                        {
                            Console.WriteLine(" ");
                        }
                        if (money < 100)
                        {
                            Console.WriteLine("Над вашей нищитой посмеялись");
                        }
                        if (gl[5].upgr >= 3)
                        {
                            Console.WriteLine("Вы уже богато одеты, больше некуда");
                        }
                        else if (money >= 100)
                        {
                            Console.WriteLine($"Вы улучшили своё оружие! - {100} золотых");
                            money -= 100;
                            gl[5].upgr += 1;
                            gl[5].str += 10;
                        }
                        break;
                    case '7':
                        if (gl.Count < 6)
                        {
                            Console.WriteLine(" ");
                        }
                        if (money < 100)
                        {
                            Console.WriteLine("Над вашей нищитой посмеялись");
                        }
                        if (gl[6].upgr >= 3)
                        {
                            Console.WriteLine("Вы уже богато одеты, больше некуда");
                        }
                        else if (money >= 100)
                        {
                            Console.WriteLine($"Вы улучшили своё оружие! - {100} золотых");
                            money -= 100;
                            gl[6].upgr += 1;
                            gl[6].str += 10;
                        }
                        break;
                    case '8':
                        if (gl.Count < 7)
                        {
                            Console.WriteLine(" ");
                        }
                        if (money < 100)
                        {
                            Console.WriteLine("Над вашей нищитой посмеялись");
                        }
                        if (gl[7].upgr >= 3)
                        {
                            Console.WriteLine("Вы уже богато одеты, больше некуда");
                        }
                        else if (money >= 100)
                        {
                            Console.WriteLine($"Вы улучшили своё оружие! - {100} золотых");
                            money -= 100;
                            gl[7].upgr += 1;
                            gl[7].str += 10;
                        }
                        break;
                    case '9':
                        if (gl.Count < 8)
                        {
                            Console.WriteLine(" ");
                        }
                        if (money < 100)
                        {
                            Console.WriteLine("Над вашей нищитой посмеялись");
                        }
                        if (gl[8].upgr >= 3)
                        {
                            Console.WriteLine("Вы уже богато одеты, больше некуда");
                        }
                        else if (money >= 100)
                        {
                            Console.WriteLine($"Вы улучшили своё оружие! - {100} золотых");
                            money -= 100;
                            gl[8].upgr += 1;
                            gl[8].str += 10;
                        }
                        break;
                }
            }
        }
        public void Win()
        {
            Console.WriteLine($"Вы получили [{100}] денег и славы [{5}]");
            money += 100;
            honor += 5;
        }
        public void lvl()
        {
            Console.WriteLine($"Выберите уровень сложности: \n [1] Низшая лига  \n [2] Средняя лига  \n [3] Высшая лига \n ");
            k = Console.ReadKey(true).KeyChar;
            switch (k)
            {
                case '1':
                    Voice();
                    break;
                case '2':
                    if (honor < 40)
                    {
                        Console.WriteLine("Такому ноунейму в средней лиге закрыто");
                    }
                    else
                    {
                        Voice2();
                    }

                    break;
                case '3':
                    if (honor < 60)
                    {
                        Console.WriteLine("Высшая лига посмеялась над вами");
                    }
                    else
                    {
                        Voice3();
                    }
                    break;
            }
            
        }
        public void Voice3()
        {
            All();
            Console.WriteLine("Выберите кем сражаться: \n [1]  \n [2] \n [3] \n [4] \n [5] \n [6] \n [7] \n [8] \n [9] \n");
            v = Console.ReadKey(true).KeyChar;
            switch (v)
            {
                case '1':
                    Boi19();
                    break;
                case '2':
                    Boi20();
                    break;
                case '3':
                    Boi21();
                    break;
                case '4':
                    Boi22();
                    break;
                case '5':
                    Boi23();
                    break;
                case '6':
                    Boi24();
                    break;
                case '7':
                    Boi25();
                    break;
                case '8':
                    Boi26();
                    break;
                case '9':
                    Boi27();
                    break;
            }
        }
        public void Voice2()
        {
            All();
            Console.WriteLine("Выберите кем сражаться: \n [1]  \n [2] \n [3] \n [4] \n [5] \n [6] \n [7] \n [8] \n [9] \n");
            tir = Console.ReadKey(true).KeyChar;
                switch (tir)
                {
                    case '1':
                        Boi10();
                        break;
                    case '2':
                        Boi11();
                        break;
                    case '3':
                        Boi12();
                        break;
                    case '4':
                        Boi13();
                        break;
                    case '5':
                        Boi14();
                        break;
                    case '6':
                        Boi15();
                        break;
                    case '7':
                        Boi16();
                        break;
                    case '8':
                        Boi17();
                        break;
                    case '9':
                        Boi18();
                        break;
                }
            
        }
        public void Voice()
        {
            All();
            Console.WriteLine("Выберите кем сражаться: \n [1]  \n [2] \n [3] \n [4] \n [5] \n [6] \n [7] \n [8] \n [9] \n");
            jot = Console.ReadKey(true).KeyChar;
            switch (jot)
            {
                case '1':
                   Boi1();
                    break;
                case '2':
                    Boi2();
                    break;
                case '3':
                    Boi3();
                    break;
                case '4':
                    Boi4();
                    break;
                case '5':
                    Boi5();
                    break;
                case '6':
                    Boi6();
                    break;
                case '7':
                    Boi7();
                    break;
                case '8':
                    Boi8();
                    break;
                case '9':
                    Boi9();
                    break;
            }
        }
        public void Boi1()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            else
            {
                Gob g = new Gob();
                Console.WriteLine(gl[0].Infof() + " против " + g.Info());
                Console.WriteLine();
                do
                {
                    gl[0].Hit1(g);
                    Console.WriteLine(gl[0].Infof() + " делает свой ход");
                    Console.WriteLine(g.Info() + $" получил {gl[0].str} урона");
                    if (g.Lose())
                    {
                        Console.WriteLine($"{g.Info()}: сфидил");
                        Win();
                        break;
                    }

                    g.Hit1(gl[0]);
                    Console.WriteLine(g.Info() + " делает свой ход");
                    Console.WriteLine(gl[0].Infof() + $" получил {30} урона");
                    if (gl[0].Lose())
                    {
                        Console.WriteLine($"{gl[0].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(0);
                        break;
                    }
                }
                while (true);
            }

            

        }
        public void Boi2()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 1)
            {
                Console.WriteLine(" ");
            }
            else if(gl.Count > 1)
            {
                
                    Gob g = new Gob();
                    Console.WriteLine(gl[1].Infof() + " против " + g.Info());
                    Console.WriteLine();
                    do
                    {
                        gl[1].Hit1(g);
                        Console.WriteLine(gl[1].Infof() + " делает свой ход");
                        Console.WriteLine(g.Info() + $" получил {gl[1].str} урона");
                        if (g.Lose())
                        {
                            Console.WriteLine($"{g.Info()}: сфидил");
                            Win();
                            break;
                        }

                        g.Hit1(gl[1]);
                        Console.WriteLine(g.Info() + " делает свой ход");
                        Console.WriteLine(gl[1].Infof() + $" получил {30 } урона");
                        if (gl[1].Lose())
                        {
                            Console.WriteLine($"{gl[1].Infof()}: похиб в бою");
                            honor -= 5;
                            gl.RemoveAt(1);
                            break;
                        }
                    }
                    while (true);
                
            }
        }
        public void Boi3()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 2)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 2)
            {
                Gob g = new Gob();
                Console.WriteLine(gl[2].Infof() + " против " + g.Info());
                Console.WriteLine();
                do
                {
                    gl[2].Hit1(g);
                    Console.WriteLine(gl[2].Infof() + " делает свой ход");
                    Console.WriteLine(g.Info() + $" получил {gl[2].str} урона");
                    if (g.Lose())
                    {
                        Console.WriteLine($"{g.Info()}: сфидил");
                        Win();
                        break;
                    }

                    g.Hit1(gl[2]);
                    Console.WriteLine(g.Info() + " делает свой ход");
                    Console.WriteLine(gl[2].Infof() + $" получил {30} урона");
                    if (gl[2].Lose())
                    {
                        Console.WriteLine($"{gl[2].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(2);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi4()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 3)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 3)
            {
                Gob g = new Gob();
                Console.WriteLine(gl[3].Infof() + " против " + g.Info());
                Console.WriteLine();
                do
                {
                    gl[3].Hit1(g);
                    Console.WriteLine(gl[3].Infof() + " делает свой ход");
                    Console.WriteLine(g.Info() + $" получил {gl[3].str} урона");
                    if (g.Lose())
                    {
                        Console.WriteLine($"{g.Info()}: сфидил");
                        Win();
                        break;
                    }

                    g.Hit1(gl[3]);
                    Console.WriteLine(g.Info() + " делает свой ход");
                    Console.WriteLine(gl[3].Infof() + $" получил {30 } урона");
                    if (gl[3].Lose())
                    {
                        Console.WriteLine($"{gl[3].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(3);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi5()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 4)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 4)
            {
                Gob g = new Gob();
                Console.WriteLine(gl[4].Infof() + " против " + g.Info());
                Console.WriteLine();
                do
                {
                    gl[4].Hit1(g);
                    Console.WriteLine(gl[4].Infof() + " делает свой ход");
                    Console.WriteLine(g.Info() + $" получил {gl[4].str} урона");
                    if (g.Lose())
                    {
                        Console.WriteLine($"{g.Info()}: сфидил");
                        Win();
                        break;
                    }

                    g.Hit1(gl[4]);
                    Console.WriteLine(g.Info() + " делает свой ход");
                    Console.WriteLine(gl[4].Infof() + $" получил {30} урона");
                    if (gl[4].Lose())
                    {
                        Console.WriteLine($"{gl[4].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(4);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi6()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 5)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 5)
            {
                Gob g = new Gob();
                Console.WriteLine(gl[5].Infof() + " против " + g.Info());
                Console.WriteLine();
                do
                {
                    gl[5].Hit1(g);
                    Console.WriteLine(gl[5].Infof() + " делает свой ход");
                    Console.WriteLine(g.Info() + $" получил {gl[5].str} урона");
                    if (g.Lose())
                    {
                        Console.WriteLine($"{g.Info()}: сфидил");
                        Win();
                        break;
                    }

                    g.Hit1(gl[5]);
                    Console.WriteLine(g.Info() + " делает свой ход");
                    Console.WriteLine(gl[5].Infof() + $" получил {30} урона");
                    if (gl[5].Lose())
                    {
                        Console.WriteLine($"{gl[5].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(5);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi7()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 6)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 6) 
            {
                Gob g = new Gob();
                Console.WriteLine(gl[6].Infof() + " против " + g.Info());
                Console.WriteLine();
                do
                {
                    gl[6].Hit1(g);
                    Console.WriteLine(gl[6].Infof() + " делает свой ход");
                    Console.WriteLine(g.Info() + $" получил {gl[6].str} урона");
                    if (g.Lose())
                    {
                        Console.WriteLine($"{g.Info()}: сфидил");
                        Win();
                        break;
                    }

                    g.Hit1(gl[6]);
                    Console.WriteLine(g.Info() + " делает свой ход");
                    Console.WriteLine(gl[6].Infof() + $" получил {30} урона");
                    if (gl[6].Lose())
                    {
                        Console.WriteLine($"{gl[6].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(6);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi8()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 7)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 7)
            {
                Gob g = new Gob();
                Console.WriteLine(gl[7].Infof() + " против " + g.Info());
                Console.WriteLine();
                do
                {
                    gl[7].Hit1(g);
                    Console.WriteLine(gl[7].Infof() + " делает свой ход");
                    Console.WriteLine(g.Info() + $" получил {gl[7].str} урона");
                    if (g.Lose())
                    {
                        Console.WriteLine($"{g.Info()}: сфидил");
                        Win();
                        break;
                    }

                    g.Hit1(gl[7]);
                    Console.WriteLine(g.Info() + " делает свой ход");
                    Console.WriteLine(gl[7].Infof() + $" получил {30} урона");
                    if (gl[7].Lose())
                    {
                        Console.WriteLine($"{gl[7].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(7);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi9()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 8)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 8)
            {
                Gob g = new Gob();
                Console.WriteLine(gl[8].Infof() + " против " + g.Info());
                Console.WriteLine();
                do
                {
                    gl[8].Hit1(g);
                    Console.WriteLine(gl[8].Infof() + " делает свой ход");
                    Console.WriteLine(g.Info() + $" получил {gl[8].str} урона");
                    if (g.Lose())
                    {
                        Console.WriteLine($"{g.Info()}: сфидил");
                        Win();
                        break;
                    }

                    g.Hit1(gl[8]);
                    Console.WriteLine(g.Info() + " делает свой ход");
                    Console.WriteLine(gl[8].Infof() + $" получил {30} урона");
                    if (gl[8].Lose())
                    {
                        Console.WriteLine($"{gl[8].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(8);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi10()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            else
            {
                Lion e = new Lion();
                Console.WriteLine(gl[0].Infof() + " против " + e.Info());
                Console.WriteLine();
                do
                {
                    gl[0].Hit1(e);
                    Console.WriteLine(gl[0].Infof() + " делает свой ход");
                    Console.WriteLine(e.Info() + $" получил {gl[0].str} урона");
                    if (e.Lose())
                    {
                        Console.WriteLine($"{e.Info()}: сфидил");
                        Win();
                        break;
                    }

                    e.Hit1(gl[0]);
                    Console.WriteLine(e.Info() + " делает свой ход");
                    Console.WriteLine(gl[0].Infof() + $" получил {60} урона");
                    if (gl[0].Lose())
                    {
                        Console.WriteLine($"{gl[0].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(0);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi11()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 1)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 1)
            {

                Lion e = new Lion();
                Console.WriteLine(gl[1].Infof() + " против " + e.Info());
                Console.WriteLine();
                do
                {
                    gl[1].Hit1(e);
                    Console.WriteLine(gl[1].Infof() + " делает свой ход");
                    Console.WriteLine(e.Info() + $" получил {gl[1].str} урона");
                    if (e.Lose())
                    {
                        Console.WriteLine($"{e.Info()}: сфидил");
                        Win();
                        break;
                    }

                    e.Hit1(gl[1]);
                    Console.WriteLine(e.Info() + " делает свой ход");
                    Console.WriteLine(gl[1].Infof() + $" получил {60} урона");
                    if (gl[1].Lose())
                    {
                        Console.WriteLine($"{gl[1].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(1);
                        break;
                    }
                }
                while (true);

            }
        }
        public void Boi12()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 2)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 2)
            {
                Lion e = new Lion();
                Console.WriteLine(gl[2].Infof() + " против " + e.Info());
                Console.WriteLine();
                do
                {
                    gl[2].Hit1(e);
                    Console.WriteLine(gl[2].Infof() + " делает свой ход");
                    Console.WriteLine(e.Info() + $" получил {gl[2].str} урона");
                    if (e.Lose())
                    {
                        Console.WriteLine($"{e.Info()}: сфидил");
                        Win();
                        break;
                    }
                    e.Hit1(gl[2]);
                    Console.WriteLine(e.Info() + " делает свой ход");
                    Console.WriteLine(gl[2].Infof() + $" получил {60} урона");
                    if (gl[2].Lose())
                    {
                        Console.WriteLine($"{gl[2].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(2);
                        break;
                    }
                }
                while (true);

            }
        }
        public void Boi13()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 3)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 3)
            {
                Lion e = new Lion();
                Console.WriteLine(gl[3].Infof() + " против " + e.Info());
                Console.WriteLine();
                do
                {
                    gl[3].Hit1(e);
                    Console.WriteLine(gl[3].Infof() + " делает свой ход");
                    Console.WriteLine(e.Info() + $" получил {gl[3].str} урона");
                    if (e.Lose())
                    {
                        Console.WriteLine($"{e.Info()}: сфидил");
                        Win();
                        break;
                    }
                    e.Hit1(gl[3]);
                    Console.WriteLine(e.Info() + " делает свой ход");
                    Console.WriteLine(gl[3].Infof() + $" получил {60} урона");
                    if (gl[3].Lose())
                    {
                        Console.WriteLine($"{gl[3].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(3);
                        break;
                    }
                }
                while (true);

            }
        }
        public void Boi14()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 4)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 4)
            {
                Lion e = new Lion();
                Console.WriteLine(gl[4].Infof() + " против " + e.Info());
                Console.WriteLine();
                do
                {
                    gl[4].Hit1(e);
                    Console.WriteLine(gl[4].Infof() + " делает свой ход");
                    Console.WriteLine(e.Info() + $" получил {gl[4].str} урона");
                    if (e.Lose())
                    {
                        Console.WriteLine($"{e.Info()}: сфидил");
                        Win();
                        break;
                    }
                    e.Hit1(gl[4]);
                    Console.WriteLine(e.Info() + " делает свой ход");
                    Console.WriteLine(gl[4].Infof() + $" получил {60} урона");
                    if (gl[4].Lose())
                    {
                        Console.WriteLine($"{gl[4].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(4);
                        break;
                    }
                }
                while (true);

            }
        }
        public void Boi15()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 5)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 5)
            {
                Lion e = new Lion();
                Console.WriteLine(gl[5].Infof() + " против " + e.Info());
                Console.WriteLine();
                do
                {
                    gl[5].Hit1(e);
                    Console.WriteLine(gl[5].Infof() + " делает свой ход");
                    Console.WriteLine(e.Info() + $" получил {gl[5].str} урона");
                    if (e.Lose())
                    {
                        Console.WriteLine($"{e.Info()}: сфидил");
                        Win();
                        break;
                    }
                    e.Hit1(gl[5]);
                    Console.WriteLine(e.Info() + " делает свой ход");
                    Console.WriteLine(gl[5].Infof() + $" получил {60} урона");
                    if (gl[5].Lose())
                    {
                        Console.WriteLine($"{gl[5].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(5);
                        break;
                    }
                }
                while (true);

            }
        }
        public void Boi16()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 6)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 6)
            {
                Lion e = new Lion();
                Console.WriteLine(gl[6].Infof() + " против " + e.Info());
                Console.WriteLine();
                do
                {
                    gl[6].Hit1(e);
                    Console.WriteLine(gl[6].Infof() + " делает свой ход");
                    Console.WriteLine(e.Info() + $" получил {gl[6].str} урона");
                    if (e.Lose())
                    {
                        Console.WriteLine($"{e.Info()}: сфидил");
                        Win();
                        break;
                    }
                    e.Hit1(gl[6]);
                    Console.WriteLine(e.Info() + " делает свой ход");
                    Console.WriteLine(gl[6].Infof() + $" получил {60} урона");
                    if (gl[6].Lose())
                    {
                        Console.WriteLine($"{gl[6].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(6);
                        break;
                    }
                }
                while (true);

            }
        }
        public void Boi17()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 7)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 7)
            {
                Lion e = new Lion();
                Console.WriteLine(gl[7].Infof() + " против " + e.Info());
                Console.WriteLine();
                do
                {
                    gl[7].Hit1(e);
                    Console.WriteLine(gl[7].Infof() + " делает свой ход");
                    Console.WriteLine(e.Info() + $" получил {gl[7].str} урона");
                    if (e.Lose())
                    {
                        Console.WriteLine($"{e.Info()}: сфидил");
                        Win();
                        break;
                    }
                    e.Hit1(gl[7]);
                    Console.WriteLine(e.Info() + " делает свой ход");
                    Console.WriteLine(gl[7].Infof() + $" получил {60} урона");
                    if (gl[7].Lose())
                    {
                        Console.WriteLine($"{gl[7].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(7);
                        break;
                    }
                }
                while (true);

            }
        }
        public void Boi18()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 8)
            {
                Console.WriteLine(" ");
            }
            else if (gl.Count > 8)
            {
                Lion e = new Lion();
                Console.WriteLine(gl[8].Infof() + " против " + e.Info());
                Console.WriteLine();
                do
                {
                    gl[8].Hit1(e);
                    Console.WriteLine(gl[8].Infof() + " делает свой ход");
                    Console.WriteLine(e.Info() + $" получил {gl[8].str} урона");
                    if (e.Lose())
                    {
                        Console.WriteLine($"{e.Info()}: сфидил");
                        Win();
                        break;
                    }
                    e.Hit1(gl[8]);
                    Console.WriteLine(e.Info() + " делает свой ход");
                    Console.WriteLine(gl[8].Infof() + $" получил {60} урона");
                    if (gl[8].Lose())
                    {
                        Console.WriteLine($"{gl[8].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(8);
                        break;
                    }
                }
                while (true);

            }
        }
        public void Boi19()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            else
            {
                Powerglad p = new Powerglad();
                Console.WriteLine(gl[0].Infof() + " против " + p.Info());
                Console.WriteLine();
                do
                {
                    gl[0].Hit1(p);
                    Console.WriteLine(gl[0].Infof() + " делает свой ход");
                    Console.WriteLine(p.Info() + $" получил {gl[0].str} урона");
                    if (p.Lose())
                    {
                        Console.WriteLine($"{p.Info()}: сфидил");
                        Win();
                        break;
                    }

                    p.Hit1(gl[0]);
                    Console.WriteLine(p.Info() + " делает свой ход");
                    Console.WriteLine(gl[0].Infof() + $" получил {80} урона");
                    if (gl[0].Lose())
                    {
                        Console.WriteLine($"{gl[0].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(0);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi20()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 1)
            {
                Console.WriteLine(" ");
            }
            else
            {
                Powerglad p = new Powerglad();
                Console.WriteLine(gl[1].Infof() + " против " + p.Info());
                Console.WriteLine();
                do
                {
                    gl[1].Hit1(p);
                    Console.WriteLine(gl[1].Infof() + " делает свой ход");
                    Console.WriteLine(p.Info() + $" получил {gl[1].str} урона");
                    if (p.Lose())
                    {
                        Console.WriteLine($"{p.Info()}: сфидил");
                        Win();
                        break;
                    }

                    p.Hit1(gl[1]);
                    Console.WriteLine(p.Info() + " делает свой ход");
                    Console.WriteLine(gl[1].Infof() + $" получил {80} урона");
                    if (gl[1].Lose())
                    {
                        Console.WriteLine($"{gl[1].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(1);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi21()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 2)
            {
                Console.WriteLine(" ");
            }
            else
            {
                Powerglad p = new Powerglad();
                Console.WriteLine(gl[2].Infof() + " против " + p.Info());
                Console.WriteLine();
                do
                {
                    gl[2].Hit1(p);
                    Console.WriteLine(gl[2].Infof() + " делает свой ход");
                    Console.WriteLine(p.Info() + $" получил {gl[2].str} урона");
                    if (p.Lose())
                    {
                        Console.WriteLine($"{p.Info()}: сфидил");
                        Win();
                        break;
                    }

                    p.Hit1(gl[2]);
                    Console.WriteLine(p.Info() + " делает свой ход");
                    Console.WriteLine(gl[2].Infof() + $" получил {80} урона");
                    if (gl[2].Lose())
                    {
                        Console.WriteLine($"{gl[2].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(2);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi22()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 3)
            {
                Console.WriteLine(" ");
            }
            else
            {
                Powerglad p = new Powerglad();
                Console.WriteLine(gl[3].Infof() + " против " + p.Info());
                Console.WriteLine();
                do
                {
                    gl[3].Hit1(p);
                    Console.WriteLine(gl[3].Infof() + " делает свой ход");
                    Console.WriteLine(p.Info() + $" получил {gl[3].str} урона");
                    if (p.Lose())
                    {
                        Console.WriteLine($"{p.Info()}: сфидил");
                        Win();
                        break;
                    }

                    p.Hit1(gl[3]);
                    Console.WriteLine(p.Info() + " делает свой ход");
                    Console.WriteLine(gl[3].Infof() + $" получил {80} урона");
                    if (gl[3].Lose())
                    {
                        Console.WriteLine($"{gl[3].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(3);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi23()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 4)
            {
                Console.WriteLine(" ");
            }
            else
            {
                Powerglad p = new Powerglad();
                Console.WriteLine(gl[4].Infof() + " против " + p.Info());
                Console.WriteLine();
                do
                {
                    gl[4].Hit1(p);
                    Console.WriteLine(gl[4].Infof() + " делает свой ход");
                    Console.WriteLine(p.Info() + $" получил {gl[4].str} урона");
                    if (p.Lose())
                    {
                        Console.WriteLine($"{p.Info()}: сфидил");
                        Win();
                        break;
                    }

                    p.Hit1(gl[4]);
                    Console.WriteLine(p.Info() + " делает свой ход");
                    Console.WriteLine(gl[4].Infof() + $" получил {80} урона");
                    if (gl[4].Lose())
                    {
                        Console.WriteLine($"{gl[4].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(4);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi24()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 5)
            {
                Console.WriteLine(" ");
            }
            else
            {
                Powerglad p = new Powerglad();
                Console.WriteLine(gl[5].Infof() + " против " + p.Info());
                Console.WriteLine();
                do
                {
                    gl[5].Hit1(p);
                    Console.WriteLine(gl[5].Infof() + " делает свой ход");
                    Console.WriteLine(p.Info() + $" получил {gl[5].str} урона");
                    if (p.Lose())
                    {
                        Console.WriteLine($"{p.Info()}: сфидил");
                        Win();
                        break;
                    }

                    p.Hit1(gl[5]);
                    Console.WriteLine(p.Info() + " делает свой ход");
                    Console.WriteLine(gl[5].Infof() + $" получил {80} урона");
                    if (gl[5].Lose())
                    {
                        Console.WriteLine($"{gl[5].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(5);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi25()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 6)
            {
                Console.WriteLine(" ");
            }
            else
            {
                Powerglad p = new Powerglad();
                Console.WriteLine(gl[6].Infof() + " против " + p.Info());
                Console.WriteLine();
                do
                {
                    gl[6].Hit1(p);
                    Console.WriteLine(gl[6].Infof() + " делает свой ход");
                    Console.WriteLine(p.Info() + $" получил {gl[6].str} урона");
                    if (p.Lose())
                    {
                        Console.WriteLine($"{p.Info()}: сфидил");
                        Win();
                        break;
                    }

                    p.Hit1(gl[6]);
                    Console.WriteLine(p.Info() + " делает свой ход");
                    Console.WriteLine(gl[6].Infof() + $" получил {80} урона");
                    if (gl[6].Lose())
                    {
                        Console.WriteLine($"{gl[6].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(6);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi26()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 7)
            {
                Console.WriteLine(" ");
            }
            else
            {
                Powerglad p = new Powerglad();
                Console.WriteLine(gl[7].Infof() + " против " + p.Info());
                Console.WriteLine();
                do
                {
                    gl[7].Hit1(p);
                    Console.WriteLine(gl[7].Infof() + " делает свой ход");
                    Console.WriteLine(p.Info() + $" получил {gl[7].str} урона");
                    if (p.Lose())
                    {
                        Console.WriteLine($"{p.Info()}: сфидил");
                        Win();
                        break;
                    }

                    p.Hit1(gl[7]);
                    Console.WriteLine(p.Info() + " делает свой ход");
                    Console.WriteLine(gl[7].Infof() + $" получил {80} урона");
                    if (gl[7].Lose())
                    {
                        Console.WriteLine($"{gl[7].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(7);
                        break;
                    }
                }
                while (true);
            }
        }
        public void Boi27()
        {
            if (gl.Count == 0)
            {
                Console.WriteLine("В вашей кибитке только тараканы(");
            }
            if (gl.Count < 8)
            {
                Console.WriteLine(" ");
            }
            else
            {
                Powerglad p = new Powerglad();
                Console.WriteLine(gl[8].Infof() + " против " + p.Info());
                Console.WriteLine();
                do
                {
                    gl[8].Hit1(p);
                    Console.WriteLine(gl[8].Infof() + " делает свой ход");
                    Console.WriteLine(p.Info() + $" получил {gl[8].str} урона");
                    if (p.Lose())
                    {
                        Console.WriteLine($"{p.Info()}: сфидил");
                        Win();
                        break;
                    }

                    p.Hit1(gl[8]);
                    Console.WriteLine(p.Info() + " делает свой ход");
                    Console.WriteLine(gl[8].Infof() + $" получил {80} урона");
                    if (gl[8].Lose())
                    {
                        Console.WriteLine($"{gl[8].Infof()}: похиб в бою");
                        honor -= 5;
                        gl.RemoveAt(8);
                        break;
                    }
                }
                while (true);
            }
        }
    }
}
