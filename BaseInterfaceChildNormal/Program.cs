using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInterfaceChildNormal
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cr = new Circle();
            cr.calculatearea();
            cr.calculateperimeter();
            
        }

        public interface IArea
        {
            void calculatearea();

            void calculateperimeter();
            
        }

        public interface ICircleArea
        {
            void calculatearea();          

        }

        public class Circle: IArea, ICircleArea
        {
            public void calculatearea()
            {
                Console.WriteLine("child class area");
            }

            public void calculateperimeter()
            {
                Console.WriteLine("child class perimeter");
            }

        } 


    }
}
