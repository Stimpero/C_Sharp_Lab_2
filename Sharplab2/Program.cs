using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;

namespace Sharplab2
{
    class SharpLab2
    {
        static void Main(string[] args)
        {
            void PrintMenu()
            {
                Console.WriteLine();
                Console.WriteLine("0. Выход");
                Console.WriteLine("1. Комплексные числа");
                Console.WriteLine("2. Шахматная доска");
                Console.WriteLine("3. Даты");
                Console.WriteLine("4. Числа Армстронга");
                Console.WriteLine("5. Кол-во квадратов");
                Console.WriteLine("6. К1 Треугоьник(В1)");
                Console.WriteLine("7. К2 Проверка на четность");
                Console.WriteLine("8. К3 Проверка принадлежности точки фигуре");
                Console.WriteLine("9. К4 Дан порядковый номер месяца, вывести на экран количество месяцев оставшихся до конца года.");
                Console.WriteLine("10. К5 Таблица конвертации дюймов в сантиметры");
                Console.WriteLine("11. К6  Печать по шаблону");
                Console.WriteLine();
            }
            PrintMenu();

            int button = int.Parse(Console.ReadLine());
            while (button != 0) //0 - exit
            {
                switch (button)
                {
                    case 1://Комплексные числа
                        {
                            Complex c1 = new Complex(1, 1);
                            Complex c2 = new Complex(1, 1);
                            Complex c3 = (Complex.sum(c1, c2));
                            Console.WriteLine(Complex.ToString(c3));

                            Complex c11 = new Complex(1, 1);
                            Complex c21 = new Complex(1, -101);
                            Complex c31 = (Complex.sum(c11, c21));
                            Console.WriteLine(Complex.ToString(c31));
                        }
                        break;

                    case 2://Доска
                        {
                            Console.WriteLine("1-готовые доски, 2-своя доска");
                            int flag = int.Parse(Console.ReadLine());
                            switch (flag)
                            {
                                case 1:
                                    {
                                        Desk Desk1 = new Desk(10, 2, 2, 3, 3, 1);   //Пешка +
                                        Desk Desk1no = new Desk(10, 2, 2, 3, 2, 1); //Пешка -
                                        Desk Desk2 = new Desk(10, 2, 2, 3, 3, 2);   //Слон +
                                        Desk Desk2no = new Desk(10, 2, 1, 3, 3, 2); //Слон -
                                        Desk Desk3 = new Desk(10, 2, 2, 2, 3, 3);   //Ладья +
                                        Desk Desk3no = new Desk(10, 2, 2, 3, 3, 3); //Ладья -
                                        Desk Desk4 = new Desk(10, 2, 2, 3, 3, 4);   //Ферзь +
                                        Desk Desk4no = new Desk(10, 2, 2, 3, 4, 4); //Ферзь -
                                        Desk Desk5 = new Desk(10, 2, 2, 4, 1, 5);   //Конь +
                                        Desk Desk5no = new Desk(10, 2, 2, 4, 2, 5); //Конь -

                                        Console.WriteLine("Количество клеток на доске со стороной " + Desk1.n + "=" + Desk.Count(Desk1));

                                        Desk.Eating(Desk1);//Проверка атаки
                                        Desk.Eating(Desk1no);
                                        Desk.Eating(Desk2);
                                        Desk.Eating(Desk2no);
                                        Desk.Eating(Desk3);
                                        Desk.Eating(Desk3no);
                                        Desk.Eating(Desk4);
                                        Desk.Eating(Desk4no);
                                        Desk.Eating(Desk5);
                                        Desk.Eating(Desk5no);
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("Введите размер стороны шахматной доски");
                                        int size = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Введите тип фигуры 1-пешка, 2-слон, 3-Ладья, 4-Ферзь, 5-конь");
                                        int fig = int.Parse(Console.ReadLine());
                                       
                                        Console.WriteLine("Введите координаты атакующей фигуры");
                                        int xAtt = int.Parse(Console.ReadLine());
                                        int yAtt = int.Parse(Console.ReadLine());
                                        

                                        Console.WriteLine("Введите координаты другой фигуры");
                                        int xDef = int.Parse(Console.ReadLine());
                                        int yDef = int.Parse(Console.ReadLine());

                                        Desk DeskInput = new Desk(size, xAtt, yAtt, xDef, yDef, fig);
                                        Console.WriteLine("Количество клеток на доске со стороной " + DeskInput.n + "=" + Desk.Count(DeskInput));

                                        Desk.Eating(DeskInput);
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Ошибка");
                                    break;
                            }

                            Console.WriteLine("Цвет клетки: Введите 2 числа - координаты клетки");//Цвет клетки
                            int k = int.Parse(Console.ReadLine());
                            int m = int.Parse(Console.ReadLine());
                            Console.WriteLine(Desk.Color(k, m));

                            Console.WriteLine("Одинаковый цвет двух клеток :Введите 2 числа - координаты первой клетки");//Одинаковый цвет
                            int k1 = int.Parse(Console.ReadLine());
                            int m1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите 2 числа - координаты второй клетки");
                            int k2 = int.Parse(Console.ReadLine());
                            int m2 = int.Parse(Console.ReadLine());
                            Console.WriteLine(Desk.SameSquare(k1, m1, k2, m2));

                        }
                        break;

                    case 3://Даты
                        {
                            DateTime d1 = new DateTime(2020, 02, 29);

                            DateTime nowDate = DateTime.Now;
                            string passedDays = Date.daysFromStart(d1); // Количество дней с даты d1
                            Console.WriteLine(passedDays);

                            string remainDays = Date.daysToEnd(d1); // Количество дней с даты d1 до конца года
                            Console.WriteLine(remainDays);

                            Console.WriteLine("Yesterday - {0}.{1}.{2}", (d1.AddDays(-1)).Year, (d1.AddDays(-1)).Month, (d1.AddDays(-1)).Day); //d-1
                            Console.WriteLine("Tomorrow - {0}.{1}.{2}", (d1.AddDays(1)).Year, (d1.AddDays(1)).Month, (d1.AddDays(1)).Day);     //d+1
                        }
                        break;

                    case 4://Числа Армстронга 1^3 + 5^3 + 3^3 = 153.
                        {
                            Armstrong.armstrong();
                        }
                        break;

                    case 5: //Кол-во квадратов
                        {
                            Console.WriteLine("Введите стороны прямоугольника");
                            Console.Write("a=");
                            int firstSide = int.Parse(Console.ReadLine());
                            Console.Write("b=");
                            int secondSide = int.Parse(Console.ReadLine());
                            Console.WriteLine("Кол-во больших квадратов = " + Square.Squares(firstSide, secondSide));
                            Console.WriteLine("Кол-во маленьких квадратов = " + firstSide * secondSide);
                        }
                        break;

                    //В 20
                    case 6:// K1  Треугоьник(В1)  1.	площадь равностороннего треугольника, периметр которого равен p;
                        {
                            Console.Write("Введите периметр треугольника p=");
                            int P = int.Parse(Console.ReadLine());
                            Console.WriteLine("Площадь равностороннего треугольника = " + RightTriangle.Area(P));
                        }
                        break;

                    case 7: //К2    1.	является ли заданное целое число четным;
                        {
                            Console.Write("Является ли заданное целое число четным.\n введите число n=");
                            int num = int.Parse(Console.ReadLine());
                            Console.WriteLine(EvenNumber.Check(num));
                        }
                        break;

                    case 8://К3 20. Проверка принадлежности точки фигуре
                        {
                            Figure.FigureCheck();
                        }
                        break;

                    case 9://К4 1.	Дан порядковый номер месяца, вывести на экран количество месяцев оставшихся до конца года.
                        {
                            Months.ToEndOfYear();
                        }
                        break;

                    case 10: //К5 4. таблица перевода расстояний в дюймах в сантиметры для значений 2, 4, 6, …, 12 дюймов (1 дюйм = 25.4 мм);
                        {
                            Units.Convert();
                        }
                        break;

                    case 11: //К6 20 печать по шаблону
                        {
                            TrianglePrint.Print();
                        }
                        break;


                }

                PrintMenu();
                button = int.Parse(Console.ReadLine());
            }
        }
    }

   
}



