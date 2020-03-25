using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Complex
    {
        double re, im;

        public Complex(double r, double i)
        {
            re = r;
            im = i;
        }


        public static Complex sum(Complex C1, Complex C2)
        {
            return new Complex(C1.re + C2.re, C1.im + C2.im);
        }

        public static string ToString(Complex C1)
        {
            if (C1.im>=0)
                return "" + C1.re + "+" + C1.im + "i";
            else 
                return "" + C1.re + C1.im + "i";

        }

    }

    public class Desk
    {
        public int n, xAttacker, yAttacker, xf, yf, figure;

        public Desk(int nn, int xA, int yA, int xxf, int yyf, int ffigure)
        {
            n = nn;
            xAttacker = xA;
            yAttacker = yA;
            xf = xxf;
            yf = yyf;
            figure = ffigure;
        }
        // Количество Клеток на доске
        public static int Count(Desk C1)
        {
            return C1.n * C1.n;
        }
        //Цвет клетки
        public static string Color(int k, int m)
        {
            if ((k + m) % 2 == 0) return "black"; else return "white";

        }
        //Одинаковый цвет
        public static string SameSquare(int k1, int m1, int k2, int m2)
        {
            if (((k1 + m1) % 2 == (k2 + m2) % 2)) return "Same"; else return "Different";
        }

        public static string EatPown(int xA, int yA, int xf, int yf)
        {
            if (((xf == xA - 1) || (xf == xA + 1)) && (yf == xA - 1)) { return "Eat"; } else { return "No eat"; };

        }

        public static string EatEleph(int xEleph, int yEleph, int xf, int yf)
        {
            if (((xf - xEleph) == (yf - yEleph)) || ((xf - xEleph) == (-yf + xEleph))) { return "Eat"; } else { return "No eat"; }
        }


        public static string EatTower(int xTower, int yTower, int xf, int yf)
        {
            if ((xTower == xf) || (yTower == yf))
            return "Eat"; 
            else  return "No eat"; 
        }
        public static string EatQueen(int xQueen, int yQueen, int xf, int yf)
        {
            if ( ( ((xf - xQueen) == (yf - yQueen)) || ((xf - xQueen) == (-yf + yQueen))) ||// диагонали
                ((xQueen == xf) || (yQueen == yf)) )// вертикаль , горизонталь
            return "Eat"; 
            else  return "No eat"; 

        }

        public static string EatHorse(int xHorse, int yHorse, int xf, int yf)
        {
            if (((xHorse - 1 == xf) && (yHorse - 2 == yf)) ||// 8 позиций атаки коня 
                ((xHorse - 1 == xf) && (yHorse + 2 == yf)) ||
                ((xHorse + 1 == xf) && (yHorse - 2 == yf)) ||
                ((xHorse + 1 == xf) && (yHorse + 2 == yf)) ||
                ((xHorse - 2 == xf) && (yHorse - 1 == yf)) ||
                ((xHorse - 2 == xf) && (yHorse + 1 == yf)) ||
                ((xHorse + 2 == xf) && (yHorse - 1 == yf)) ||
                ((xHorse + 2 == xf) && (yHorse + 1 == yf))) 
             return "Eat"; 
            else  return "No eat"; 

        }

        //Фигура под ударом
        public static void Eating(Desk C1)
        {
            switch (C1.figure)
            {
                case 1: // пешка
                    Console.WriteLine("Pown " + EatPown(C1.xAttacker, C1.yAttacker, C1.xf, C1.yf));
                    break;
                case 2: // Слон
                    Console.WriteLine("Elephant " + EatEleph(C1.xAttacker, C1.yAttacker, C1.xf, C1.yf));
                    break;
                case 3: // Ладья
                    Console.WriteLine("Tower " + EatTower(C1.xAttacker, C1.yAttacker, C1.xf, C1.yf));
                    break;
                case 4: // Ферзь
                    Console.WriteLine("Queen " + EatQueen(C1.xAttacker, C1.yAttacker, C1.xf, C1.yf));
                    break;
                case 5: // Конь
                    Console.WriteLine("Horse " + EatHorse(C1.xAttacker, C1.yAttacker, C1.xf, C1.yf));
                    break;

                default:
                    Console.WriteLine("There is no such figure");
                    break;
            }
        }

    }

    public class Date
    {
        
        public static string daysFromStart(DateTime d1)
        {
            DateTime d2 = new DateTime(d1.Year,1,1);
            int days = (d1 - d2).Days;
            return "Passed " + days +" days";
        }

        public static string daysToEnd(DateTime d1)
        {
            DateTime d2 = new DateTime(d1.Year, 12, 31);
            int days = (d2 - d1).Days;
            return "Left "+ days + " days";
        }
    }

    public class Armstrong
    {

        public static void armstrong()
        {
            for(int i = 100; i < 1000; i++)
            {
                int x = i / 100;
                int y = i % 100 / 10;
                int z = i % 10;
                int q = (int)Math.Pow(x, 3) + (int)Math.Pow(y, 3) + (int)Math.Pow(z, 3);
                if (q == i) Console.WriteLine("Armstrong's number - "+ q);
            }
        }

    }

    public class Square
    {
        public static int Squares(int N, int M)
        {
            if (N == 0 || M == 0) return 0;
            if (N == M) return 1;
            int min = Math.Min(N, M);
            int max = Math.Max(N, M);
            return 1 + Squares(min, max - min);
        }
    }

    public class RightTriangle
    {
        public static double Area(double p)
        {
            double a = p / 3;
            return Math.Sqrt(3)/4*a*a ;
        }
    }

    public class EvenNumber
    {
        public static String Check(int x)
        {
            if (x % 2 == 0)
                return "even";
            else return "odd";   
        }
    }


    public class Figure
    {
        public static void FigureCheck()
        {
            Console.WriteLine("Фигура");
             Console.Write("x=");            
             float x = float.Parse(Console.ReadLine());
             Console.Write("y=");
             float y = float.Parse(Console.ReadLine());

             if (x<0 && y<23 && y>0 && x+y>0)
                 Console.WriteLine("внутри");
             else if ((x + y == 0 && x >= -23 && x <= 0) || (x == 0 && y >= 0 && y <= 23) || (x >= -23 && x <= 0 && y == 23))
                   Console.WriteLine("на границе");
                    else Console.WriteLine("вне");
        }
    }

    public class Months
    {
        public static void ToEndOfYear()
        {
            Console.WriteLine("Месяцы до конца года");   
            Console.Write("n=");            
            int n = int.Parse(Console.ReadLine());
            switch (n)
                      {
            case 1: Console.WriteLine(12-1); break;
            case 2: Console.WriteLine(12-2); break;
            case 3: Console.WriteLine(12-3); break;
            case 4: Console.WriteLine(12-4); break;
            case 5: Console.WriteLine(12-5); break;
            case 6: Console.WriteLine(12-6); break;
            case 7: Console.WriteLine(12-7); break;
            case 8: Console.WriteLine(12-8); break;
            case 9: Console.WriteLine(12-9); break;
            case 10: Console.WriteLine(12-10); break;
            case 11: Console.WriteLine(12-11); break;
            case 12: Console.WriteLine(12-12); break;
            default: Console.WriteLine("ВЫ ОШИБЛИСЬ"); break;
          }

        }
    }

    //4.	таблицу перевода расстояний в дюймах в сантиметры для значений 2, 4, 6, …, 12 дюймов (1 дюйм = 25.4 мм);
    public class Units
    {
        public static void Convert()
        {
            Console.WriteLine("Перевод дюйм в см ");
            Console.Write("n=");            
            int n = int.Parse(Console.ReadLine());

            Console.Write("while: ");
            int i = 2;           
            while (i <= n)
            {
                Console.Write(" " + i*2.54);
                i += 2;
            }

            Console.WriteLine();
            Console.Write("do while: ");
            i = 2;
            do
            {
                Console.Write(" " + i * 2.54);
                i += 2;
            }
            while (i <= n);

            Console.WriteLine();
            Console.Write("For: ");
            for (i = 2; i<=n; i+=2)
            {
                Console.Write(" " + i * 2.54);
            }
            Console.WriteLine();
         }
   }

    public class TrianglePrint
    {
        public static void Print()
        {
            int k = 5;
            int l = 3;
            for (int i = 1; i<=10; ++i, Console.WriteLine())
             {
                 if (i % 2 != 0)
                 {
                     for (int j = 1; j <= k; ++j)
                     Console.Write(" " + 2);
                    
                 }
                 else
                 {
                     for (int j = 1; j <= k; ++j)
                     {
                        Console.Write(" ");
                        Console.Write(l+j-1);
                     }
                     k--;
                     l--;
                 }

             }
        }
   }
}

        
