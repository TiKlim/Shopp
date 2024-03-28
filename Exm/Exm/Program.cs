using System;

namespace Exm
{
    internal class Program
    {
        static void Main()
        {
            Retailltem.these = new List<Retailltem>();
            CashRegister.theses = new List<CashRegister>();
            Retailltem retailltem;
            Retailltem da = new Retailltem();
            CashRegister aga;
            Console.WriteLine("Приветствую!");
            /*while (true)
            {
                foreach (Retailltem a in Retailltem.these)
                {
                    Console.WriteLine("Нажмите 1 .");
                    int s = Convert.ToInt32(Console.ReadLine());
                    if (s == a.Num)
                    {
                        retailltem = a;
                        retailltem.Info();
                    }
                }
            }*/
            /*CashRegister.theses.Add(new CashRegister());
            foreach (CashRegister d in CashRegister.theses)
            {
                Console.WriteLine("> Введите номер 1: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                int v = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                if (v == d.Num)
                {
                    aga = d;
                    aga.Show_items();
                }*/
                da.Info();
            }
        }
    }
//}