using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using RobotCockroach.State;

namespace RobotCockroach
{
    class Cockroach
    {
        private Bitmap image;
        public Bitmap Image
        {
            get
            {
                return image;
            }
            set
            {
                if (direction != null)
                    direction.image = value;
                image = value;
            }
        }
    

        //public Direction trend = Direction.Up;

        IDirection direction;

        public int X;
        public int Y;
        public Cockroach(Bitmap _Image)
        {
            Image = _Image;
            direction = new DirectionUp(Image);
        }

        public void Step()
        {
            direction.Step(ref X, ref Y);
        }

        public void ChangeTrend(string command)
        {
            direction = direction.ChangeTrend(command);
        }

        public void SetSkin(Bitmap image)
        {
            Image = image;
            direction = new DirectionUp(Image);
        }
        
    }


}

