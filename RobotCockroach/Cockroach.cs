using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace RobotCockroach
{
    class Cockroach
    {
        public Bitmap Image { get; set; }
        public direction trend = direction.Up;
        const int step = 30;

        public int X { get; set; }
        public int Y { get; set; }
        public Cockroach(Bitmap _Image)
        {
            Image = _Image;
        }

        public void Step(int value)
        {
            switch (trend)
            {
                case direction.Right: X += value; break;
                case direction.Down: Y += value; break;
                case direction.Left: X -= value; break;
                case direction.Up: Y -= value; break;
            }
        }

        //Изменение направления, параметр – первая буква направления
        public void ChangeTrend(char c)
        {
            direction newtrend = trend;
            for (direction y = direction.Up; y <= direction.Left; y++)
                if (char.ToLower(c) == char.ToLower(y.ToString()[0]))
                {
                    newtrend = y;
                    break;
                }
            switch (trend)
            {
                case direction.Up:
                    switch (newtrend)
                    {
                        case direction.Right: Image.RotateFlip(RotateFlipType.Rotate90FlipNone); break;
                        case direction.Down: Image.RotateFlip(RotateFlipType.Rotate180FlipNone); break;
                        case direction.Left: Image.RotateFlip(RotateFlipType.Rotate270FlipNone); break;
                    }
                    break;
                case direction.Right:
                    switch (newtrend)
                    {
                        case direction.Up: Image.RotateFlip(RotateFlipType.Rotate270FlipNone); break;
                        case direction.Down: Image.RotateFlip(RotateFlipType.Rotate90FlipNone); break;
                        case direction.Left: Image.RotateFlip(RotateFlipType.Rotate180FlipNone); break;
                    }
                    break;
                case direction.Down:
                    switch (newtrend)
                    {
                        case direction.Up: Image.RotateFlip(RotateFlipType.Rotate180FlipNone); break;
                        case direction.Right: Image.RotateFlip(RotateFlipType.Rotate270FlipNone); break;
                        case direction.Left: Image.RotateFlip(RotateFlipType.Rotate90FlipNone); break;
                    }
                    break;
                case direction.Left:
                    switch (newtrend)
                    {
                        case direction.Up: Image.RotateFlip(RotateFlipType.Rotate90FlipNone); break;
                        case direction.Down: Image.RotateFlip(RotateFlipType.Rotate270FlipNone); break;
                        case direction.Right: Image.RotateFlip(RotateFlipType.Rotate180FlipNone); break;
                    }
                    break;
            }
            trend = newtrend;
        }
    }


}

