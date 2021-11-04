using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия");
            ArithProgression arithProgression = new ArithProgression(2, 5);
            arithProgression.setStart();

            arithProgression.getNext();

            arithProgression.reset();
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Геометрическая прогрессиия");
            GeomProgression geomProgression = new GeomProgression(3, 3);
            geomProgression.setStart();
            geomProgression.getNext();
            geomProgression.reset();
            Console.ReadKey();



        }
    }

    interface ISeries
    {
        void setStart();
        int getNext();
        void reset();



    }

    class ArithProgression : ISeries
    {
        public int number;
        int d;
        public int D
        {
            get
            {
                return d;

            }

            set
            {
                if (d < 0)
                {
                    Console.WriteLine("Ошибка,значение отрицательно");

                }
                else
                {
                    d = value;

                }

            }



        }
        public int Number
        {
            get
            {
                return number;

            }


            set
            {
                number = value;

            }


        }




        public ArithProgression(int number, int d)
        {
            Number = number;
            D = d;

        }


        public void setStart()
        {
            Console.WriteLine("Начальное значение ряда = {0}", number);
        }

        public int getNext()
        {
            number += d;
            Console.WriteLine("Следующее значение ряда = {0}", number);

            return number;


        }

        public void reset()
        {
            Console.WriteLine("Начальное значение ряда = {0}", number);
        }


    }

    class GeomProgression : ISeries
    {
        public int number;
        int q;
        public int Q
        {
            get
            {
                return q;

            }

            set
            {
                if (q < 0)
                {
                    Console.WriteLine("Ошибка,значение отрицательно");

                }
                else
                {
                    q = value;

                }

            }



        }
        public int Number
        {
            get
            {
                return number;

            }


            set
            {
                number = value;

            }


        }


        public GeomProgression(int number, int q)
        {
            Number = number;
            Q = q;

        }


        public void setStart()
        {
            Console.WriteLine("Начальное значение ряда = {0}", number);
        }

        public int getNext()
        {
            number *= q;
            Console.WriteLine("Следующее значение ряда = {0}", number);

            return number;


        }

        public void reset()
        {
            Console.WriteLine("Начальное значение ряда = {0}", number);
        }
    }
}
