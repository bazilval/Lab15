using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:

метод void setStart(int x) - устанавливает начальное значение
метод int getNext() - возвращает следующее число ряда
метод void reset() - выполняет сброс к начальному значению
Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. 
В классах реализовать методы интерфейса в соответствии с логикой арифметической и 
геометрической прогрессии соответственно.

*/
namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression a = new ArithProgression();
            a.setStart(10);
            a.setDifference(5);
            Console.WriteLine(a.getNext());
            Console.WriteLine();

            GeomProgression g = new GeomProgression();
            g.setStart(10);
            g.setMultiply(5);
            Console.WriteLine(g.getNext());

            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        private int x = 0;
        private int d = 0;
        private int xn;
        public int getNext()
        {
            xn += d;
            return xn;
        }

        public void reset()
        {
            xn = x;
        }

        public void setStart(int x)
        {
            this.x = x;
            this.xn = x;
        }
        public void setDifference(int d)
        {
            this.d = d;
        }
    }
    class GeomProgression : ISeries
    {
        private int x = 0;
        private int q = 1;
        private int xn;
        public int getNext()
        {
            xn *= q;
            return xn;
        }

        public void reset()
        {
            xn = x;
        }

        public void setStart(int x)
        {
            this.x = x;
            this.xn = x;
        }
        public void setMultiply(int q)
        {
            this.q = q;
        }
    }
}
