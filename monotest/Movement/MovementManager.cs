using Microsoft.Xna.Framework;
using monotest.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monotest.Movement
{
    public  class MovementManager 
    {
        

        public MovementManager()
        {
            
        }
        

        

        public void Move(IMovable movable)
        {

            var direction = movable.InputReader.ReadInput(); // kijkt of je links of rechts gaat
            direction *= movable.Speed; // bepaalt de grootte van de stappen kijkend naar de snelheid
            movable.Position += direction; // veranderd effectief positie van object

            var afstand = direction * movable.Speed; //afstand laatste stap
            var toekomstigePositie = movable.Position + afstand;
            movable.Position = toekomstigePositie;
            movable.Position += afstand;


            try
            {
                if (
                                (toekomstigePositie.X > (800 - movable.Animation.CurrentFrame.SourceRectangle.Width)
                                 || movable.Position.X < 0) ||
                                 (toekomstigePositie.Y > 480 - movable.Animation.CurrentFrame.SourceRectangle.Height
                                 || movable.Position.Y < 0)
                                )
                {
                    movable.Position = toekomstigePositie;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            //if (position.X > 800 - animation.CurrentFrame.SourceRectangle.Width || position.X < 0 )
            //{
            //    speed.X *= -1;
            //}
            //if (position.Y > 480 - animation.CurrentFrame.SourceRectangle.Height|| position.Y < 0)
            //{
            //    speed.Y *= -1;
            //}


        }


    }
}
