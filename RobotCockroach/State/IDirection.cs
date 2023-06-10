using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RobotCockroach.State
{
    abstract class IDirection
    {
        protected Dictionary<string, Direction> Trends = new Dictionary<string, Direction>(){
            {"Up", Direction.Up },
            {"Down", Direction.Down },
            {"Left", Direction.Left },
            {"Right", Direction.Right }};
        protected int step { get; set; }
        public Bitmap image { get; set; }
        public abstract void Step(ref int X, ref int Y);
        abstract public IDirection ChangeTrend(string command);
        protected Direction Trend => Direction.Up;

    }
}
