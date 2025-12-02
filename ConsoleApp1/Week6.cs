using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Week6
    {
        private double length;
        private double breadth;

        public double length1
        {
            get { return length; }
            set { length = value; }
        }
        public double breadth1
        {
            get { return breadth; }
            set { breadth = value; }
        }
        public double perimeter(double length, double breadth) => 2*(length + breadth);
        public double GetArea() => length * breadth;
        public string ShowDetails()
        {
            return $"Length: {length}, Breadth: {breadth}, Area: {GetArea()}, Perimeter: {perimeter(length, breadth)}";
        }





    }
}
