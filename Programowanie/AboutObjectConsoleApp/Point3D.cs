using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutObjectConsoleApp
{
    internal class Point3D : Point
    {
        public int Z { get; set; }

        public Point3D() /*: base()*/
        {
            Z = 58;
        }

        public Point3D(int q, int w, int e) : base(q, w)
        {
            /*X = q;
            Y = w;*/
            Z = e;
        }

        public new void Show()
        {
            Console.WriteLine($"({x},{Y},{Z})");
            //base.Show();
        }
    }
}


class A /*: C*/
{

}

class B : A
{

}

class C : B
{

}