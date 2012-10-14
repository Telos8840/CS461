using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections;

namespace TestGame
{
    class Scene
    {
        public Texture2D background;
        public int height;
        public int width;
        public int x;
        public int y;
        ArrayList objects = new ArrayList();

        public Scene(int x, int y, Texture2D background)
        {
            
        }
        public Scene(int x, int y, int height, int width, Texture2D background)
        {

        }
        public Scene(int x, int y, Texture2D background)
        {

        }
        public void Draw(GameTime gametime){
        }
    }
}
