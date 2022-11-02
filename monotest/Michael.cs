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
            animation.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(michaelTexture, new Vector2(0, 0), animation.CurrentFrame.SourceRectangle, Color.White);

        }

        
    }
}
