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
        Animation animation;

        public Animation Animation
        {
            get { return animation; }
            set { animation = value; }
        }

        public Vector2 Speed { get; set ; }
        public Vector2 Position { get ; set ; }
        public IInputReader InputReader { get ; set; }

        public Michael(Texture2D texture, Vector2 speed, Vector2 position, IInputReader inputReader)
        {
            
            michaelTexture = texture;
            animation = new Animation();
            movementManager = new MovementManager();
            this.Speed = speed;
            this.Position = position;
            this.InputReader = inputReader;
            
            
            
            // X begint op 48 want sprite sheet heeft veel whitespace

            animation.AddFrame(new AnimationFrame(new Rectangle(55, 0, 18, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(72, 0, 20, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(93, 0, 14, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(106, 0, 22, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(128, 0, 18, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(146, 0, 16, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(162, 0, 18, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(180, 0, 17, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(200, 0, 15, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(215, 0, 15, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(230, 0, 21, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(251, 0, 22, 48)));

        }

        public void Update(GameTime gameTime)
        {
            Move();

            animation.Update(gameTime);
            
        }

        private void Move()
        {
            movementManager.Move(this);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(michaelTexture, Position, animation.CurrentFrame.SourceRectangle, Color.White);

        }

        void IMovable.Move()
        {
            throw new NotImplementedException();
        }
    }
}
