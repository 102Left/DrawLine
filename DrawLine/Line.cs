using System;
using System.Collections.Generic;
using System.Linq;

namespace DrawLine
{
    class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Line(){}

        public Line(Point Start, Point End)
        {

            this.Start = new Point(Start);
            this.End = new Point(End);
        }

        public Line(Line source)
        {
            this.Start = new Point(source.Start);
            this.End = new Point(source.End);
        }
    }
}
