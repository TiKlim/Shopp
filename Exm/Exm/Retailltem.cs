using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exm
{
    internal class Retailltem
    {
        static public List<Retailltem> these;
        protected List<string> pidjak = new List<string>();
        protected List<string> jeance = new List<string>();
        protected List<string> shirt = new List<string>();

        protected List<string> pidjak_cash = new List<string>();
        protected List<string> jeance_cash = new List<string>();
        protected List<string> shirt_cash = new List<string>();

        protected double price1;
        protected double price2;
        protected double price3;
        protected double price;
        protected int num;
        public int Num { get { return num; } }
        public CashRegister aga { get; set; }
        public Retailltem() { Info(); }

        /*public static void Menu(List<Retailltem> these)
        {
            Console.WriteLine("Мы рады видеть Вас снова!");
            foreach (var number in these)
            {
                number.Info();
            }
        }*/
        public void Info()
        {
            this.price1 = 59.95;
            this.price2 = 34.95;
            this.price3 = 24.95;
            this.price = 0;
            this.num = 1;

            pidjak.Add("Пиджак");
            pidjak.Add("Пиджак");
            pidjak.Add("Пиджак");
            pidjak.Add("Пиджак");
            pidjak.Add("Пиджак");
            pidjak.Add("Пиджак");
            pidjak.Add("Пиджак");
            pidjak.Add("Пиджак");
            pidjak.Add("Пиджак");
            pidjak.Add("Пиджак");
            pidjak.Add("Пиджак");
            pidjak.Add("Пиджак");

            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");
            jeance.Add("Дизайнерские джинсы");

            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");
            shirt.Add("Рубашка");

            Print(aga);
        }
        protected void Print(CashRegister aga)
        {
            Console.WriteLine("> Доступные товары:");
            Console.WriteLine("");
            Console.WriteLine("           |       Описание      | Количество на складе |   Цена   ");
            Console.WriteLine($"Товар№1    | Пиджак              | {pidjak.Count}                   | {price1} ");
            Console.WriteLine($"Товар№2    | Дизайнерские джинсы | {jeance.Count}                   | {price2} ");
            Console.WriteLine($"Товар№3    | Рубашка             | {shirt.Count}                   | {price3} ");
            Console.WriteLine("");
            Console.WriteLine("> Ваши действия: \n1 - Приобрести товар; 2 - Корзина.");
            int vybor = Convert.ToInt32(Console.ReadLine());
            switch (vybor)
            {
                case 1:
                    //aga.Purchase_item();
                    Purchase_item();
                    break;
                case 2:
                    //aga.Show_items();
                    Show_items();
                    break;
            }            
        }




        public void Purchase_item()
        {
            Console.WriteLine("> Какой из трёх представленных товаров Вы хотите приобрести? (1, 2, или 3)");
            int vybor = Convert.ToInt32(Console.ReadLine());
            if (vybor == 1)
            {
                if (pidjak.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!РАСПРОДАНО!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Print(aga);
                }
                else
                {
                    pidjak.Remove("Пиджак");
                    pidjak_cash.Add("Пиджак");
                    price += price1;
                    Print(aga);
                }
            }
            if (vybor == 2)
            {
                if (pidjak.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!РАСПРОДАНО!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Print(aga);
                }
                else
                {
                    jeance.Remove("Дизайнерские джинсы");
                    jeance_cash.Add("Дизайнерские джинсы");
                    price += price2;
                    Print(aga);
                }
            }
            if (vybor == 3)
            {
                if (pidjak.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!РАСПРОДАНО!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Print(aga);
                }
                else
                {
                    shirt.Remove("Рубашка");
                    shirt_cash.Add("Рубашка");
                    price += price3;
                    Print(aga);
                }
            }
        }
        protected void Get_total()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"> Общая сумма покупки: {price}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Print(aga);
        }
        public void Show_items()
        {
            Console.WriteLine("> Корзина:");
            Console.WriteLine("           |       Описание      |    Количество в корзине   |   Цена   ");
            Console.WriteLine($"Товар№1    | Пиджак              | {pidjak_cash.Count}                         | {price1} ");
            Console.WriteLine($"Товар№2    | Дизайнерские джинсы | {jeance_cash.Count}                         | {price2} ");
            Console.WriteLine($"Товар№3    | Рубашка             | {shirt_cash.Count}                         | {price3} ");
            Console.WriteLine("");
            Console.WriteLine("> Ваши действия: \n1 - Общая сумма покупки; 2 - Отчистить корзину; 3 - Вернуться обратно.");
            int vybor3 = Convert.ToInt32(Console.ReadLine());
            switch (vybor3)
            {
                case 1:
                    Get_total();
                    break;
                case 2:
                    Clear();
                    break;
                case 3:
                    Print(aga);
                    break;
            }
        }
        protected void Clear()
        {
            pidjak_cash.Clear();
            jeance_cash.Clear();
            shirt_cash.Clear();
            Print(aga);
        }
    }
}