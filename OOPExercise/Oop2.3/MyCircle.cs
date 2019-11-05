using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEx
{
    class MyCircle
    {
        private MyPoint center;
        private int radius = 1;
        public MyCircle()
        {
            center = new MyPoint(0, 0);
            radius = 1;
        }
        public MyCircle(int x, int y, int radius)
        {
            center = new MyPoint(x, y);
            this.radius = radius;
        }
        public MyCircle(MyPoint center, int radius)
        {
            this.center = center;
            this.radius = radius;
        }
        public int getRadius()
        {
            return radius;
        }
        public void setRadius(int radius)
        {
            this.radius = radius;
        }
        public MyPoint getCenter()
        {
            return center;
        }
        public void setCenter(MyPoint center)
        {
            this.center = center;
        }
        public int getCenterX()
        {
            return center.getX();
        }
        public void setCenterX(int x)
        {
            center.setX(x);
        }
        public int getCenterY()
        {
            return center.getY();
        }
        public void setCenterY(int y)
        {
            center.setY(y);
        }
        public int[] getCenterXY()
        {
            int[] xy = new int[2];
            xy[0] = center.getX();
            xy[1] = center.getY();
            return xy;
        }
        public void setCenterXY(int x, int y)
        {
            center.setX(x);
            center.setY(y);
        }
        public override string ToString()
        {
            return string.Format("My circle[radius = {0},center = {1}]", getRadius(), center.ToString());
            //return base.ToString();
        }
        public double getArea()
        {
            return radius * radius * Math.PI;
        }
        public double getCircumference()
        {
            return 2 * radius * Math.PI;
        }
        public double distance(MyCircle another)
        {
            return center.distance(another.center);
        }
    }
}