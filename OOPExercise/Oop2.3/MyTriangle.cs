﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OopEx
{
    class MyTriangle
    {
        private MyPoint v1;
        private MyPoint v2;
        private MyPoint v3;

        public MyTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            v1 = new MyPoint(x1, y1);
            v2 = new MyPoint(x2, y2);
            v3 = new MyPoint(x3, y3);
        }
        public MyTriangle(MyPoint v1, MyPoint v2, MyPoint v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
        public override string ToString()
        {
            return string.Format("MyTriangle[v1={0},v2={1},v3={2}]", this.v1, this.v2, this.v3);
            //return base.ToString();
        }
        public double getPerimeter()
        {
            return v1.distance(v2) + v2.distance(v3) + v1.distance(v3);


        }
        public string getType()
        {

            if (v1.distance(v2) == v1.distance(v3) && v1.distance(v3) == v2.distance(v3))
            {
                return "Equilateral";
            }
            else if (v1.distance(v2) == v1.distance(v3) || v1.distance(v2) == v2.distance(v3) || v1.distance(v3) == v2.distance(v3))
            {
                return "Isosceles";
            }
            return "Scalene";

        }
    }
}
