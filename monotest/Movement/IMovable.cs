using Microsoft.Xna.Framework;
using monotest.Animations;
using monotest.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monotest.Movement
{
    public interface IMovable
    {
        public Vector2  Speed { get; set; }
        public Vector2 Position { get; set; }
        public IInputReader InputReader { get; set; }
        public Animation Animation { get; set; }
        void Move();
    }
}
