using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using monotest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monotest.Animations;

namespace monotest
{
    public class Michael:IGameObject
    {
        Texture2D michaelTexture;
        
        Animation animation;

        public Michael(Texture2D texture)
        {
            michaelTexture = texture;
            animation = new Animation();

            // X begint op 48 want sprite sheet heeft veel whitespace
            animation.AddFrame(new AnimationFrame(new Rectangle(48, 0, 24, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(72, 0, 24, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(96, 0, 24, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(120, 0, 24, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(144, 0, 24, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(168, 0, 24, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(192, 0, 24, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(216, 0, 24, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(240, 0, 24, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(264, 0, 24, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(288, 0, 24, 48)));
        }

        public void Update()
        {
            animation.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(michaelTexture, new Vector2(0, 0), animation.CurrentFrame.SourceRectangle, Color.White);

        }

        
    }
}
