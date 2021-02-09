using System;
using System.Collections.Generic;
using System.Text;

namespace udemyObjectsConstructors1
{
    class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void move(Point newLocation)
        {
            if (newLocation == null)
            {
                throw new ArgumentNullException("new Location");
            }
            this.x = newLocation.x;
            this.y = newLocation.y;
            
        }
    }
}
