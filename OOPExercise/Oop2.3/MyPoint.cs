using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEx
{
    class MyPoint
    {
        private int x = 0;
        private int y = 0;

        public MyPoint()
        {
            x = 0;
            y = 0;
        }
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public int getY()
        {
            return y;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public int[] getXY()
        {
            int[] xy = new int[2];
            xy[0] = this.x;
            xy[1] = this.y;
            return xy;
        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return string.Format("({0},{1})", getX(), getY());
            //return base.ToString();
        }
        public double distance(int x, int y)
        {
            int xDiff = this.x - x;
            int yDiff = this.y - y;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }
        public double distance(MyPoint another)
        {
            int xDiff = this.x - another.x;
            int yDiff = this.y - another.y;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }
        public double distance()
        {

            return distance(0, 0);
        }
    }
}