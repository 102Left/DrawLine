using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLine
{
    class Information
    {
        public static string WindowTitle;
        public static int WindowWidth;
        public static int WindowHeight;
        public static int BitsOfColor;
        public static DxColor BackColor;
        public static DxColor LineColor;
        public static int GridNumber;
        public static int CircleErrorRange;

        public static List<List<Line>> Lines = new List<List<Line>>();

        
    }
}
