using System;
using System.Collections.Generic;
using System.Linq;
using DxLibDLL;

namespace DrawLine
{
    class Application
    {
        static void Main()
        {
            /*
            Information.WindowTitle = "Draw Line by Clicks";
            Information.WindowWidth = 800;
            Information.WindowHeight = 600;
            Information.BitsOfColor = 32;
            Information.BackColor = new DxColor(255, 255, 255);
            Information.LineColor = new DxColor(0, 0, 0);
            //Information.GridNumber;   //後々変更してください

            DX.ChangeWindowMode(DX.TRUE);
            DX.SetMainWindowText(Information.WindowTitle);
            DX.SetGraphMode(Information.WindowWidth, Information.WindowHeight, Information.BitsOfColor);
            DX.SetWindowSizeChangeEnableFlag(DX.TRUE);
            DX.SetBackgroundColor(Information.BackColor.Red, Information.BackColor.Green, Information.BackColor.Blue);

            if (DX.DxLib_Init() != 0) { return; }
            */

        }

        static void output()
        {
            //線を順に描画する(テスト用)
            /*
            foreach(var line in Information.Lines)
            {
                foreach(var point in line)
                {
                    DX.DrawLine(point.Start.X, point.Start.Y, point.End.X, point.End.Y, Information.LineColor.Get());
                }
            }
            */
        }

        static void input()
        {

        }
    }
}
