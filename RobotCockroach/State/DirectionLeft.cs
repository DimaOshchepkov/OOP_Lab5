﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RobotCockroach.State
{
    class DirectionLeft : IDirection
    {
        public DirectionLeft(Bitmap image)
        {
            this.image = image;
            this.step = 30;
        }

        override public IDirection ChangeTrend(string command)
        {
            Direction newtrend = Trends[command];

            switch (newtrend)
            {
                case Direction.Up:
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    return new DirectionRight(image);
                case Direction.Down:
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    return new DirectionDown(image);
                case Direction.Right:
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    return new DirectionLeft(image);
                default: return new DirectionUp(image);
            }
        }
        public override void Step(ref int X, ref int Y) => X += step;
    }
}
