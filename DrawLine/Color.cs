using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace DrawLine
{
    class DxColor
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public DxColor(int Red, int Green, int Blue)
        {
            this.Red = Red;
            this.Green = Green;
            this.Blue = Blue;
        }
        public DxColor(DxColor source)
        {
            this.Red = source.Red;
            this.Green = source.Green;
            this.Blue = source.Blue;
        }

        public uint Get()
        {
            return DX.GetColor(this.Red, this.Green, this.Blue);
        }

        public uint Get(DxColor source)
        {
            return DX.GetColor(source.Red, source.Green, source.Blue);
        }
    }
}
