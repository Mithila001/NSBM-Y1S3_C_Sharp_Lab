using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab_2024_02_14__Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle1 = new Rectangle(5, 3,"Rectangle");
        }
    }

    class Shape
    {
        public string shapeType { get; set; }
        public double area { get; set; }

        double calculateArea(double val1, double val2, string shape)
        {
            if(shape == "Rectangle")
            {
                area =  val1 * val2;
                return area;
            }
            else if(shape == "circle")
            {
                area = 3.14159265 * val1 * val1;
                return area;
            }
            else
            {
                return 0;
            }
        }
        void displayShapeInfo(double area, string shapType)
        {
            Console.WriteLine("");

        }
        void shape()
        {
            

        }
    }
    
    class Rectangle:Shape
    {
        public double length { get; set; }
        public double width { get; set; }
        public string ShapeType {  get; set; }
        
        public Rectangle ( double width, double length, string ShapeType)
        {
            this.width = width;
            this.length = length;
            this.shapeType = ShapeType;
        }

        

        void SetDemention(double length, double width)
        {
            double val1 = length;
            double val2 = width;



        }
    }

    class Circle
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        void setRadius(double radius)
        {

        }
    }
}
