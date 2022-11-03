using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using monotest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monotest.Animations;
using System.Drawing.Text;
using SharpDX.MediaFoundation;
using monotest.Input;
using monotest.Movement;

namespace monotest
{
    public class Michael:IGameObject, IMovable
    {
        Texture2D michaelTexture;
        
        MovementManager movementManager;
        Animation animationWalking;
        Animation animationIdle;

        public Animation Animation
        {
            get { return animationWalking; }
            set { animationWalking = value; }
        }

        public Vector2 Speed { get; set ; }
        public Vector2 Position { get ; set ; }
        public IInputReader InputReader { get ; set; }

        public Michael(Texture2D texture, Vector2 speed, Vector2 position, IInputReader inputReader)
        {
            
            michaelTexture = texture;
            animationWalking = new Animation();
            animationIdle = new Animation();
            movementManager = new MovementManager();
            this.Speed = speed;
            this.Position = position;
            this.InputReader = inputReader;
            
            
            
            // X begint op 48 want sprite sheet heeft veel whitespace

            animationWalking.AddFrame(new AnimationFrame(new Rectangle(55, 0, 18, 48)));
            animationWalking.AddFrame(new AnimationFrame(new Rectangle(72, 0, 20, 48)));
            animationWalking.AddFrame(new AnimationFrame(new Rectangle(93, 0, 14, 48)));
            animationWalking.AddFrame(new AnimationFrame(new Rectangle(106, 0, 22, 48)));
            animationWalking.AddFrame(new AnimationFrame(new Rectangle(128, 0, 18, 48)));
            animationWalking.AddFrame(new AnimationFrame(new Rectangle(146, 0, 16, 48)));
            animationWalking.AddFrame(new AnimationFrame(new Rectangle(162, 0, 18, 48)));
            animationWalking.AddFrame(new AnimationFrame(new Rectangle(180, 0, 17, 48)));
            animationWalking.AddFrame(new AnimationFrame(new Rectangle(200, 0, 15, 48)));
            animationWalking.AddFrame(new AnimationFrame(new Rectangle(215, 0, 15, 48)));
            animationWalking.AddFrame(new AnimationFrame(new Rectangle(230, 0, 21, 48)));
            animationWalking.AddFrame(new AnimationFrame(new Rectangle(251, 0, 22, 48)));

            //idle animation
            
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(52, 330, 28, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(52, 330, 28, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(52, 330, 28, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(0, 330, 19, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(0, 330, 19, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(0, 330, 19, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(18, 330, 17, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(18, 330, 17, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(18, 330, 17, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(78, 330, 29, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(78, 330, 29, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(78, 330, 29, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(34, 330, 17, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(34, 330, 17, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(34, 330, 17, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(18, 330, 17, 55)));
            

            animationIdle.AddFrame(new AnimationFrame(new Rectangle(18, 330, 17, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(18, 330, 17, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(140, 148, 20, 50)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(123, 148, 18, 50)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(105, 148, 19, 49)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(82, 148, 24, 49)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(161, 148, 20, 49)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(18, 330, 17, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(18, 330, 17, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(18, 330, 17, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(215, 270, 17, 52)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(232, 270, 26, 52)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(232, 270, 26, 52)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(232, 270, 26, 52)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(232, 270, 26, 52)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(232, 270, 26, 52)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(215, 270, 17, 52)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(18, 330, 17, 55)));
            animationIdle.AddFrame(new AnimationFrame(new Rectangle(18, 330, 17, 55)));


        }

        public void Update(GameTime gameTime)
        {
            Move();

            animationIdle.Update(gameTime, 5);
            
        }

        private void Move()
        {
            movementManager.Move(this);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(michaelTexture, Position, animationIdle.CurrentFrame.SourceRectangle, Color.White);

        }

        void IMovable.Move()
        {
            throw new NotImplementedException();
        }
    }
}
