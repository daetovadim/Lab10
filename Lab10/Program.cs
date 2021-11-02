using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle();

            try
            {
                Console.Write("Введите положительное значение числа градусов: ");
                angle.Gradus = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите положительное значение числа минут: ");
                angle.Min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите положительное значение числа секунд: ");
                angle.Sec = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nПолучившийся угол в радианах: " + angle.ToRadians());
            }
            catch(FormatException)
            {
                Console.WriteLine("\nНевозможно преобразовать введённое значение в число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nВведённое значение слишком большое.");
            }

            Console.ReadKey();
        }
    }

    class Angle
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            set
            {
                if (value < 0 || value > 360)
                    Console.WriteLine("Ошибка! Значение числа градусов должно находиться в диапазоне от 0 до 360. По-умолчанию установлено значение 0\n");
                else                
                    gradus = value;                                 
            }
            get
            {
                return gradus;
            }
        }

        public int Min
        {
            set
            {
                if (value < 0 || value > 60)
                    Console.WriteLine("Ошибка! Значение числа минут должно находиться в диапазоне от 0 до 60. По-умолчанию установлено значение 0\n");
                else
                    min = value;
            }
            get
            {
                return min;
            }
        }

        public int Sec
        {
            set
            {
                if (value < 0 || value > 60)
                    Console.WriteLine("Ошибка! Значение числа секунд должно находиться в диапазоне от 0 до 60. По-умолчанию установлено значение 0\n");
                else
                    sec = value;
            }
            get
            {
                return sec;
            }
        }

        public Angle(int gradus = 0, int min = 0, int sec = 0)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public double ToRadians()
        {
            double grad = (Gradus + (double)Min / 60  + (double)Sec / 3600) / 180 * Math.PI;
            return grad;
        }
    }
}
