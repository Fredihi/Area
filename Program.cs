using System;
using System.Security.Cryptography.X509Certificates;

namespace Area
{
    internal class Program
    {
        public class Circle
        {
            float _pi = 3.141f;
            int _radius;
            float _area;

            public Circle(int Radius)
            {
                this._radius = Radius;
            }

            public void getArea()
            {
                _area = _radius * _radius * _pi;
                Console.WriteLine("Arean på circeln är {0}",_area);
            }
        }

        static void Main(string[] args)
        {
            Circle rad5 = new Circle(5);
            rad5.getArea();
            Circle rad6 = new Circle(6);
            rad6.getArea();
        }
    }
}
