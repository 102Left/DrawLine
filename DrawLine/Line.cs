using System;
using System.Collections.Generic;
using System.Linq;

namespace DrawLine
{
    class Line
    {
        public List<Point> Points { get; set; }

        public Line()
        {
            this.Points = new List<Point>();
        }
        public Line(List<Point> points)
        {
            this.Points = new List<Point>(points);
        }
        public Line(Line source)
        {
            this.Points = new List<Point>(source.Points);
        }
    }
}
