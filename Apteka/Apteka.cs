using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka
{
    class Apteka
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Информация об аптеках.");
            Console.WriteLine("Введитее номер аптеки (1-3), информацию о которой вы хотите узнать. ");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                AptekaClass atpeka = new AptekaClass();
                Console.WriteLine("*******************************");
                atpeka.Aptekaname = ("Аптека им. Ф.В.Чижова");
                Console.WriteLine(atpeka.Aptekaname);
                Console.WriteLine("*******************************");
                /////////////////////////////////////
                AptekaClass ttt = new AptekaClass();
                ttt.lekva.Add("Феназепам", 199);
                ttt.lekva.Add("Спазмолгон", 299);
                ttt.lekva.Add("Винпоцетин", 499);
                ttt.lekva.Add("Вамлосет", 899);
                ttt.lekva.Add("Парацетамол", 49);
                ttt.lekva.Add("Клоназепам", 199);
                var res = ttt.GetMax(ttt);
                Console.WriteLine($"Самое дорогое лекарство - {res}");
                decimal sum1 = ttt.Sum(ttt);
                Console.WriteLine("*******************************");
                /////////////////////////////////////
                Console.WriteLine($"Стоимость всех лекарств в аптеке составляет: {sum1} рублей");
                Console.WriteLine("*******************************");
                Console.WriteLine("Список всех лекарств в " + atpeka.Aptekaname);
                ttt.Spisok(ttt);
            }
            else if (num == 2)
            {
                AptekaClass atpeka2 = new AptekaClass();
                atpeka2.Aptekaname = ("Аптека Бурденко");
                Console.WriteLine("*******************************");
                Console.WriteLine(atpeka2.Aptekaname);
                Console.WriteLine("*******************************");

                /////////////////////////////////////
                AptekaClass ttt = new AptekaClass();
                ttt.lekva.Add("Азопт", 450);
                ttt.lekva.Add("Амиксин", 520);
                ttt.lekva.Add("Блемарен", 899);
                ttt.lekva.Add("Нутрилак", 29);
                ttt.lekva.Add("Небиволол", 185);
                ttt.lekva.Add("Ксарелто", 1699);
                var res = ttt.GetMax(ttt);
                Console.WriteLine($"Самое дорогое лекарство - {res}");
                Console.WriteLine("*******************************");
                /////////////////////////////////////   
                decimal sum1 = ttt.Sum(ttt);
                Console.WriteLine($"Стоимость всех лекарств в аптеке составляет: {sum1} рублей");
                Console.WriteLine("*******************************");
                Console.WriteLine("Список всех лекарств в " + atpeka2.Aptekaname);
                ttt.Spisok(ttt);
            }
            else if (num == 3)
            {
                AptekaClass atpeka3 = new AptekaClass();
                Console.WriteLine("*******************************");
                atpeka3.Aptekaname = ("Аптека Доктора Пеля");
                Console.WriteLine(atpeka3.Aptekaname);
                Console.WriteLine("*******************************");
                /////////////////////////////////////
                AptekaClass ttt = new AptekaClass();
                ttt.lekva.Add("Нобен", 479);
                ttt.lekva.Add("Джес", 1000);
                ttt.lekva.Add("Аспаркам", 8);
                ttt.lekva.Add("Женале", 285);
                ttt.lekva.Add("Блемарен", 889);
                ttt.lekva.Add("Микразим", 91);
                var res = ttt.GetMax(ttt);
                Console.WriteLine($"Самое дорогое лекарство - {res}");
                /////////////////////////////////////   
                decimal sum1 = ttt.Sum(ttt);
                Console.WriteLine("*******************************");
                Console.WriteLine($"Стоимость всех лекарств в аптеке составляет: {sum1} рублей");
                Console.WriteLine("*******************************");
                Console.WriteLine("Список всех лекарств в " + atpeka3.Aptekaname);
                ttt.Spisok(ttt);
            }
            else if (num != 1 & num != 2 & num != 3)
            {
                Console.WriteLine("Вы ввели неверный номер аптеки!");
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}