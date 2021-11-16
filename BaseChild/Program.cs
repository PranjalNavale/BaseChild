using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseChild
{
    class Program
    {
        static void Main(string[] args)

        {
            Area ar = new Area();
            ar.calculatearea();
            ar.calculateperimeter();
            Circle cr = new Circle();
            cr.calculatearea();
            cr.calculateperimeter();
            Area arcr = new Circle();
            arcr.calculatearea();
            arcr.calculateperimeter();
            
        }

        public class Area
        {

            public  virtual void calculatearea()
            {
                Console.WriteLine("base class area");
            }

            public  void calculateperimeter()
            {
                Console.WriteLine("base class perimeter");
            }
        }

        public class Circle : Area
        {

            public override void calculatearea()
            {

                Console.WriteLine("child class area");
            }

            public new void calculateperimeter()
            {
                Console.WriteLine("child class perimeter");
            }
        }
    }
}
