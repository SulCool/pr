using System;

namespace gladiators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sw;
            bool di = false;

     
            Console.WriteLine(@"                                ********************************************************* 
                                *    Вы молодой человек, решаетесь на отважный шаг      *
                                *    заняться рискованным делом - гладиаторскими боями! *
                                *    Вы будете нанимать гладиаторов, и наблюдать за     *
                                *                  ""НЕВЕРОЯТНЫМИ БОЯМИ""                 *
                                *********************************************************");
                                  
            Upravl pla = new Upravl();

            do
            {
                pla.slava();
                Console.WriteLine($"\n [1]Бои \n [2]Управление \n [3]Выход(сохранения не будет) \n");
                pla.Infoplayer();
                sw = Console.ReadKey(true).KeyChar;

                switch (sw)
                {
                    case '1':
                        pla.lvl();
                        break;
                    case '2':
                        pla.upravl();
                        break;

                }

                

                if (sw == '3') { di = true; Console.WriteLine("Вы оставили это дело."); }

                Console.ReadLine();

            } while (di != true);

        }
    }
}
