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
        public bool visible;
        //array of Elements
        public ArrayList elements = new ArrayList();

        public void AddElement(Element newElement){
            elements.Add(newElement);
        }

        public void RemoveElement(int index)
        {
            elements.RemoveAt(index);
        }
        public Scene(int x, int y, Texture2D background)
        {
            this.x = x;
            this.y = y;
            this.width = background.Bounds.Width;
            this.height = background.Bounds.Height;
            this.background = background;
        }
        public Scene(int x, int y, int height, int width, Texture2D background)
        {

        }

    }
}
