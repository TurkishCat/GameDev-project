using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using monotest.Animations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monotest.Input
{
    public class KeyboardReader : IInputReader
    {
        public bool IsWalking { get; set; } = false;
        public Vector2 ReadInput()
        {
            KeyboardState state = Keyboard.GetState();

            var direction = Vector2.Zero;

            if (state.IsKeyDown(Keys.Left))
            {
                direction.X -= 1;
                IsWalking = true;
            }
            
            
            if (state.IsKeyDown(Keys.Right))
            {
                direction.X += 1;
                IsWalking = true;
            }
            


            if (state.IsKeyDown(Keys.Up))
            {
                direction.Y -= 1;
                IsWalking = true;
            }
            

            if (state.IsKeyDown(Keys.Down))
            {
                direction.Y += 1;
                IsWalking = true;
            }

            if(state.GetPressedKeys().Length == 0 || state.GetPressedKeys() == null)
            {
                IsWalking = false;
            }
            

            return direction;

        }
    }
}
